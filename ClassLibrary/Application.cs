using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Application
    {
        private Application application;
        private List<TaskList> taskList;

        public Application()
        {
            TaskList taskList = new TaskList("Входящие");
            taskLists = new List<TaskList>();
            taskLists.Add(taskList);
        }

        public Application GetApplication()
        {
            if (application != null)
            {
                return application;
            }
            application = new Application();
            return application;
        }

        public void CreateTaskList (string name)
        {
            TaskList taskList = new TaskList(name);
            taskLists.Add(taskList);
        }
        public TaskList GetTaskListNames (string name)
        {
            return taskLists.FirstOrDefault(taskList => taskList.GetName() == name);
        }
    }
}
