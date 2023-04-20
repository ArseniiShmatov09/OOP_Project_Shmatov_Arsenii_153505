using MyClassLib;
using System.Collections.Generic;
using MyClassLib.Interfaces;
using MyClassLib.Main;

Controller controller = new Controller();


/*Console.WriteLine("// По умолчанию существует проект 'Другие' в который добавляются задачи, если не указывать навзвание проекта");
Console.WriteLine();
controller.Show();
controller.ShowTasks();*/



/*Console.WriteLine("//Показана невозможность создавать проекты с одинаковым именем");
Console.WriteLine();
controller.Add("A", "A");
controller.Add("B", "B");
controller.Show();
controller.Add("A", "AA");
controller.Show();*/



/*Console.WriteLine("//Показана работа с удалением + невозможность удаления несуществующего проекта");
Console.WriteLine();
controller.Add("A", "A");
controller.Add("B", "B");
controller.Show();
controller.Remove("C");
controller.Show();
controller.Remove("A");
controller.Show();
*/



/*
Console.WriteLine("//Показана работа с изменением + невозможность изменения несуществующего проекта");
Console.WriteLine();
controller.Add("B", "B");
controller.Change("D", "E", "E");
controller.Show();
controller.Change("B", "E", "E");
controller.Show();

*/


/*
Console.WriteLine("//Показана невозможность создавать задачи в проекте с одинаковым именем (чтобы добавить задачу в созданный проект, нужно указать его имя доп. параметром)");
Console.WriteLine();
controller.AddTask("a", "a");
controller.AddTask("b", "b");
controller.ShowTasks();
controller.AddTask("a", "a");
controller.ShowTasks();

controller.Add("B", "B");
controller.AddTask("b", "b", "B");
controller.ShowTasks("B");
Console.WriteLine("//Добавление задачи в проект 'B' с одинаковым именем");
Console.WriteLine();
controller.AddTask("b", "b", "B");
Console.WriteLine("//Добавление задачи в несуществующий проект 'А'");
Console.WriteLine();
controller.AddTask("b", "b", "A");
controller.ShowTasks("B");

Console.WriteLine("//Функции изменения и удаления задач в проекте также обработаны и предусмотрена невозможность работы с существующими и несуществующими задачами");


*/



/*controller.AddTask("A", "A");
controller.SetPriority("A", 1); // устанавливает приоритет(по умолчанию - 4)
controller.GetNotify("A"); //узнать сколько еще есть времени на задачу
controller.ShowTasks();
controller.SetDeadlineTime("A", 2023, 04, 20); //установить дедлайн(по умалчанию - некст день)
controller.GetNotify("A");
controller.ShowTasks();



*/

/*
controller.AddTask("B", "B");
controller.AddTask("Y", "Y");
controller.AddTask("X", "X");
controller.AddTask("A", "A");

controller.ShowTasks();

controller.SortByName();
Console.WriteLine("//Показаны задачи, отсортированные по имени");
Console.WriteLine();
controller.ShowTasks();

controller.SetPriority("B", 3);
controller.SetPriority("A", 2);
controller.SetPriority("X", 1);

controller.SortByPriority();
Console.WriteLine("//Показаны задачи, отсортированные по приоритету");
Console.WriteLine();
controller.ShowTasks();
*/




Console.WriteLine("//Функционал по выполнению задачи");
controller.Add("B", "B");
controller.AddTask("b", "b");
controller.ShowComletedTasks("B");

controller.AddTask("A", "A");
controller.AddTask("B", "B");
controller.ShowTasks();
controller.CompleteTask("A");
controller.ShowTasks();
controller.ShowComletedTasks();
