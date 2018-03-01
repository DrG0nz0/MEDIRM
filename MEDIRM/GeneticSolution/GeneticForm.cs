using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using MEDIRM;
using MEDIRM.GeneticSolution;
using ProjectScheduling.SolverFoundation;
using System.ComponentModel;
using MEDIRM.GeneticSolution.Helpers;

namespace Scheduling
{
    public partial class GeneticForm : Form
    {

        #region --------Variables--------

        InputBoxProvider provider = new InputBoxProvider();
        Panel boxPanel;
        Random rnd;
        bool best;
        GeneticMachine genetik;
        #endregion

        #region --------Related to Form--------
        public static List<GeneticResource> ResourcesNeeded = new List<GeneticResource>();
        public static List<GeneticTask> Tasks = new List<GeneticTask>();
        public static int MaxProcessCount = 0;
        public GeneticForm()
        {
;
            CreateProject();

            InitializeComponent();

            this.calendar1.ViewStart = DateTime.Now;
            this.calendar1.ViewEnd = DateTime.Now.AddMonths(1);
            this.calendar1.MaximumViewDays = 7*30;
            btnStart.Click += btnStart_Click;
            btnStop.Click += btnStop_Click;
            panel1.Paint += panel1_Paint;
            this.SizeChanged += MainForm_SizeChanged;
            btnStop.Enabled = false;
            rnd = new Random();

            SetDoubleBuffered(panel1);
            cbCOTypes.SelectedIndex = 2;
            cbSelTypes.SelectedIndex = 0;
            cbMutTypes.SelectedIndex = 0;
            resPanel.AutoScroll = true;
            resPanel.MouseEnter += resPanel_MouseEnter;
            this.Load += MainForm_Load;
        }
        #region Genitk
        private GeneticResource ResourceFromMaquina(string Nome, out Maquina maquina)
        {
            var context = new MedirmDBEntities();
             maquina = context.Maquina.FirstOrDefault(x => x.Nome == Nome);
            var mac = maquina;
            if (maquina == null)
                return null;
            var maq = ResourcesNeeded.FirstOrDefault(x => x.maquina.Tipo == mac.Tipo);
            if ( maq == null)
            {
                var res = new GeneticResource(maquina);
                ResourcesNeeded.Add(res);
                return res;
            }
            return maq;
        }

        public void CreateProject()
        {
            ResourcesNeeded = new List<GeneticResource>();
            var context = new MedirmDBEntities();
            var todasEncomendas = context.Encomenda.Where(x => x.Estado.ToLower() != "terminado");
            var Moldes = context.Maquina.Select(x => x.Molde).ToArray();
            List<GeneticResource> resources = new List<GeneticResource>();
            foreach (var encomenda in todasEncomendas)
            {
                var todosArtigosdAsEncomendas = new List<Artigo>();
                todosArtigosdAsEncomendas.AddRange(context.Artigo.Where(x => x.Nome == encomenda.Artigo));
                foreach (var compoartigos in todosArtigosdAsEncomendas)
                {
                    var todosComponents = new List<ComponentesDosArtigos>();

                    todosComponents.AddRange(context.ComponentesDosArtigos.Where(x => x.Artigo == encomenda.Artigo));
                    foreach (var components in todosComponents)
                    {
                        int qt = int.Parse(components.Quantidade);
                        Maquina maquina1C, maquina2C, maquina3C, maquina4C, maquina5C = null;
                        var task = new GeneticTask(encomenda, components);
                        var maquina1 = ResourceFromMaquina(components.Maquina1, out maquina1C);
                        var maquina2 = ResourceFromMaquina(components.Maquina2, out maquina2C);
                        var maquina3 = ResourceFromMaquina(components.Maquina3, out maquina3C);
                        var maquina4 = ResourceFromMaquina(components.Maquina4, out maquina4C);
                        var maquina5 = ResourceFromMaquina(components.Maquina5, out maquina5C);
                        int currentProcessCount = 0;
                        var artigo = context.Artigo.FirstOrDefault(x => x.ID.ToString() == components.Artigo.ToString());
                        if (maquina1 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(encomenda,components,maquina1, maquina1C , qt));
                        }
                        if (maquina2 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(encomenda, components, maquina2, maquina2C,qt));
                        }
                        if (maquina3 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(encomenda, components, maquina3, maquina3C, qt));
                        }
                        if (maquina4 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(encomenda, components, maquina4, maquina4C, qt));
                        }
                        if (maquina5 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(encomenda, components, maquina5, maquina5C, qt));
                        }
                      
