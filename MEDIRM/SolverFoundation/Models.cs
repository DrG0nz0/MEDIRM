using MEDIRM;
using ProjectScheduling.SolverFoundation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ProjectScheduling
{
    /// <summary>A project.
    /// </summary>
    public class Project
    {
        /// <summary>The list of tasks in the project.
        /// </summary>
        public IList<Task> Tasks { get; private set; }

        /// <summary>The list of resources in the project.
        /// </summary>
        public IList<Resource> Resources { get; private set; }

        /// <summary>The list of task dependency links in the project.
        /// </summary>
        public IList<TaskDependency> Dependencies { get; private set; }

        public Project(IList<Task> tasks, IList<Resource> resources, IList<TaskDependency> links)
        {
            //List<Encomenda> encomendas = new List<Encomenda>();
            //foreach(var encomenda in encomendas)
            //{
            //    //Tasks.Add(new Task(encomenda));
            //}
            //List<Maquina> maquinas = new List<Maquina>();
            //foreach (var maq in maquinas)
            //{
            //    //Resources.Add(new Resource(maq));
            //}
            Tasks = tasks;
            Resources = resources;
            Dependencies = links;

            // Load from DB

            
        }

        public override string ToString()
        {
            StringBuilder build = new StringBuilder(40 + Tasks.Count * 20);
            build.AppendLine(new string('-', 40));
            build.AppendLine("PROJECT");
            build.AppendLine("TASKS");
            foreach (Task task in Tasks)
            {
                build.AppendLine(task.ToString());
            }
            build.AppendLine("LINKS");
            foreach (TaskDependency link in Dependencies)
            {
                build.AppendLine(link.ToString());
            }
            build.AppendLine("RESOURCES");
            foreach (Resource resource in Resources)
            {
                build.AppendLine(resource.ToString());
            }
            build.AppendLine(new string('-', 40));
            return build.ToString();
        }

      //  private static Project CreateProject(int taskCount)
      //  {
      //      System.Random random = new Random(0);
      //      int maxDuration = 5;
      //      int linkCount = Math.Max(taskCount / 10, 1);

      //      Resource[] resources = new Resource[] {
      //  new Resource("R1", 100.0),
      //  new Resource("R2", 100.0)
      //};

      //      Task[] tasks = new Task[taskCount];
      //      for (int i = 0; i < tasks.Length; i++)
      //      {
      //          tasks[i] = new Task("t" + i, random.Next(1, maxDuration + 1), new Assignment[] { new Assignment(resources[i % resources.Length], 1.0) });
      //      }

      //      TaskDependency[] links = new TaskDependency[linkCount];
      //      for (int i = 0; i < links.Length; i++)
      //      {
      //          int source = random.Next(0, taskCount - 1);
      //          int dest = random.Next(source + 1, taskCount); // guaranteeing no cycles.
      //          links[i] = new TaskDependency { Source = tasks[source], Destination = tasks[dest] };
      //      }

      //      return new Project(tasks, resources, links);
      //  }
    }

    /// <summary>A task.
    /// </summary>
    public class Task
    {
        private IEnumerable<Assignment> assignments;
        private static int nextID = 0;

        public Task(string name, double duration,DateTime? entrega, IEnumerable<Assignment> assignments)
        {
            ID = nextID++;
            Name = name;
            Duration = duration;
            this.assignments = assignments;
            this.Entrega = ScheduledTask.EntregaFromDate(entrega.HasValue ? entrega.Value :  DateTime.Now.AddYears(1));
        }
        /// <summary>A unique ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>The task name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>The task duration (time unit unspecified).
        /// </summary>
        public double Duration { get; set; }

        public int Molde { get; set; }

        public double Entrega { get; }

        public ComponentesDosArtigos componenteDosArtigos;
        /// <summary>The resource assignments for the task.
        /// </summary>
        public IEnumerable<Assignment> Assignments
        {
            get { return assignments; }
        }

        public Encomenda Encomenda { get; internal set; }

        public override string ToString()
        {
            return String.Format("{0}: {1} duration = {2}", ID, Name, Duration);
        }
    }

    /// <summary>A finish-to-start dependency between tasks.
    /// </summary>
    public class TaskDependency
    {
        /// <summary>The predecessor task.
        /// </summary>
        public Task Source { get; set; }

        /// <summary>The successor task.
        /// </summary>
        public Task Destination { get; set; }

        public override string ToString()
        {
            return String.Format("{0} -> {1}",Source.ID, Destination.ID);
        }
    }

    /// <summary>An assignment, corresponding to a task and a resource.
    /// </summary>
    public class Assignment
    {
        /// <summary>The resource.
        /// </summary>
        public Resource Resource { get; set; }

        /// <summary>The rate at which work is performed.
        /// </summary>
        public double Units { get; set; }

        public Assignment(Resource resource, double units)
        {
            Resource = resource;
            Units = units;
        }

        public override string ToString()
        {
            return String.Format("r{0}: units = {1}", Resource.ID, Units);
        }
    }

    /// <summary>A resource.
    /// </summary>
    /// <remarks>
    /// A resource may correspond to a work resource (such as an employee),
    /// or a material resource (such as a machine).
    /// </remarks>
    public class Resource
    {
        private static int nextID = 0;

        /// <summary>A unique ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>The resource name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>The maximum rate at which the resource can perform work.
        /// </summary>
        public double MaxUnits { get; set; }

        public Resource(string name, double maxUnits)
        {
            ID = nextID++;
            Name = name;
            MaxUnits = maxUnits;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1} max units = {2}", ID, Name, MaxUnits);
        }
    }
}