﻿using System;
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
using Menu = MEDIRM.Menu;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MEDIRM.Modelos;

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
        private MEDIRM.Modelos.MEDIRMContext context;
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
             maquina = context.Maquinas.FirstOrDefault(x => x.Nome == Nome);
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
            this.context = new MEDIRM.Modelos.MEDIRMContext();

            ResourcesNeeded = new List<GeneticResource>();
            var todasEncomendas = context.Encomendas.Where(x => x.Estado.ToLower() != "terminado");
            var Moldes = context.Maquinas.Select(x => x.Molde).ToArray();
            List<GeneticResource> resources = new List<GeneticResource>();
            foreach (var encomenda in todasEncomendas)
            {
                var todosArtigosdAsEncomendas = new List<Artigo>();
                todosArtigosdAsEncomendas.AddRange(context.Artigoes.Where(x => x.Nome == encomenda.Artigo));
                foreach (var compoartigos in todosArtigosdAsEncomendas)
                {
                    var todosComponents = new List<ComponentesDosArtigo>();

                    todosComponents.AddRange(context.ComponentesDosArtigo.Where(x => x.Artigo == encomenda.Artigo));

                    foreach (var components in todosComponents)
                    {
                        int qt = int.Parse(components.Quantidade);
                        Maquina maquina1C, maquina2C, maquina3C, maquina4C, maquina5C = null;
                        var task = new GeneticTask(encomenda, components);
                        var maquina1 = ResourceFromMaquina(compoartigos.Maquina1, out maquina1C);
                        var maquina2 = ResourceFromMaquina(compoartigos.Maquina2, out maquina2C);
                        var maquina3 = ResourceFromMaquina(compoartigos.Maquina3, out maquina3C);
                        var maquina4 = ResourceFromMaquina(compoartigos.Maquina4, out maquina4C);
                        var maquina5 = ResourceFromMaquina(compoartigos.Maquina5, out maquina5C);
                        int currentProcessCount = 0;
                        var artigo = context.Artigoes.FirstOrDefault(x => x.ID.ToString() == components.Artigo.ToString());
                        if (maquina1 != null)
                        {
                           currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(encomenda,components,maquina1, maquina1C , qt));
                        }
                        else
                        {
                            task.Processes.Add(GeneticTask.GeneticProcess.Empty);

                        }
                        if (maquina2 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(encomenda, components, maquina2, maquina2C,qt));
                        }
                        else
                        {
                            task.Processes.Add(GeneticTask.GeneticProcess.Empty);

                        }
                        if (maquina3 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(encomenda, components, maquina3, maquina3C, qt));
                        }
                        else
                        {
                            task.Processes.Add(GeneticTask.GeneticProcess.Empty);

                        }
                        if (maquina4 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(encomenda, components, maquina4, maquina4C, qt));
                        }
                        else
                        {
                            task.Processes.Add(GeneticTask.GeneticProcess.Empty);

                        }
                        if (maquina5 != null)
                        {
                            currentProcessCount++;
                            task.Processes.Add(new GeneticTask.GeneticProcess(encomenda, components, maquina5, maquina5C, qt));
                        }
                        else
                        {
                            task.Processes.Add(GeneticTask.GeneticProcess.Empty);

                        }

                        if (currentProcessCount > MaxProcessCount)
                            MaxProcessCount = currentProcessCount;
                        //
                        Tasks.Add(task);
                    }

                }

            }
            this.context = new MEDIRM.Modelos.MEDIRMContext();

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
                public readonly ComponentesDosArtigo components;

                public GeneticProcess(Encomenda encomenda, ComponentesDosArtigo components, GeneticResource maquina1,Maquina mac, int quantidade)
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
                        if (int.TryParse(this.Machine.Velocidade1, out velocidade))
                        {
                            var v = ((float)(quantidade * encomenda.Quantidade) / velocidade);
                            return v;
                        }
                        return quantidade;
                    }
                }
                //public Genetic
            }

            public List<GeneticProcess> Processes = new List<GeneticProcess>();

          

            public readonly Encomenda Encomenda;

            public readonly ComponentesDosArtigo components;

            public GeneticTask(Encomenda encomenda, ComponentesDosArtigo components)
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
            { return ResourcesNeeded.Count; }
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

                        if (process == GeneticTask.GeneticProcess.Empty)
                        {
                            vals[k, j, i] = 0;
                        }
                        else if (process.Machine.Tipo == ResourcesNeeded[i].maquina.Tipo)
                        {
                            vals[k, j, i] = process.Duration;
                        }
                        else {
                            vals[k, j, i] = process.Duration + 500000;
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

                        if (process == GeneticTask.GeneticProcess.Empty)
                        {
                           // vals[k, j, i] = 0;
                        }
                        else if (process.Machine.Tipo == ResourcesNeeded[i].maquina.Tipo)
                        {
                           // vals[k, j, i] = process.Duration;
                        }
                        else
                        {
                           // vals[k, j, i] = 50000000;
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
        private List<TurnosFuncionario> turnos;

        void btnStart_Click(object sender, EventArgs e)
        {

            if (MaxProcesses < 1 || MaxMachines < 1 || MaxJob < 1)
            {
                MessageBox.Show("Erro ao PLanificar : Não existem Processoes, Maquinas ou Trabalhos para efectuar");
                return;
            }
            /*try
            {*/
            Data.DataTable = getDatas();
                Data.Tasks = Tasks;
            Data.Machines = ResourcesNeeded;
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
            List<TurnoWork> turnos = new List<TurnoWork>();
            Dictionary<int, double> MaquinaTempo = new Dictionary<int, double>();
            Dictionary<int, double> AccumulatedTimeMaquina = new Dictionary<int, double>();

            // loop machines
            for (int m = 0; m < MaxMachines;m++)
            {
                MaquinaTempo.Add(m, events.Where(x => x.MachineId == m).Sum(x => x.HourDuration));
                AccumulatedTimeMaquina.Add(m,0);
            }

            var totalTime = events.Sum(x => x.HourDuration);
            // there is work to be done
            // HORAS -> Turnos
            // Turno(mquina, TurnosExistents, duraçao) -> devolve lista de turnos para esta produçao
           events.Sort((x, y) =>
            {
                if ( x.start < y.start)
                {
                    return -1;
                }
                if (x.start > y.start)
                    return 1;
                if ( x.start == y.start)
                {
                    if (x.HourDuration > y.HourDuration)
                        return 1;
                    else
                        return -1;
                }
                return 0;
            });

            List<TurnoWork> currentTurnos = new List<TurnoWork>();
              foreach(var task in events)
            {
                task.GeneticTask = Tasks[task.JobId];
                task.GeneticProcess = task.GeneticTask.Processes[task.ProcessId];
                var schedule = getTurnos(task, currentTurnos);
                currentTurnos.AddRange(schedule);
            }
            
            var eventosValidos = events.Where(x => x.end.Subtract(x.start).TotalMinutes > 5).ToList();

            /// criar lista com eventos ordenados para distribuir
            // Lista com os dados
            var tasks = eventosValidos.Select(x => new TaskVisualizer(x, events, Tasks)).ToList();
            //Lista com numero de horas
            TabelaHorario t = new TabelaHorario(currentTurnos.Select( x=> new TurnoVisualizer(x, events, Tasks)).ToList());
            t.Show();
        }

        private List<TurnoWork> getTurnos(ScheduledTask task, List<TurnoWork> currentTurnos)
        {
            var machine = task.MachineId;
            var duration = task.HourDuration;
            List<TurnoWork> turnos = new List<TurnoWork>();
            DateTime startTime = task.start;
            while (duration > 0)
            {
                var realTurns = currentTurnos.Concat(turnos).ToList();
                TurnoWork avaibleFuncionarios = GetShift(startTime, task, realTurns);
                while (avaibleFuncionarios == null)
                {
                    startTime = startTime.AddMinutes(60);
                    avaibleFuncionarios = GetShift(startTime, task, realTurns);
                }
                duration -= avaibleFuncionarios.end.Subtract(avaibleFuncionarios.start).TotalHours;
                turnos.Add(avaibleFuncionarios);
            }
            return turnos;
        }

        class TurnoFuncionario
        {
            public DateTime Start;
            public DateTime End;
            public Funcionario Funcionario;
        }


        private List<TurnoFuncionario> ConvertTurnos(TurnosFuncionario f, DateTime t)
        {
            // esta merda sem chaves estrangeiras-...  eu bem avisei.
            List<TurnoFuncionario> turnos = new List<TurnoFuncionario>();
            var funcionar = context.Funcionarios.FirstOrDefault(x => x.Nome == f.Funcionario);
            if (funcionar == null)
                return new List<TurnoFuncionario>();
               // throw new Exception("Informaçao nas tabelas esta errada. É o que dá nao ter chaves estrangeiras. Nao existe : " + f.Funcionario + " na tabela Funcionarios.");

            // TURNO 1
            var turno = new TurnoFuncionario();
            turno.Funcionario = funcionar;
            var data = f.Turno1.Replace("h","").Split('-');
            if (data.Length == 2)
            {
                turno.Start = new DateTime(t.Year, t.Month, t.Day, int.Parse(data[0]), 0, 0);
                turno.End = new DateTime(t.Year, t.Month, t.Day, int.Parse(data[1]), 0, 0);
                turnos.Add(turno);
            }

             turno = new TurnoFuncionario();
            turno.Funcionario = funcionar;
             data = f.Turno2.Replace("h", "").Split('-');
            if (data.Length == 2)
            {
                turno.Start = new DateTime(t.Year, t.Month, t.Day, int.Parse(data[0]), 0, 0);
                turno.End = new DateTime(t.Year, t.Month, t.Day, int.Parse(data[1]), 0, 0);
                turnos.Add(turno);
            }
            turno = new TurnoFuncionario();
            turno.Funcionario = funcionar;
            data = f.Turno3.Replace("h", "").Split('-');
            if (data.Length == 2)
            {
                turno.Start = new DateTime(t.Year, t.Month, t.Day, int.Parse(data[0]), 0, 0);
                turno.End = new DateTime(t.Year, t.Month, t.Day, int.Parse(data[1]), 0, 0);
                turnos.Add(turno);
            }
            turno = new TurnoFuncionario();
            turno.Funcionario = funcionar;
            data = f.Turno4.Replace("h", "").Split('-');
            if (data.Length == 2)
            {
                turno.Start = new DateTime(t.Year, t.Month, t.Day, int.Parse(data[0]), 0, 0);
                turno.End = new DateTime(t.Year, t.Month, t.Day, int.Parse(data[1]), 0, 0);
                turnos.Add(turno);
            }
            return turnos;
        }

        // devolve os funcionar que podem trabalhar a começar nestas horas e a duraçao do turno
        private TurnoWork GetShift(DateTime startTime, ScheduledTask task, List<TurnoWork> currentTurnos)
        {
            List<TurnoFuncionario> turnosDecentes = new List<TurnoFuncionario>();
            this.turnos  = this.turnos == null ? context.TurnosFuncionario.ToList() : this.turnos; 
            var dia = ToDiaDaSemana(startTime);
            var filtered = turnos.Where(x => x.DiaDaSemana.ToLower() == dia.ToLower());
            foreach (var tu in filtered)
            {

                turnosDecentes.AddRange(ConvertTurnos(tu,startTime));
            }
            if (turnosDecentes.Count == 0)
                return null;
            // validar se o turno e valido para se escolhido
            Func<TurnoFuncionario,bool> validarHoras = (TurnoFuncionario turno) =>
            {
                if (turno.Start.Hour <= startTime.Hour && turno.End.Hour >= startTime.Hour)
                    if (startTime.DayOfWeek == turno.Start.DayOfWeek)
                        return true;
                return false;
            };

            Func<TurnoFuncionario, bool> validarOverlap = (TurnoFuncionario turno) =>
            {
                var ActualStart = new DateTime(startTime.Year, startTime.Month,startTime.Day, turno.Start.Hour, turno.Start.Minute, turno.Start.Second);
                var ActualEnd = new DateTime(startTime.Year, startTime.Month, startTime.Day, turno.End.Hour, turno.End.Minute, turno.End.Second); ;

                if (currentTurnos.Any( x=> x.frente.Any(func => func.Nome == turno.Funcionario.Nome) || x.tras.Any(func => func.Nome == turno.Funcionario.Nome) && x.start >= ActualStart &&  x.end <= ActualEnd) || currentTurnos.Any(x => x.start >= ActualStart && x.end <= ActualEnd && x.Task == task))
                {
                    return false;
                }
                return true;
            };
            List<TurnoFuncionario> frentes = new List<TurnoFuncionario>();
            List<TurnoFuncionario> trass = new List<TurnoFuncionario>();
            var requiredF = task.GeneticProcess.Machine.MaxPessFrente;
            var requiredT = task.GeneticProcess.Machine.MaxPessTras;
            while (frentes.Count != requiredF)
            {
                var frente = turnosDecentes.FirstOrDefault(x => x.Funcionario.Frente.HasValue && x.Funcionario.Frente.Value && validarHoras(x) && validarOverlap(x));
                if (frente == null)
                    return null;
                frentes.Add(frente);
            }
            while (trass.Count != requiredT)
            {
                var tras = turnosDecentes.FirstOrDefault(x => x.Funcionario.Tras.HasValue && x.Funcionario.Tras.Value &&  frentes.All( frt => x.Funcionario.Nome != frt.Funcionario.Nome) && validarHoras(x) && validarOverlap(x));
                if ( tras == null)
                    return null;
                trass.Add(tras);
            }
            var tWork = new TurnoWork();
            var start = new DateTime(startTime.Year, startTime.Month, startTime.Day, frentes[0].Start.Hour, frentes[0].Start.Minute, frentes[0].Start.Second);
            var end = new DateTime(startTime.Year, startTime.Month, startTime.Day, frentes[0].End.Hour, frentes[0].End.Minute, frentes[0].End.Second); 

            tWork.frente = frentes.Select(x=>x.Funcionario).ToList();
            tWork.tras = trass.Select(x => x.Funcionario).ToList();
            tWork.start = start;
            tWork.end = end;
            tWork.Task = task;
            return tWork;
        }

        private string ToDiaDaSemana(DateTime startTime)
        {
            switch(startTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return "Segunda-feira";
                case DayOfWeek.Tuesday:
                    return "Terça-feira";
                case DayOfWeek.Wednesday:
                    return "Quarta-feira";
                case DayOfWeek.Thursday:
                    return "Quinta-feira";
                case DayOfWeek.Friday:
                    return "Sexta-feira";
                default:
                    return "";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new Menu());
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
