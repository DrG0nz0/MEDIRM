using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using MEDIRM;

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
            CreateProject();

            InitializeComponent();


            btnPrepare.Click += btnPrepare_Click;
            btnHideBoxes.Click += btnHideBoxes_Click;
            btnStart.Click += btnStart_Click;
            btnStop.Click += btnStop_Click;
            btnHideRes.Click += btnHideRes_Click;
            panel1.Paint += panel1_Paint;
            btnClearBoxes.Click += btnClearBoxes_Click;
            btnRandom.Click += btnRandom_Click;
            this.SizeChanged += MainForm_SizeChanged;
            btnStop.Enabled = false;
            resPanel.VisibleChanged += resPanel_VisibleChanged;
            rnd = new Random();
            SetDoubleBuffered(resPanel);
            SetDoubleBuffered(panel1);
            cbCOTypes.SelectedIndex = 2;
            cbSelTypes.SelectedIndex = 0;
            cbMutTypes.SelectedIndex = 0;
            resPanel.AutoScroll = true;
            resPanel.MouseEnter += resPanel_MouseEnter;
            resPanel.Height = this.Height - btnHideRes.Top - 40;
            this.Load += MainForm_Load;
        }



        private GeneticResource ResourceFromMaquina(string Nome)
        {
            var context = new MedirmDBEntities();
            var maquina = context.Maquina.FirstOrDefault(x => x.Nome == Nome);
            if (maquina == null)
                return null;
            var maq = ResourcesNeeded.FirstOrDefault(x => x.maquina.Tipo == maquina.Tipo);
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

                    todosComponents.AddRange(context.ComponentesDosArtigos.Where(x => x.Artigo == "1"));
                    foreach (var components in todosComponents)
                    {
                        var task = new GeneticTask();
                        var maquina1 = ResourceFromMaquina(components.Maquina1);
                        var maquina2 = ResourceFromMaquina(components.Maquina2);
                        var maquina3 = ResourceFromMaquina(components.Maquina3);
                        var maquina4 = ResourceFromMaquina(components.Maquina4);
                        var maquina5 = ResourceFromMaquina(components.Maquina5);
                        int currentProcessCount = 0;
                        var artigo = context.Artigo.FirstOrDefault(x => x.ID.ToString() == components.Artigo.ToString());
                        int qt = int.Parse(components.Quantidade);
                        if (maquina1 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(maquina1, qt));
                        }
                        if (maquina2 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(maquina1,qt));
                        }
                        if (maquina3 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(maquina1, qt));
                        }
                        if (maquina4 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(maquina1, qt));
                        }
                        if (maquina5 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(maquina1, qt));
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
                public readonly GeneticResource Machine;

                public static GeneticProcess Empty = new GeneticProcess(null, 0);
                private int quantidade;

                public GeneticProcess(GeneticResource maquina1, int quantidade)
                {
                    this.Machine = maquina1;
                    this.quantidade = quantidade;
                }

               public float Duration
                {
                    get
                    {
                        return quantidade;
                    }
                }
                //public Genetic
            }

            public List<GeneticProcess> Processes = new List<GeneticProcess>();

            public double Duration
            {
                get
                {
                    return 250;
                }
            }

            public GeneticTask()
            {

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
                        if (process.Machine == ResourcesNeeded[i])
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
                        if (process.Machine == ResourcesNeeded[i])
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
                        getBoxControl(boxPanel, k + 1, j + 1, i + 1).Text =  time == 50000 ? "X" : time.ToString();
                    }
                }
            }
        }

        void MainForm_Load(object sender, EventArgs e)
        {

            btnPrepare.PerformClick();
                   SetData();

        }




        void chkFuzzy_CheckedChanged(object sender, EventArgs e)
        {
            btnPrepare.PerformClick();
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
                resPanel.Height = this.Height - btnHideRes.Top - 60;
            }
        }
        #endregion

        #region --------Visibility--------

        void resPanel_VisibleChanged(object sender, EventArgs e)
        {
            btnHideRes.Text = resPanel.Visible ? "<<" : ">>";
        }
        void boxPanel_VisibleChanged(object sender, EventArgs e)
        {
            btnHideBoxes.Text = boxPanel.Visible ? "<<" : ">>";
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
        void btnRandom_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < MaxMachines + 1; i++)
            {
                for (int j = 1; j < MaxProcesses + 1; j++)
                {
                    for (int k = 1; k < MaxJob + 1; k++)
                    {
                        string name = "j" + k + "p" + j + "m" + i;
                        int a = rnd.Next(0, 151);
                        boxPanel.Controls["j" + k].Controls["boxer"].Controls[name].Text = (a < 20 ? "X" : a.ToString());
                    }
                }
            }
        }
        void btnClearBoxes_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < MaxMachines + 1; i++)
            {
                for (int j = 1; j < MaxProcesses + 1; j++)
                {
                    for (int k = 1; k < MaxJob + 1; k++)
                    {
                        string name = "j" + k + "p" + j + "m" + i;
                        boxPanel.Controls["j" + k].Controls["boxer"].Controls[name].Text = "";
                    }
                }
            }
        }
        void btnHideRes_Click(object sender, EventArgs e)
        {
            resPanel.Visible = !resPanel.Visible && best;
        }

        void btnStop_Click(object sender, EventArgs e)
        {
            genetik.Stop();
            btnStop.Enabled = false;
        }
        Stopwatch stp = new Stopwatch();
        void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Data.DataTable = getDatas();
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
                resPanel.Width = boxPanel.Width;
                resPanel.Height = this.Height - btnHideRes.Top - 60;
                boxPanel.Visible = false;
                stp.Reset();
                stp.Start();
                genetik.Start();
                btnStop.Enabled = true;
                btnHideRes.Text = "<<";
            }
            catch
            {
                MessageBox.Show("Data table is wrong");
            }
        }
        void btnHideBoxes_Click(object sender, EventArgs e)
        {
            if (boxPanel != null)
                boxPanel.Visible = !boxPanel.Visible;
        }

        void btnPrepare_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            this.Controls.Remove(boxPanel);
            if (boxPanel != null)
                boxPanel.Dispose();

            //MaxMachines = nmudmac.Value.ToInt();
            //MaxProcesses = nmudproc.Value.ToInt();
            //MaxJob = nmudjob.Value.ToInt();

            boxPanel = provider.CreateJobBoxes(MaxMachines, MaxProcesses, MaxJob);
            Application.DoEvents();
            boxPanel.Left = btnHideBoxes.Right + 10;
            boxPanel.Top = btnHideBoxes.Top;
            boxPanel.Width = this.Width - boxPanel.Left - 40;
            boxPanel.AutoScroll = false;
            boxPanel.VerticalScroll.Enabled = false;
            boxPanel.VerticalScroll.Visible = false;
            boxPanel.VerticalScroll.Maximum = 0;
            boxPanel.AutoScroll = true;

            boxPanel.VisibleChanged += boxPanel_VisibleChanged;
            this.Controls.Add(boxPanel);
            SetDoubleBuffered(boxPanel);
            resPanel.Visible = false;
            Cursor = Cursors.Arrow;
        }
        #endregion

        #region --------Genetic Events--------

        void genetik_ProgressChanged(object sender, EventArgs e)
        {
            if (genetik != null)
                lblProgress.Text = "%" + genetik.Progress.ToString("0.00");
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

        string exportableDataText()
        {
            float[,,] data = getDatas();
            int tj = data.GetLength(0);
            int tp = data.GetLength(1);
            int tm = data.GetLength(2);

            string text = "";
            for (int j = 0; j < tp; j++)
            {
                for (int k = 0; k < tm; k++)
                {
                    text += space(8) + (j + 1) + "." + (k + 1);
                }
            }
            text += Environment.NewLine;
            for (int i = 0; i < tj; i++)
            {
                text += (i + 1).ToString() + space(8);
                for (int j = 0; j < tp; j++)
                {
                    for (int k = 0; k < tm; k++)
                    {
                        string me = data[i, j, k].ToString();
                        text += data[i, j, k] + space(8 - (me.Length - 3));
                    }
                }
                text += i == tj - 1 ? ";" : Environment.NewLine;
            }
            return text;
        }

        void ExportMathModel()
        {

            #region mathematical model

            string model =
"sets" + Environment.NewLine +
"i jobs           /1*" + MaxJob + "/" + Environment.NewLine +
"j processes      /1*" + MaxProcesses + "/" + Environment.NewLine +
"k machines       /1*" + MaxMachines + "/" + Environment.NewLine +
"o orders         /1*" + MaxJob * MaxProcesses + "/" + Environment.NewLine + Environment.NewLine +

"**kumelerin kopyasini al\r\n" +
"alias(i,ii);" + Environment.NewLine +
"alias(j,jj);" + Environment.NewLine +
"alias(k,kk);" + Environment.NewLine +
"alias(o,oo);\r\n" + Environment.NewLine +

"table t(i,j,k) veri tablosu\r\n" + Environment.NewLine +
exportableDataText() + Environment.NewLine + "\r\n" +
"parameter L buyuk sayi /100000/\r\n" + Environment.NewLine +

"binary variables" + Environment.NewLine +
"x(i,j,k) is-process ikilisinin makineye atanma durumu" + Environment.NewLine +
"a(i,j,o) is-process ikilisinin is siralamasindaki konumunu belirten ikili degisken;\r\n" + Environment.NewLine +

"positive variables" + Environment.NewLine +
"s(i,j,k) is-proses ikilisinin k makinesinde calisma zamani: x(i.j.k) = 0 ise s(i.j.k) = 0)" + Environment.NewLine +
"c(i,j,k) is-proses ikilisinin k makinesinde bitis zamani: x(i.j.k) = 0 ise c(i.j.k) = 0;\r\n" + Environment.NewLine +
"variables" + Environment.NewLine +
"z amac fonksiyonu;\r\n" + Environment.NewLine +

"equations" + Environment.NewLine +

"eq1 her is-proses ikilisi bir makineye atanmali" + Environment.NewLine +
"eq2 her is-proses ikilisi bir makineye atanmali " + Environment.NewLine +
"eq3 her sira numarasi sadece bir is-proses ikilisine ait olmali" + Environment.NewLine +
"eq4 proses bitis zamani = baslangic zamani + calisma zamani" + Environment.NewLine +
"eq5 is-proses k makinesinde calismiyorsa s(i.j.k) = c(i.j.k) = 0" + Environment.NewLine +
"eq6 i-j ve ii-jj ayni makinede calisiyorsa ve i-j nin sira numarasi daha buyukse s(i.j.k) >= c(ii.jj.k)" + Environment.NewLine +
"eq7 i-j nin bir onceki prosesinin sira numarasi i-j ninkinden buyuk olamaz" + Environment.NewLine +
"eq8 i-j nin baslama zamani bir onceki prosesinin bitisinden buyuktur" + Environment.NewLine +
"eq9 makespan: tum i-j lerin bitis zamanindan buyuk yada esittir;\r\n" + Environment.NewLine +


"eq1(i,j)..                                       sum(k, x(i,j,k)) =e= 1;" + Environment.NewLine +

"eq2(i,j)..                                       sum(o, a(i,j,o)) =e= 1;" + Environment.NewLine +

"eq3(o)..                                         sum((i,j), a(i,j,o)) =e= 1;" + Environment.NewLine +

"eq4(i,j,k)..                                     c(i,j,k) =g= s(i,j,k) + t(i,j,k) - (1 - x(i,j,k)) * L;" + Environment.NewLine +

"eq5(i,j,k)..                                     s(i,j,k) + c(i,j,k) =l= L * x(i,j,k);" + Environment.NewLine +

"eq6(i,j,o,k,ii,jj,oo)$(ord(oo) lt ord(o))..      s(i,j,k) + L * (4 - a(i,j,o) - a(ii,jj,oo) - x(i,j,k) - x(ii,jj,k)) =g= c(ii,jj,k);" + Environment.NewLine +

"eq7(i,j,o)$(ord(j) gt 1)..                       sum(oo$(ord(oo) ge ord(o)), a(i,j-1,oo)) =l= 1 - a(i,j,o);" + Environment.NewLine +

"eq8(i,j)$(ord(j) gt 1)..                         sum(k, s(i,j,k)) =g= sum(k, c(i,j-1,k));" + Environment.NewLine +

"eq9(i,j)$(ord(j) eq card(j))..                   z =g= sum(k, c(i,j,k));\r\n" + Environment.NewLine +

"model ciz /all/;" + Environment.NewLine +
"option optcr = 0;" + Environment.NewLine +
"solve ciz using mip min z;" + Environment.NewLine +
"display x.l, z.l,a.l,c.l,s.l;";
            #endregion

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\scheduling_model.gms";
            TextWriter writer = new StreamWriter(path);
            writer.WriteLine(model);
            writer.Close();
            Process.Start(path);
            MessageBox.Show("Model file has been saved on desktop: scheduling_model.gms");
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


        void CreateBoxes(int j, int p, int m)
        {
            this.Controls.Remove(boxPanel);
            if (boxPanel != null)
                boxPanel.Dispose();

            boxPanel = provider.CreateJobBoxes(m, p, j);
            boxPanel.Left = btnHideBoxes.Right + 10;
            boxPanel.Top = btnHideBoxes.Top;
            boxPanel.Width = this.Width - boxPanel.Left - 40;
            boxPanel.AutoScroll = false;
            boxPanel.VerticalScroll.Enabled = false;
            boxPanel.VerticalScroll.Visible = false;
            boxPanel.VerticalScroll.Maximum = 0;
            boxPanel.AutoScroll = true;

            boxPanel.VisibleChanged += boxPanel_VisibleChanged;
            this.Controls.Add(boxPanel);
            SetDoubleBuffered(boxPanel);
            resPanel.Visible = false;
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
