using MyClassLib.Models;

namespace MyClassLib.Editors
{
    public class Priority
    {
        public void SetPriority(Models.Task task, int taskPriority)
        {
            switch (taskPriority)
            {
                case 1:
                    task.Priority = 1;
                    break;
                case 2:
                    task.Priority = 2;
                    break;
                case 3:
                    task.Priority = 3;
                    break;
                case 4:
                    task.Priority = 4;
                    break;
                default:
                    task.Priority = -1;
                    break;
            }
        }
    }
}
