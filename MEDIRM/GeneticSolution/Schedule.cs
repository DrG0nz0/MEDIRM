using ProjectScheduling.SolverFoundation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static Scheduling.GeneticForm.GeneticTask;

namespace Scheduling
{
    public class Schedule
    {
        private int[] jobSchedule;
        private int[] macSchedule;
        int j, p, m;
        float[,] startTimes, finishTimes;
        float[] idleTimes;
        float totalIdleTime;
        bool makeSpanCalculated, idleCalculated;
        float makeSpan;
        private int ModelSwitches = 0;
        public Schedule(int[] js, int[] ms, int j, int p, int m)
        {
            this.j = j;
            this.p = p;
            this.m = m;
            jobSchedule = js;
            macSchedule = ms;

            makeSpanCalculated = false;
            idleCalculated = false;
            makeSpan = 0;
            startTimes = new float[j, p];
            finishTimes = new float[j, p];
            idleTimes = new float[m];
        }


        private float AverageTime()
        {
            float average = 0;

            for (int i = 0; i < j; i++)
            {
                for (int k = 0; k < p; k++)
                {
                    average += startTimes[i, k];

                }
            }
            return average / (j * p);
        }
        #region Makespan
        public bool Compare(Schedule b)
        {
            if (FitValue == b.FitValue)
            {
                if (ModelSwitches == b.ModelSwitches)
                {
                    if (FilmeSwitch == b.FilmeSwitch)
                    {

                        if (PapelSwitch == b.PapelSwitch)
                        {

                            return this.AverageTime() > b.AverageTime();
                        }
                        return PapelSwitch > b.PapelSwitch;
                    }
                    return FilmeSwitch > b.FilmeSwitch;
                }
                return ModelSwitches > b.ModelSwitches;
            }
            return FitValue > b.FitValue;
        }
        public float MakeSpan()
        {
            if (makeSpanCalculated)
                return makeSpan;

            int[] compProcs = new int[j];
            float[] totalTime = new float[m];

            int?[] lastJob = new int?[m];
            int?[] lastProc = new int?[m];
            int?[] lastMold = new int?[m];

            for (int i = 0; i < jobSchedule.Length; i++)
            {
                int job = jobSchedule[i];
                int proc = compProcs[job];
                int a = job * p + proc;
                int mac = macSchedule[a];
                int oldProc = compProcs[job] > 0 ? compProcs[job] - 1 : -1;
                var modelSwitch = 0;
                var genProcess = Data.Tasks[job].Processes[proc];
                //if (genProcess == GeneticProcess.Empty)
                //    continue;
                if (genProcess.Duration == 500000)
                    continue;

              
                Func<Func<GeneticProcess, Object>, bool> change = (Func<GeneticProcess, Object> compare) =>
                 {
                     if (!lastJob[mac].HasValue || !lastProc[mac].HasValue)
                         return false;
                     int lastProcessId = lastProc[mac].Value;
                     int lastJobId = lastJob[mac].Value;

                     var lastProcess = Data.Tasks[lastJobId].GetProcess(lastProcessId);
                     object oldTipo = compare(lastProcess);

                     var process = Data.Tasks[job].GetProcess(proc);
                     if (process == GeneticProcess.Empty)
                         return false;
                     object nTipo = process == GeneticProcess.Empty ? null : compare(process);
                     if (oldTipo != null && nTipo != null && oldTipo.ToString() != nTipo.ToString() && oldTipo != nTipo)
                     {
                         return true;
                     }
                     return false;

                };
                if (change(x => x.Machine.Molde))
                {
                    modelSwitch = 1;
                    ModelSwitches++;
                }
                if (change(x => x.Machine.Filme))
                {
                    FilmeSwitch++;
                }
                if (change(x => x.Machine.Papel))
                {
                    PapelSwitch++;
                }


                startTimes[job, proc] = Math.Max(totalTime[mac],
                                                oldProc == -1 ? 0 : finishTimes[job, oldProc]) + modelSwitch;
                //Idle time calculator
                idleTimes[mac] += startTimes[job, proc] - totalTime[mac];
                //

                var duration = genProcess == GeneticProcess.Empty ? 0 : Data.DataTable[job, proc, mac];
                //last process and job at the machine
                finishTimes[job, proc] = startTimes[job, proc] + Data.DataTable[job, proc, mac];

                if (finishTimes[job, proc] - startTimes[job, proc] > 0)
                {
                    lastJob[mac] = job;
                    lastProc[mac] = proc;
                compProcs[job]++;
                }
                ////


                totalTime[mac] = finishTimes[job, proc];
               
            }

            float result = -1;
            for (int i = 0; i < j; i++)
            {
                result = Math.Max(finishTimes[i, p - 1], result);
            }
            makeSpan = result;
            //find last idle times
            for (int i = 0; i < m; i++)
            {
                if (lastProc[i] != null)
                    idleTimes[i] += makeSpan - finishTimes[(int)lastJob[i], (int)lastProc[i]];
                else
                    idleTimes[i] = makeSpan;
                if (i == m - 1)
                    idleTimes[i] = float.Parse(idleTimes[i].ToString("0.00"));
            }
            makeSpanCalculated = true;
            return makeSpan;
        }

