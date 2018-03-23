using MEDIRM.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIRM.GeneticSolution
{


    class MaquinaResource
    {
        public string Tipo {  get { return this.maquina.Tipo; } }
        public Maquina maquina;

        public MaquinaResource(Maquina maqDB)
        {
            this.maquina = maqDB;
        }
    }

    class Tarefa
    {
        private MaquinaResource maquina1;
        private ComponentesDosArtigo components;
        private Encomenda encomenda;

        public Tarefa(MaquinaResource maquina1, ComponentesDosArtigo components, Encomenda encomenda)
        {
            this.maquina1 = maquina1;
            this.components = components;
            this.encomenda = encomenda;

            this.Molde = maquina1.maquina.Molde;
            this.TipoMaquina = maquina1.Tipo;
        }
        public string TipoMaquina { get; private set; }
        public string Molde { get; private set; }
        public int Quantidade { get { return int.Parse(this.components.Quantidade); } }
    }

    class Planificaçao
    {
        public Funcionario Funcionario;
        public Maquina Maquina;
        public string DiaDaSemana;
        public string Turno;
        public Molde Molde;
        public string Posição;
        public Artigo Artigo;
        public DateTime DataPrevista;
    }

    class Algoritmo
    {

        public List<Tarefa> P1 = new List<Tarefa>();
        public List<Tarefa> P2 = new List<Tarefa>();
        public List<Tarefa> P3 = new List<Tarefa>();
        public List<Tarefa> P4 = new List<Tarefa>();
        public List<Tarefa> P5 = new List<Tarefa>();

        public List<MaquinaResource> Maquinas = new List<MaquinaResource>();

        public List<Planificaçao> plan = new List<Planificaçao>();
        public List<Planificaçao> Generate()
        {
            var context = new MEDIRM.Modelos.MEDIRMContext();
            var todasEncomendas = context.Encomendas.Where(x => x.Estado.ToLower() != "terminado");

            foreach (var encomenda in todasEncomendas)
            {
                var todosArtigosdAsEncomendas = new List<Artigo>();
                todosArtigosdAsEncomendas.AddRange(context.Artigoes.Where(x => x.Nome == encomenda.Artigo));
                foreach (var compoartigos in todosArtigosdAsEncomendas)
                {
                    var todosComponents = new List<ComponentesDosArtigo>();

                    todosComponents.AddRange(context.ComponentesDosArtigo.Where(x => x.Artigo == "1"));
                    foreach (var components in todosComponents)
                    {
                        var maquina1 = ResourceFromMaquina(compoartigos.Maquina1);
                        var maquina2 = ResourceFromMaquina(compoartigos.Maquina2);
                        var maquina3 = ResourceFromMaquina(compoartigos.Maquina3);
                        var maquina4 = ResourceFromMaquina(compoartigos.Maquina4);
                        var maquina5 = ResourceFromMaquina(compoartigos.Maquina5);
                        int currentProcessCount = 0;
                        var artigo = context.Artigoes.FirstOrDefault(x => x.ID.ToString() == components.Artigo.ToString());
                        int qt = int.Parse(components.Quantidade);
                        if (maquina1 != null)
                        {
                            currentProcessCount++;
                            P1.Add(new Tarefa(maquina1, components, encomenda));
                        }
                        if (maquina2 != null)
                        {
                            currentProcessCount++;
                            P2.Add(new Tarefa(maquina2, components, encomenda));
                        }
                        if (maquina3 != null)
                        {
                            currentProcessCount++;
                            P3.Add(new Tarefa(maquina3, components, encomenda));
                        }
                        if (maquina4 != null)
                        {
                            currentProcessCount++;
                            P4.Add(new Tarefa(maquina4, components, encomenda));
                        }
                        if (maquina5 != null)
                        {
                            currentProcessCount++;
                            P5.Add(new Tarefa(maquina5, components, encomenda));
                        }


                    }

                }
            }

            P1 = OrderByGroup(P1);
            P2 = OrderByGroup(P2);
            P3 = OrderByGroup(P3);
            P4 = OrderByGroup(P4);
            P5 = OrderByGroup(P5);

            foreach (var turno in context.TurnosFuncionario)
            {
                if (turno.Turno1.ToLower() != "nenhum")
                {
                    var plani = new Planificaçao();
                    plani.Turno = turno.Turno1;
                    plani.DiaDaSemana = turno.DiaDaSemana;
                    plani.Funcionario = context.Funcionarios.FirstOrDefault(x=>x.Nome == turno.Funcionario);
                    plan.Add(plani);
                }
                if (turno.Turno2.ToLower() != "nenhum")
                {
                    var plani2 = new Planificaçao();
                    plani2.Turno = turno.Turno2;
                    plani2.DiaDaSemana = turno.DiaDaSemana;
                    plani2.Funcionario = context.Funcionarios.FirstOrDefault(x => x.Nome == turno.Funcionario);

                    plan.Add(plani2);
                }
                if (turno.Turno3.ToLower() != "nenhum")
                {
                    var plani3 = new Planificaçao();
                    plani3.Turno = turno.Turno3;
                    plani3.DiaDaSemana = turno.DiaDaSemana;
                    plani3.Funcionario = context.Funcionarios.FirstOrDefault(x => x.Nome == turno.Funcionario);

                    plan.Add(plani3);

                }
                if (turno.Turno4.ToLower() != "nenhum")
                {
                    var plani4 = new Planificaçao();
                    plani4.Turno = turno.Turno4;
                    plani4.DiaDaSemana = turno.DiaDaSemana;
                    plani4.Funcionario = context.Funcionarios.FirstOrDefault(x => x.Nome == turno.Funcionario);

                    plan.Add(plani4);

                }
            }

            // Order Maquina1 
            var group = P1.GroupBy(x => x.TipoMaquina);

            Dictionary<string, int> lookup = new Dictionary<string, int>()
                  {
                    { "Segunda-feira" , 0 },
                     { "Terça-feira" , 1 },
                     { "Quarta-feira" , 2 },
                     { "Quinta-feira" , 3 },
                     { "Sexta-feira" , 4 },
                     { "Sabado" , 4 },
                  };

            // para cada maquina na Prioridade 1
            foreach (var maquina in group)
            {
                var list = maquina.ToList();
                var tipo = maquina.Key;
                var MaquinaTipo = context.Maquinas.FirstOrDefault(x => x.Tipo == tipo);
                // Ordernado Tarefas por molde
                var lPorMolde = list.GroupBy(x => x.Molde);
                foreach (var molde in lPorMolde)
                {
                    var tarefas = molde.ToList();
                    var UnidadesTotal = tarefas.Sum(x => x.Quantidade);
                    var prodPorHora = int.Parse(string.IsNullOrEmpty(MaquinaTipo.Velocidade1) ? "1" : MaquinaTipo.Velocidade1);

                    var tempoTotal = UnidadesTotal / prodPorHora;
                    var produced = 0;
                    // ver que pessoas podem usar a maquina

                    foreach (var pessoasMaquinas in context.PessoasMaquinas)
                    {
                        var maq = context.Maquinas.FirstOrDefault(x => x.Nome == pessoasMaquinas.Maquina);
                        if (maq.Tipo != tipo)
                            continue;
                        // Primeira planificaçao que essa pessoa pode ter .
                        var planoFirst = plan.OrderBy(x => lookup[x.DiaDaSemana.ToLower()]).FirstOrDefault(x => x.Funcionario.Sigla == pessoasMaquinas.Funcionario && x.Maquina == null);
                        if (planoFirst == null)
                        {
                            break;
                            throw new Exception("NAO existem turnos disponiveis para esse funcionaro");
                        }
                        produced += TurnoHoras(planoFirst.Turno);
                        // atribuir
                        planoFirst.Maquina = maq;
                        planoFirst.Molde = context.Moldes.FirstOrDefault(x => x.Designacao == maq.Molde);
                        while (produced < UnidadesTotal)
                        {
                            planoFirst = plan.OrderBy(x => lookup[x.DiaDaSemana.ToLower()]).FirstOrDefault(x => x.Funcionario.Sigla == pessoasMaquinas.Funcionario && x.Maquina == null);
                            if (planoFirst == null)
                            {
                                break;
                                throw new Exception("NAO existem turnos disponiveis para esse funcionaro");
                            }
                            produced += TurnoHoras(planoFirst.Turno);
                            // atribuir
                            planoFirst.Maquina = maq;
                            planoFirst.Molde = context.Moldes.FirstOrDefault(x => x.Designacao == maq.Molde);

                        }
                    }
                  
                }

            }
            return plan;

        }

        int TurnoHoras(string turno)
        {
            var tur = turno.Trim().ToLower();
            if (tur == "7h - 8h")
            {
                return 1;
            }
            if (tur == "8h - 12h")
            {
                return 4;
            }
            if (tur == "12h - 13h")
            {
                return 1;
            }
            if (tur == "14h - 17h")
            {
                return 3;
            }
            if (tur == "17h - 18h")
            {
                return 1;
            }
            return 0;
        }
        public List<Tarefa> OrderByGroup(List<Tarefa> list)
        {
            var groups = list.GroupBy(x => x.Molde);
            var nList = new List<Tarefa>();
            foreach (var group in groups)
            {
                nList.AddRange(group.AsEnumerable());
            }
            return nList;
        }
        private MaquinaResource ResourceFromMaquina(string maquina1)
        {

            if (maquina1 == null)
                return null;
            var context = new MEDIRM.Modelos.MEDIRMContext();
            var maqDB = context.Maquinas.FirstOrDefault(x => x.Nome == maquina1);

            var search = Maquinas.FirstOrDefault(x => x.maquina.Tipo == maqDB.Tipo);
            if (search == null)
            {
                var maq = new MaquinaResource(maqDB);
                Maquinas.Add(maq);
                return maq;
            }
            return search;

        }
    }
}
