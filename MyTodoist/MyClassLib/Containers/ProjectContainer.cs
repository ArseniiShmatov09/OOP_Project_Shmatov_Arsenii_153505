using MyClassLib.Interfaces;
using MyClassLib.Models;

namespace MyClassLib.Containers
{
    public class ProjectContainer : IFunctional<Project>
    {
        private List<Project> Projects = new List<Project>();
        private Project Others = new Project("Другие", "Для различных задач");

        public ProjectContainer()
        {
            Add(Others.Name, Others.Description);
        }

        public void Add(string name, string description)
        {
            Projects.Add(new Project(name, description));
        }

        public void Remove(Project project)
        {
            Projects.Remove(project);
        }

        public void Change(Project project, string newName, string newDescription)
        {
            project.Name = newName;
            project.Description = newDescription;
        }

        public Project? Find(string name)
        {
            return Projects.Find(x => x.Name == name);
        }

        public List<Project> GetList()
        {
            return Projects;
        }

        public void AddTask(string taskName, string taskDescription, string projectName = "Другие")
        {
            Project? item = Projects.Find(x => x.Name == projectName);
            item?.AddTask(taskName, taskDescription);
        }

        public void RemoveTask(Models.Task task, string projectName = "Другие")
        {
            Project? item = Projects.Find(x => x.Name == projectName);
            item?.RemoveTask(task);
        }

        public void ChangeTask(Models.Task task, string newName, string newDescription, string projectName = "Другие")
        {
            Project? item = Projects.Find(x => x.Name == projectName);
            item?.ChangeTask(task, newName, newDescription);
        }

        public Models.Task? FindTask(string taskName, string projectName = "Другие")
        {
            Project? item = Projects.Find(x => x.Name == projectName);
            return item?.FindTask(taskName);
        }

        public List<Models.Task>? GetTasksList(string projectName = "Другие")
        {
            Project? item = Projects.Find(x => x.Name == projectName);
            return item?.GetTasks();
        }

        public void CompleteTask(Models.Task task, string projectName = "Другие")
        {
            Project? item = Projects.Find(x => x.Name == projectName);
            item?.CompleteTask(task);
        }

        public List<Models.Task>? GetCompletedTasksList(string projectName = "Другие")
        {
            Project? item = Projects.Find(x => x.Name == projectName);
            return item?.GetCompletedTasks();
        }


    }
}