                        if (currentProcessCount > MaxProcessCount)
                            MaxProcessCount = currentProcessCount;
                        //
                        Tasks.Add(task);
                    }

                }

            }
        }

        public class GeneticResource
        {
            public readonly String Name;
            public readonly Maquina maquina;

           

            public GeneticResource(Maquina maquina3)
            {
                this.maquina = maquina3;
            }
        }

        public class GeneticTask
        {
            public class GeneticProcess
            {
                public readonly GeneticResource Machines;
                public readonly Maquina Machine;
                public static GeneticProcess Empty = new GeneticProcess(null,null,null, null, 0);
                private int quantidade;
                public readonly Encomenda encomenda;
                public readonly ComponentesDosArtigos components;

                public GeneticProcess(Encomenda encomenda, ComponentesDosArtigos components, GeneticResource maquina1,Maquina mac, int quantidade)
                {
                    this.Machine = mac;
                    this.quantidade = quantidade;
                    this.encomenda = encomenda;
                    this.components = components;
                }

               public float Duration
                {
                    get
                    {
                        int velocidade = 0;
                        if ( int.TryParse(this.Machine.Velocidade1, out velocidade))                   
                            return (int)((quantidade / velocidade));
                        return quantidade;
                    }
                }
                //public Genetic
            }

            public List<GeneticProcess> Processes = new List<GeneticProcess>();

          

            public readonly Encomenda Encomenda;

            public readonly ComponentesDosArtigos components;

            public GeneticTask(Encomenda encomenda, ComponentesDosArtigos components)
            {
                this.Encomenda = encomenda;
                this.components = components;
            }

            internal GeneticProcess GetProcess(int j)
            {
                if (j >= Processes.Count)
                    return GeneticProcess.Empty;
                return Processes[j];
            }
        }

    
        GeneticTask GetTaskProcess(int MaxJob)
        {
            return Tasks[MaxJob];
        }

        int MaxProcesses
        {
             get { return MaxProcessCount; }
        }

        int MaxMachines
        {
            get
            { return MaxProcessCount; }
        }
        int MaxJob
        {
            get
            { return Tasks.Count; }
        }

        public bool RenderCalendar { get; private set; }

        float[,,] getDatas()
        {
            float[,,] vals = new float[MaxJob, MaxProcesses, MaxMachines];
            for (int k = 0; k < MaxJob; k++)
            {
                GeneticTask task = GetTaskProcess(k);
                for (int j = 0; j < MaxProcesses; j++)
                {
                    var process = task.GetProcess(j);

                    for (int i = 0; i < MaxMachines; i++)
                    {
                        if (process != GeneticTask.GeneticProcess.Empty && process.Machine.Tipo == ResourcesNeeded[i].maquina.Tipo)
                        {
                            vals[k, j, i] = process.Duration;
                        }
                        else
                        {
                            if (task.Processes.Count > j)
                            {
                                // temos processo para este nivel
                                vals[k, j, i] = 50000;
                            }
                            else
                            {
                                vals[k, j, i] = 0;
                            }
                        }
                    }
                }
            }
            return vals;
        }

        void SetData()
        {
            for (int k = 0; k < MaxJob; k++)
            {
                GeneticTask task = GetTaskProcess(k);
                for (int j = 0; j < MaxProcesses; j++)
                {
                    var process = task.GetProcess(j);

                    for (int i = 0; i < MaxMachines; i++)
                    {

                        float time = 0;
                        if (process != GeneticTask.GeneticProcess.Empty &&  process.Machine.Tipo == ResourcesNeeded[i].maquina.Tipo)
                        {
                            time = process.Duration;
                        }
                        else
                        {
                            if (task.Processes.Count > j)
                            {
                                // temos processo para este nivel
                                time = 50000;
                            }
                            else
                            {
                                time = 0;
                            }
                        }
                        //getBoxControl(boxPanel, k + 1, j + 1, i + 1).Text =  time == 50000 ? "X" : time.ToString();
                    }
                }
            }
        }

        private void CreateFromSchedule()
        {
            Schedule best = this?.genetik?.Best;
            if (best == null)
                return;
            this.calendar1.Items.Clear();
           var events =  best.GetEvents();
            var kui = new List<System.Windows.Forms.Calendar.CalendarItem>();
            bool showlongName = this.calendar1.ViewEnd.Subtract(this.calendar1.ViewStart).TotalDays < 5;
            foreach (var task in events)
            {

                foreach (var bk in task.Breaks.Where(x => x.Start >= this.calendar1.ViewStart && x.End <= this.calendar1.ViewEnd))
                {
                    var gTask = Tasks[task.JobId];
                    var shortName = "E" + gTask.Encomenda.NumeroEnco + "/" + gTask.Processes[task.ProcessId].Machine.Tipo;
                    var longName = "E" + gTask.Encomenda.NumeroEnco + "-" + gTask.Processes[task.ProcessId].Machine.Tipo + "-" + gTask.components.Artigo + "(" + gTask.components.Componente + ")";
                    var name = showlongName ? longName : shortName;
                    var ut = new System.Windows.Forms.Calendar.CalendarItem(this.calendar1, bk.Start, bk.End, name);
                    ut.BackgroundColor = Colors.JobColors[task.JobId]; ;
                    ut.Tag = task;
                    kui.Add(ut);
                }
            }
            this.calendar1.Items.AddRange(kui);
        }
        
        #endregion Genitk

        void MainForm_Load(object sender, EventArgs e)
        {
            Prepare();
                   SetData();

        }

        void chkFuzzy_CheckedChanged(object sender, EventArgs e)
        {
        }

        void resPanel_MouseEnter(object sender, EventArgs e)
        {
            resPanel.Focus();
        }

        void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (boxPanel != null)
            {
                boxPanel.Width = this.Width - boxPanel.Left - 40;
            }
            if (resPanel != null)
            {
                if (boxPanel != null)
                    resPanel.Width = boxPanel.Width;
            }
        }
        #endregion


        #region --------Paint--------

        void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (genetik != null && genetik.Best != null)
            {
                genetik.Best.DrawSchedule(e.Graphics, panel1);
            }
        }
        #endregion

        #region --------Click Events--------

        void btnStop_Click(object sender, EventArgs e)
        {
            genetik.Stop();
            btnStop.Enabled = false;
        }
        Stopwatch stp = new Stopwatch();
        void btnStart_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                Data.DataTable = getDatas();
                Data.Tasks = Tasks;
                Colors.GenerateRandomHSV(MaxJob);
                if (genetik != null && !genetik.Stopped)
                {
                    genetik.Stop();
                    Thread.Sleep(100);
                }

                int popSize = popnmud.Value.ToInt();
                genetik = new GeneticMachine(MaxJob, MaxProcesses, MaxMachines, popSize);

                genetik.MutOdd = mutnmud.Value.ToInt();
                genetik.GroupSize = groupnmud.Value.ToInt();
                genetik.MinTimeOdd = nmudMinTime.Value.ToInt();

                genetik.SelectionType = (SelectionTypes)cbSelTypes.SelectedIndex;
                genetik.CrossOver = (COTypes)cbCOTypes.SelectedIndex;
                genetik.MutationTypes = (MutationTypes)cbMutTypes.SelectedIndex;

                genetik.Refresh = chkRefresh.Checked;
                genetik.BestValueChanged += genetik_BestValueChanged;
                genetik.ProgressChanged += genetik_ProgressChanged;
                best = true;
                resPanel.Visible = true;
                stp.Reset();
                stp.Start();
                genetik.Start();
                btnStop.Enabled = true;
            /*}
            catch(Exception ea)
            {
                MessageBox.Show("Data table is wrong");
            }*/
        }
       

        void Prepare()
        {
            Cursor = Cursors.WaitCursor;
            this.Controls.Remove(boxPanel);
            if (boxPanel != null)
                boxPanel.Dispose();


           // boxPanel = provider.CreateJobBoxes(MaxMachines, MaxProcesses, MaxJob);
            Application.DoEvents();
            //boxPanel.AutoScroll = false;
            //boxPanel.VerticalScroll.Enabled = false;
            //boxPanel.VerticalScroll.Visible = false;
            //boxPanel.VerticalScroll.Maximum = 0;
            //boxPanel.AutoScroll = true;

            resPanel.Visible = true;
            Cursor = Cursors.Arrow;
        }
        #endregion

        #region --------Genetic Events--------

        void genetik_ProgressChanged(object sender, EventArgs e)
        {
            if (genetik != null)
            {
                lblProgress.Text = "%" + genetik.Progress.ToString("0.00");
                progressBarFooter.Value = (int)(genetik.Progress);
                progressBarFooter.Maximum = 100;
                
            }
        }
        //296
        void genetik_BestValueChanged(object sender, EventArgs e)
        {
            if (genetik.Best != null)
            {
                lblSpan.Text = genetik.Best.MakeSpan().ToString();
                lblBestTime.Text = stp.Elapsed.TotalSeconds.ToString("00") + "." + stp.Elapsed.Milliseconds.ToString("00") + " sn";
                lblIdleTime.Text = genetik.Best.TotalIdleTime.ToString();
                resPanel.Invalidate();
                RenderCalendar = true;
            }
        }

      
        #endregion

        #region --------Methods--------


        Control getBoxControl(Panel boxContainer, int MaxJob, int MaxProcesses, int MaxMachines)
        {
            string name = "j" + MaxJob + "p" + MaxProcesses + "m" + MaxMachines;
            return boxContainer.Controls["j" + MaxJob].Controls["boxer"].Controls[name];
        }

      
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            //Taxes: Remote Desktop Connection and painting
            //http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo aProp =
                  typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }

        static string space(int n)
        {
            string text = "";
            for (int i = 0; i < n; i++)
            {
                text += " ";
            }
            return text;
        }



        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            CreateFromSchedule();
        }

        private void calendar1_DayHeaderClick(object sender, System.Windows.Forms.Calendar.CalendarDayEventArgs e)
        {
            if (this.calendar1.ViewEnd.Subtract(this.calendar1.ViewStart).TotalDays <= 3)
            {
                this.calendar1.ViewStart = e.CalendarDay.Date.AddDays(-14);
                this.calendar1.ViewEnd = e.CalendarDay.Date.AddDays(15);
                this.CreateFromSchedule();

            }
            else
            {
                this.calendar1.ViewStart = e.CalendarDay.Date.AddDays(-1);
                this.calendar1.ViewEnd = e.CalendarDay.Date.AddDays(1);
                this.CreateFromSchedule();
            }
        }

        private void calendar1_LoadItems(object sender, System.Windows.Forms.Calendar.CalendarLoadEventArgs e)
        {
            this.CreateFromSchedule();
        }

        private void calendar1_ItemSelected(object sender, System.Windows.Forms.Calendar.CalendarItemEventArgs e)
        {
            ScheduledTask task = (ScheduledTask)e.Item.Tag;
            if (task == null)
                return;
            LoadTaskData(task);
        }

        private void LoadTaskData(ScheduledTask task)
        {
            Schedule best = genetik?.Best;
            if (best == null)
                return;

            this.propertyGrid1.SelectedObject =  new TaskVisualizer(task,best.GetEvents(), Tasks);
                
        }



        private void PDF_Click(object sender, EventArgs e)
        {
            Schedule best = genetik?.Best;
            if (best == null)
            {
                MessageBox.Show("Nao Existem Planificaçoes.");
                return;
            }
            var events = best.GetEvents();

            // Lista com os dados
            var tasks = events.Where(x => x.end.Subtract(x.start).TotalMinutes > 5).Select(x => new TaskVisualizer(x, events, Tasks));


            TabelaHorario t = new TabelaHorario(tasks.ToList());
            t.Show();
            

        }
    }
    public static class ExtMethods
    {
        public static int ToInt(this decimal val)
        {
            return Convert.ToInt32(val);
        }
        public static int ToInt(this string text)
        {
            return Int32.Parse(text);
        }
        public static string ConvertIfInteger(this float number)
        {
            if (number == (int)number)
                return ((int)number).ToString("0");
            else
                return number.ToString("0.00");
        }
    }
}
