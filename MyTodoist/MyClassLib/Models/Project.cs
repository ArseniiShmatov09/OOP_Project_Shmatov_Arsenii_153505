using MyClassLib.Containers;
using MyClassLib.Interfaces;
using MyClassLib.Models;


namespace MyClassLib.Models
{
    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private TaskContainer TaskContainer = new TaskContainer();

        public Project(string name, string description)
        {
            Name = name;
            Description = description;

        }

        public void AddTask(string name, string description)
        {
            TaskContainer.Add(name, description);
        }

        public void RemoveTask(Task task) {

            TaskContainer.Remove(task);
        }

        public void ChangeTask(Task task, string newName, string newDiscription)
        {
            TaskContainer.Change(task, newName, newDiscription);
        }

        public Task? FindTask(string name)
        {
           return TaskContainer.Find(name);
        }

        public List<Task> GetTasks()
        {
            return TaskContainer.GetList();
        }

        public void CompleteTask(Task task)
        {
            TaskContainer.Complete(task);
        }

        public List<Task> GetCompletedTasks()
        {
            return TaskContainer.GetCompletedList();
        }

    }
}

