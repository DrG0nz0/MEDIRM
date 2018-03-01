using ProjectScheduling.SolverFoundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Scheduling.GeneticForm;

namespace MEDIRM.GeneticSolution.Helpers
{
    public class TaskVisualizer
    {


        public TaskVisualizer(ScheduledTask task, List<ScheduledTask> list, List<GeneticTask> Tasks)
        {
            this.sTask = task;
            this.task = Tasks[task.JobId];
            this.process = this.task.Processes[task.ProcessId];
            this.component = this.task.components;
            this.estimatedDelivery = task.Breaks.Last().End;
            var last = list.Last(x => x.JobId == task.JobId && x.end.Subtract(x.start).TotalMinutes > 5);
            this.estimatedDeliveryEncomenda = last.Breaks.Last().End;

            var hours = task.HourDuration;
            int velocidade;
            ;
            this.unidadesPorTurno = int.TryParse(process.Machine.Velocidade1, out velocidade) ? (hours * velocidade).ToString() : "N/A";
        }

        [Category("Encomenda")]
        public int Encomenda => this.task.Encomenda.NumeroEnco;
        [Category("Encomenda")]
        public string Cliente => this.task.Encomenda.Cliente;
        [Category("Encomenda")]
        public string Unidades => this.task.components.Quantidade;
        [Category("Encomenda")]
        public string Estado => this.task.Encomenda.Estado;
        [Category("Encomenda")]
        public string Artigo => this.task.Encomenda.Artigo;
        [Category("Encomenda")]
        public int ProcessoId => this.sTask.ProcessId;
        [Category("Encomenda")]
        public DateTime EstimadaDaEncomenda => this.estimatedDeliveryEncomenda;
        [Category("Encomenda")]
        public DateTime? DataEntrega => this.task.Encomenda.DataLimite;

        [Category("Processo")]
        public int Processo => this.sTask.ProcessId;
        [Category("Processo")]
        public string TipoMaquina => this.process.Machine.Tipo;
        [Category("Processo")]
        public string Maquina => this.process.Machine.Nome;
        [Category("Processo")]
        public string Filme => this.process.Machine.Filme;
        [Category("Processo")]
        public string Papel => this.process.Machine.Papel;
        [Category("Processo")]
        public string Molde => this.process.Machine.Molde;
        [Category("Processo")]
        public string UnidadesNesteTurno => this.unidadesPorTurno;
        [Category("Processo")]
        public DateTime DataFinalProcesso => this.estimatedDelivery;
        [Category("Processo")]
        public DateTime DataInicioProcesso => this.sTask.start;

        private ScheduledTask sTask;
        private GeneticTask task;
        private GeneticTask.GeneticProcess process;
        private ComponentesDosArtigos component;
        private DateTime estimatedDelivery;
        private DateTime estimatedDeliveryEncomenda;
        private string unidadesPorTurno;
    }
}
