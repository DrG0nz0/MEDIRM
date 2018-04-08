using MEDIRM.GeneticSolution.Helpers;
using MEDIRM.Modelos;
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
    public class TurnoVisualizer
    {



        public TurnoVisualizer(TurnoWork turno, List<ScheduledTask> list, List<GeneticTask> Tasks)
        {
            this.turno = turno;
            var task = turno.Task;
            this.task = Tasks[task.JobId];
            this._jobID = task.JobId;
            this._ProcessId = task.ProcessId;
            this.sTask = task;
            this.process = this.task.Processes[task.ProcessId];
            this.component = this.task.components;
            //this.estimatedDelivery = task.Breaks.Last().End;
            var last = list.Last(x => x.JobId == task.JobId && x.end - x.start > 1/60*5);
            //this.estimatedDeliveryEncomenda = last.Breaks.Last().End;
            var hours = turno.end.Subtract(turno.start).Hours;
            int velocidade;
            this.unidadesPorTurno = int.TryParse(process.Machine.Velocidade1, out velocidade) ? (hours * velocidade).ToString() : "N/A";
        }

        [Category("Turno")]
        public string Frente => String.Join(",", this.turno.frente.Select(x=> x.Nome));
        [Category("Turno")]
        public string Tras => String.Join(",", this.turno.tras.Select(x => x.Nome));
        [Category("Turno")]
        public string Turno => this.turno.start.ToString( "HH:mm") + "-" + this.turno.end.ToString("HH:mm");
        [Category("Turno")]
        public string DiaDaSemana => this.turno.end.ToString("ddd");

        [Category("Encomenda")]
        public int Encomenda => this.task.Encomenda.NumeroEnco;
        [Category("Encomenda")]
        public string Cliente => this.task.Encomenda.Cliente;
        [Category("Encomenda")]
        public string Artigo => this.task.Encomenda.Artigo;
        [Category("Encomenda")]
        public int Quantidade => this.task.Encomenda.Quantidade.Value;
        [Category("Encomenda")]
        public DateTime? DataEntrega => this.task.Encomenda.DataLimite;

        [Category("Processo")]
        public string TipoMaquina => this.process.Machine.Tipo;
        [Category("Processo")]
        public int QuantidadeDeComponentes => int.Parse(this.process.components.Quantidade) * this.Quantidade;
        [Category("Processo")]
        public float TempoDoProcesso => int.Parse(this.process.components.Quantidade) * this.Quantidade / float.Parse(this.process.Machine.Velocidade1);
        [Category("Processo")]
        public string Filme => this.process.Machine.Filme;
        [Category("Processo")]
        public string Papel => this.process.Machine.Papel;
        [Category("Processo")]
        public string Molde => this.process.Machine.Molde;
        [Category("Processo")]
        public string UnidadesNesteTurno => this.unidadesPorTurno;

        private int _jobID;
        private int _ProcessId;
        private ScheduledTask sTask;
        private GeneticTask task;
        private GeneticTask.GeneticProcess process;
        private ComponentesDosArtigo component;
        private DateTime estimatedDelivery;
        private DateTime estimatedDeliveryEncomenda;
        private string unidadesPorTurno;
        private TurnoWork turno;
    }
}
