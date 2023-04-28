using MyClassLib.Models;
using MyClassLib.Interfaces;

namespace MyClassLib.Containers
{
    public class TaskContainer : IFunctional<Models.Task>
    {
        public List<Models.Task> Tasks = new List<Models.Task>();
        public List<Models.Task> CompletedTasks = new List<Models.Task>();

        public void Add(string name, string description)
        {
            Tasks.Add(new Models.Task(name, description));
        }

        public void Remove(Models.Task task)
        {
            Tasks.Remove(task);
        }

        public void Change(Models.Task task, string newName, string newDescription)
        {
            task.Name = newName;
            task.Description = newDescription;
        }

        public Models.Task? Find(string name)
        {
            return Tasks.Find(x => x.Name == name);
        }

        public List<Models.Task> GetList()
        {
            return Tasks;
        }

        public void Complete(Models.Task task)
        {
            task.IsCompleted = true;
            Tasks.Remove(task);
            CompletedTasks.Add(task);
        }

        public List<Models.Task> GetCompletedList()
        {
            return CompletedTasks;
        }

    }
}