        #endregion

        #region Drawing

        public void DrawSchedule(Graphics grp, Control panel)
        {
            if (!makeSpanCalculated)
                MakeSpan();

            grp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            int mac = m;
            int proc = p;
            int job = j;
            int horSpace = 40;
            int vertSpace = 60;
            int delWidth = 150;

            #region Draw job delegate signs
            for (int i = 0; i < job; i++)
            {
                Rectangle rect = new Rectangle(50 * i + horSpace, 15, 15, 15);
                string text = "J" + (i + 1);
                Point tp = new Point(rect.Right + 3, rect.Y);
                using (Font font = new Font("Arial", 10))
                using (SolidBrush brush = new SolidBrush(Colors.JobColors[i]))
                {
                    grp.FillEllipse(brush, rect);
                    grp.DrawString(text, font, Brushes.Gray, tp);
                }
                if (i == job - 1)
                    delWidth = tp.X + 20;
            }
            #endregion

            panel.Height = (mac * 25 + vertSpace) + 15;
            panel.Width = (int)Math.Max(delWidth, makeSpan + horSpace + 15) + 35;
            grp.DrawRectangle(Pens.Black, 2, 2, panel.Width - 4, panel.Height - 8);

            #region Draw measure lines and texts
            int idWidth = 0;
            int count = 500;
            int num = (int)((makeSpan + 5) / count);
            for (int i = 0; i <= num; i++)
            {
                Point p1 = new Point(count * i + horSpace, vertSpace - 3);
                Point p2 = new Point(count * i + horSpace, vertSpace + (int)((mac - 0.5) * count) + 5);
                using (Font font = new Font("Arial", 7))
                {
                    grp.DrawLine(Pens.DarkGray, p1, p2);
                    string text = (count * i).ToString();
                    Size size = TextRenderer.MeasureText(text, font);
                    Point tp = new Point(p1.X - size.Width / 2 + 2, p1.Y - size.Height);
                    grp.DrawString(text, font, Brushes.DarkGray, tp);

                }
            }
            #endregion

            #region Draw gray background rectangles
            PointF itPo = Point.Empty;
            RectangleF[] backRects = new RectangleF[mac];
            for (int i = 0; i < mac; i++)
            {
                backRects[i] = new RectangleF(horSpace, vertSpace + 25 * i, makeSpan + 5, 15);
                grp.FillRectangle(Brushes.LightGray, backRects[i]);
                using (Font font = new Font("Arial", 8, FontStyle.Bold))
                {
                    if (i == 0)
                    {
                        Size idSize = TextRenderer.MeasureText("Idle", font);
                        itPo = new PointF(backRects[i].X + backRects[i].Width + 10, vertSpace - 3 - idSize.Height);
                        grp.DrawString("Idle", font, Brushes.DarkSlateGray, itPo);
                        idWidth = TextRenderer.MeasureText("Idle", font).Width;
                    }
                    string idle = idleTimes[i].ToString("0.00");
                    Size size = TextRenderer.MeasureText(idle, font);
                    grp.DrawString(idle, font, Brushes.DarkGray, itPo.X + idWidth / 2 - size.Width / 2,
                                                                    backRects[i].Y + backRects[i].Height / 2 - size.Height / 2 + 2);
                }
            }
            #endregion

            #region Draw machine texts
            for (int i = 0; i < mac; i++)
            {
                using (Font font = new Font("Arial", 10))
                {
                    string text = "M" +  Data.Machines[i].maquina.Tipo;
                    Size size = TextRenderer.MeasureText(text, font);
                    PointF tp = new PointF(backRects[i].X - size.Width, backRects[i].Y);
                    grp.DrawString(text, font, Brushes.Gray, tp);

                }
            }
            #endregion

            #region Draw process bars and texts
            for (int i = 0; i < job; i++)
            {
                for (int b = 0; b < proc; b++)
                {
                    int tempJob = i;
                    int tempProc = b;
                    int o = i * p + b;
                    int tempMac = macSchedule[o];

                    float x = startTimes[i, b] + horSpace;
                    float y = backRects[tempMac].Y;
                    float height = 15;
                    float time = Data.DataTable[i, b, tempMac];
                    if (time == int.MaxValue)
                        continue;
                    PointF ps1 = new PointF(x, y + 15);
                    PointF ps2 = new PointF(x, ps1.Y - height);
                    PointF ps3 = new PointF(ps2.X + time, ps2.Y);
                    PointF ps4 = new PointF(ps3.X, ps3.Y + height);

                    GraphicsPath path = new GraphicsPath();
                    path.AddLine(ps1, ps2);
                    path.AddLine(ps2, ps3);
                    path.AddLine(ps3, ps4);
                    path.CloseAllFigures();

                    RectangleF bar = new RectangleF(x, y, ps3.X - ps1.X, height);
                    using (SolidBrush brush = new SolidBrush(Colors.JobColors[i]))
                    {
                        grp.DrawPath(Pens.Black, path);
                        grp.FillPath(brush, path);
                    }
                    using (Font font = new Font("Arial", 7.5f))
                    {
                        string text = (i + 1) + "-" + (b + 1);
                        SizeF size = TextRenderer.MeasureText(text, font);
                        if (size.Width > bar.Width)
                        {
                            text = (b + 1).ToString();
                            size = TextRenderer.MeasureText(text, font);
                        }
                        PointF tp = new PointF(bar.X + bar.Width / 2 - size.Width / 2 + 3, bar.Y + height / 2 - size.Height / 2 + 1);
                        grp.DrawString(text, font, Brushes.Black, tp);
                    }

                }
            }
            #endregion
        }

