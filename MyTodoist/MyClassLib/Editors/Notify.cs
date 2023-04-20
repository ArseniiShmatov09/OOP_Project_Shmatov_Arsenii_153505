using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.Models;

namespace MyClassLib.Editors
{
    public class Notify
    {
        public void GetNotify(Models.Task task)
        {
            Console.WriteLine($"До конца срока выполнения задачи {task.Name} осталось {task.DateTime.Subtract(DateTime.Now)}");
        }
    }
}
