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
        public string GetNotify(Models.Task task)
        {
           return ($"Until the end of the task '{task.Name}' is left {task.DateTime.Subtract(DateTime.Now)}");
        }
    }
}
