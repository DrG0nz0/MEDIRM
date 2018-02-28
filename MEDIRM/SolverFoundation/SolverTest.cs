using MEDIRM;
using ProjectScheduling;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ProjectScheduling.SolverFoundation
{
    class ProjectUtilities
    {
        // (Replace this with code that creates a "real" project. This project is randomly generated.)
        public static Project CreateProject()
        {

            var context = new MedirmDBEntities();

            var todasEncomendas = context.Encomenda.Where(x => x.Estado == "");
            var todosArtigosdAsEncomendas = new List<Artigo>();
            var todosComponents = new List<ComponentesDosArtigos>();
            var Tasks = new List<Task>();

            List<TaskDependency> links = new List<TaskDependency>();

            foreach (var encomenda in todasEncomendas)
            {
               todosArtigosdAsEncomendas.AddRange(context.Artigo.Where(x => x.ID.ToString() == encomenda.Artigo));
            }
            foreach( var compoartigos in todosArtigosdAsEncomendas)
            {
                todosComponents.AddRange(context.ComponentesDosArtigos.Where(x => x.Artigo == compoartigos.ID.ToString()));
            }

            List<Resource> resources = new List<Resource>();


            foreach (var components in todosComponents)
            {
                if (resources.FirstOrDefault(x=>x.Name == components.Maquina1) == null)
                {
                    resources.Add(new Resource(components.Maquina1, 1));
                }
                if (resources.FirstOrDefault(x => x.Name == components.Maquina2) == null)
                {
                    resources.Add(new Resource(components.Maquina2, 1));
                }
                if (resources.FirstOrDefault(x => x.Name == components.Maquina3) == null)
                {
                    resources.Add(new Resource(components.Maquina3, 1));
                }
                if (resources.FirstOrDefault(x => x.Name == components.Maquina4) == null)
                {
                    resources.Add(new Resource(components.Maquina4, 1));
                }
                //
                Task lastTask = null;
                if (components.Maquina1 != null)
                {
                    var artigo = context.Artigo.FirstOrDefault(x => x.ID.ToString() == components.Artigo.ToString());
                    var duration = 10;
                    var task = new Task(artigo.Nome, duration, new Assignment[] { new Assignment(resources.FirstOrDefault(x => x.Name == components.Maquina1), 1.0) });
                    task.componenteDosArtigos = components;
                    Tasks.Add(task);
                    lastTask = task;
                    task.Entrega = 500;
                }
                if (components.Maquina2 != null)
                {
                    var artigo = context.Artigo.FirstOrDefault(x => x.ID.ToString() == components.Artigo.ToString());
                    var duration = 10;
                    var task = new Task(artigo.Nome, duration, new Assignment[] { new Assignment(resources.FirstOrDefault(x => x.Name == components.Maquina2), 1.0) });
                    task.componenteDosArtigos = components;
                    Tasks.Add(task);
                    links.Add(new TaskDependency()
                    {
                        Source = lastTask,
                        Destination = task
                    });
                    lastTask = task;
                    task.Entrega = 500;
                }
                if (components.Maquina3 != null)
                {
                    var artigo = context.Artigo.FirstOrDefault(x => x.ID.ToString() == components.Artigo.ToString());
                    var duration = 10;
                    var task = new Task(artigo.Nome, duration, new Assignment[] { new Assignment(resources.FirstOrDefault(x => x.Name == components.Maquina3), 1.0) });
                    task.componenteDosArtigos = components;
                    Tasks.Add(task);
                    links.Add(new TaskDependency()
                    {
                        Source = lastTask,
                        Destination = task
                    });
                    lastTask = task;
                    lastTask = task;
                    task.Entrega = 500;
                }
                if (components.Maquina4 != null)
                {
                    var artigo = context.Artigo.FirstOrDefault(x => x.ID.ToString() == components.Artigo.ToString());
                    var duration = 10;
                    var task = new Task(artigo.Nome, duration, new Assignment[] { new Assignment(resources.FirstOrDefault(x => x.Name == components.Maquina4), 1.0) });
                    task.componenteDosArtigos = components;
                    Tasks.Add(task);
                    links.Add(new TaskDependency()
                    {
                        Source = lastTask,
                        Destination = task
                    });
                    lastTask = task;
                    lastTask = task;
                    task.Entrega = 500;
                }
            }
          

            //Task[] tasks = new Task[3];
            //var i = 0;
            //    tasks[i] = new Task("task" + i, 20, new Assignment[] { new Assignment(resources[0] , 1.0) });
            //    tasks[i].Entrega =30*50;
            //tasks[i].Molde = 0;
            //i++;
            //tasks[i] = new Task("task" + i, 5, new Assignment[] { new Assignment(resources[1], 1.0) });
            //tasks[i].Entrega = 30 * 50;
            //tasks[i].Molde = 1;
            //i++;
            //tasks[i] = new Task("task" + i, 5, new Assignment[] { new Assignment(resources[0], 1.0) });
            //tasks[i].Entrega = 30 * 50;
            //tasks[i].Molde = 1;
            //i++;
            //tasks[i] = new Task("task" + i, 1, new Assignment[] { new Assignment(resources[1], 1.0) });
            //tasks[i].Entrega = 30;
            //tasks[i].Molde = 1;
            //i++;
            ////
            //tasks[i] = new Task("task" + i, 2, new Assignment[] { new Assignment(resources[0], 1.0) });
            //tasks[i].Entrega = 30;
            //tasks[i].Molde = 0;
            //i++;



            //for (int i = 0; i < links.Length; i++)
            //{
            //    int source = random.Next(0, taskCount - 1);
            //    int dest = random.Next(source + 1, taskCount); // guaranteeing no cycles.
            //    links[i] = new TaskDependency { Source = tasks[source], Destination = tasks[dest] };
            //}

            return new Project(Tasks, resources, links);
        }

        public static void PrintProjectSchedule(Project project, IDictionary<int, double> schedule)
        {
            Console.WriteLine();
            Console.WriteLine("SCHEDULE:");
            foreach (var taskSchedule in schedule)
            {
                Task task = project.Tasks[taskSchedule.Key];
                double start = Math.Round(taskSchedule.Value, 3);
                Console.WriteLine("{0}: [{1} - {2}]", task.ID, start, start + task.Duration);
            }
        }

        private static DateTime AddDays(DateTime start, double hours, bool isStart)
        {
            while (hours > 0)
            {
                if (hours > 1)
                {
                    start = start.AddHours(1);
                    start = NextWorkingTime(start, false);
                    hours -= 1.0;
                }
                else
                {
                    start = start.AddHours(hours);
                    if (start.TimeOfDay >= TimeSpan.FromHours(isStart ? 17 : 17.01))
                    {
                        TimeSpan duration = start.TimeOfDay - TimeSpan.FromHours(17);
                        start = NextWorkingTime(start, isStart).Add(duration);
                    }
                    hours = 0;
                }
            }
            start = NextWorkingTime(start, isStart);
            return start;
        }

        private static DateTime NextWorkingTime(DateTime start, bool isStart)
        {
            if (start.TimeOfDay >= TimeSpan.FromHours(isStart ? 17 : 17.01))
            {
                start = start.Date.AddHours(24 + 8);
            }
            else if (start.Hour < 8)
            {
                start = start.Date.AddHours(8);
            }

            while (start.DayOfWeek == DayOfWeek.Saturday || start.DayOfWeek == DayOfWeek.Sunday)
            {
                start = start.AddDays(1);
            }
            return start;
        }

        public static string ToCsv(Project project, IDictionary<int, double> schedule)
        {
            DateTime projectStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            StringBuilder build = new StringBuilder(40 + project.Tasks.Count * 30);
            build.AppendLine("ID,Name,Duration,Start_Date,Finish_Date,Predecessors,Resource_Names");
            Dictionary<string, int[]> depMap = project.Dependencies
              .GroupBy(d => d.Destination.Name)
              .ToDictionary(g => g.Key, g => g.Select(d => d.Source.ID + 1).ToArray()); // need to add 1 for MS Project.
            foreach (Task task in project.Tasks)
            {
                string predNames = "";
                int[] predIds = null;
                if (depMap.TryGetValue(task.Name, out predIds))
                {
                    predNames = "\"" + string.Join(",", predIds) + "\"";
                }
                string resourceNames = "\"" + string.Join(",", task.Assignments.Select(a => a.Resource.Name)) + "\"";
                double startDay = schedule[task.ID];
                DateTime start = AddDays(projectStart, startDay, true);
                DateTime finish = AddDays(start, task.Duration, false);
                build.AppendFormat("{0},{1},{2}d,{3},{4},{5},{6}", task.ID + 1, task.Name, task.Duration,
                  start, finish, predNames, resourceNames);
                build.AppendLine();
            }
            return build.ToString();
        }

        public static List<ScheduledTask> Main(string[] args)
        {
            int taskCount =  5;
            int resourceCount = 3;
            bool verbose = true;

            Project project = ProjectUtilities.CreateProject();
            Console.WriteLine(project);

            Stopwatch stopwatch = new Stopwatch();
            SchedulingModel m = new SchedulingModel(verbose);

            stopwatch.Start();
            m.Initialize(project);
            Console.WriteLine("Init time = " + stopwatch.Elapsed);
            IDictionary<int, double> schedule = m.Solve();
            Console.WriteLine("Total time = " + stopwatch.Elapsed);

            ProjectUtilities.PrintProjectSchedule(project, schedule);

            var results = new List<ScheduledTask>();
            foreach (var taskSchedule in schedule)
            {
                Task task = project.Tasks[taskSchedule.Key];
                double start = Math.Round(taskSchedule.Value, 3);
                results.Add(new ScheduledTask(task, start, start + task.Duration));

            }
            Console.WriteLine(ProjectUtilities.ToCsv(project, schedule));
            return results;

        }
    }
}