        internal List<ScheduledTask> GetEvents()
        {
            List<ScheduledTask> task = new List<ScheduledTask>();
            for (int i = 0; i < j; i++)
            {
                for (int k = 0; k < p; k++)
                {
                    var t = new ScheduledTask(startTimes[i, k], finishTimes[i, k]);
                    t.JobId = i;
                    t.ProcessId = k;

                    task.Add(t);

                }
            }
            return task;
        }

        #endregion

        #region Repair
        Random rnd = new Random();
        public void Repair()
        {
            int num = p;
            int[] used = new int[j];
            List<int> pos = new List<int>();
            List<int> jobs = new List<int>();
            for (int i = 0; i < p * j; i++)
            {
                used[jobSchedule[i]]++;
                if (used[jobSchedule[i]] > num)
                    pos.Add(i);
            }
            for (int i = 0; i < used.Length; i++)
            {
                if (used[i] < num)
                {
                    for (int t = 0; t < num - used[i]; t++)
                    {
                        jobs.Add(i);
                    }
                }
            }
            for (int i = 0; i < pos.Count; i++)
            {
                int t = rnd.Next(0, jobs.Count);
                jobSchedule[pos[i]] = jobs[t];
                jobs.RemoveAt(t);
            }
        }
        #endregion

        #region Properties
        public float FitValue
        {
            get
            {
                return MakeSpan();
            }
        }
        public int[] MacSchedule
        {
            get { return macSchedule; }
            set { macSchedule = value; }
        }
        public int[] JobSchedule
        {
            get { return jobSchedule; }
            set { jobSchedule = value; }
        }
        public float TotalIdleTime
        {
            get
            {
                MakeSpan();
                if (idleCalculated)
                    return totalIdleTime;
                float total = 0;
                for (int i = 0; i < m; i++)
                {
                    total += idleTimes[i];
                }
                totalIdleTime = total;
                idleCalculated = true;
                return totalIdleTime;
            }
        }

        public int FilmeSwitch { get; private set; }
        public int PapelSwitch { get; private set; }
        #endregion

        #region ToString

        public string JobsToString()
        {
            string text = "";
            for (int i = 0; i < j * p; i++)
            {
                text += (jobSchedule[i] + 1) + "";
            }
            return text;
        }
        public string MacToString()
        {
            string text = "";
            for (int i = 0; i < j * p; i++)
            {
                text += (macSchedule[i] + 1) + "";
            }
            return text;
        }
        #endregion
    }
}
