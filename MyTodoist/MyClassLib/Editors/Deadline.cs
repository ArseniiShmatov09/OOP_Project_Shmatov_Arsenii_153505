using MyClassLib.Models;

namespace MyClassLib.Editors
{
    public class Deadline
    {

        public void SetDeadlineTime(Models.Task task, int year, int month, int day, int hours = 0, int minutes = 0, int seconds = 0)
        {
            task.DateTime = new DateTime(year, month, day, hours, minutes, seconds);
        }

    }
}
