using MyClassLib.Interfaces;

namespace MyClassLib.Models
{
    public class User 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public List<Project> UserProjects = new List<Project>();
        public List<Models.Task> UserTasks = new List<Models.Task>();

        public User(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }      

    }
}