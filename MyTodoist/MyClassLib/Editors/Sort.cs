using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.Models;

namespace MyClassLib.Editors
{
    public class Sort
    {
        public void SortByName(List<Models.Task> tasks)
        {
            tasks.Sort(delegate (Models.Task x, Models.Task y)
              {
                  if (x.Name == null && y.Name == null) return 0;
                  else if (x.Name == null) return -1;
                  else if (y.Name == null) return 1;
                  else return x.Name.CompareTo(y.Name);
              });
        }

        public void SortByPriority(List<Models.Task> tasks)
        {
            tasks.Sort(delegate (Models.Task x, Models.Task y)
            {
                if (x?.Priority == null && y?.Priority == null) return 0;
                else if (x?.Priority == null) return -1;
                else if (y?.Priority == null) return 1;
                else return x.Priority.CompareTo(y.Priority);
            });
        }

    }
}
