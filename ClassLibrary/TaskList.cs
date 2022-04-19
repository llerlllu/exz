using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TaskList
    {
        private string name;
        private List<Task> tasks;

        public TaskList(string name)
        {
            this.name = name;
            tasks = new List<Task>();
        }

        public string GetName()
        {
            return name;
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        public List<Task> GetTasks()
        {
            return tasks;
        }
        public void Remove(Task task)
        {
            tasks.Remove(task);
        }
        public List<Task> GetTasksByToday()
        {
            List<Task> tasksByToday = new List<Task>();
            foreach (var task in tasks)
            {
                if (task.Due == DateTime.Now)
                {
                    tasksByToday.Add(task);
                }
            }
            return tasksByToday;
        }
        public List<Task> GetTasksByFuture()
        {
            List<Task> tasksByFuture = new List<Task>();
            foreach (var task in tasks)
            {
                if (task.Due == DateTime.Now)
                {
                    tasksByFuture.Add(task);
                }
            }
            return tasksByFuture;
        }
    }
}
