using MEDIRM.Modelos;
using ProjectScheduling.SolverFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIRM.GeneticSolution.Helpers
{
    public class TurnoWork
    {
        public List<Funcionario> frente;
        public List<Funcionario> tras;
        public int Maquina;
        public ScheduledTask Task;
        public DateTime start;
        public DateTime end;
    }

}
