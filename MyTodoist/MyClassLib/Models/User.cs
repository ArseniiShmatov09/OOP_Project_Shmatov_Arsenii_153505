using MyClassLib.Interfaces;

namespace MyClassLib.Models
{
    public class User 
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public List<Project> UserProjects = new List<Project>();
        public List<Models.Task> UserTasks = new List<Models.Task>();

        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }      

    }
}