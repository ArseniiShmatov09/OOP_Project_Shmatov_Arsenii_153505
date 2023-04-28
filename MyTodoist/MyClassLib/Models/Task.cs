using MyClassLib.Interfaces;

namespace MyClassLib.Models
{
    [Serializable]
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsCompleted { get; set; }   


        public Task(string name, string description)
        {
            Name = name;
            Description = description;
            Priority = 4;
            DateTime = DateTime.Today.AddDays(1);
            IsCompleted = false;

        }
        public Task(){ }
    }
     
}
