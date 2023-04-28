using MyClassLib.Interfaces;
using MyClassLib.Models;
using MyClassLib.Containers;
using MyClassLib.Editors;

namespace MyClassLib.Main
{
    [Serializable]

    public class Controller : IFunctionalController
    {
        public ProjectContainer container = new ProjectContainer();
        private Priority priority = new Priority();
        private Deadline deadline = new Deadline();
        private Notify notify = new Notify();
        private Sort sort = new Sort();

        private Controller() { }
        private static Controller? _instance;

        public static Controller GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Controller();
            }
            return _instance;
        }
        public void Add(string name, string decription)
        {
            try
            {
                if (container.Find(name) == null)
                {
                    container.Add(name, decription);
                  
                }

                else throw new Exception();
            }
            catch
            {
                Console.WriteLine("Ошибка! Невозможно добавить проект");
                Console.WriteLine("");
            }
        }

        public void Remove(string name)
        {
            Project? item = container.Find(name);

            try
            {
                if (item != null)
                {

                    container.Remove(item);
                }

                else throw new Exception();
            }
            catch
            {
                Console.WriteLine("Ошибка! Невозможно удалить проект");
                Console.WriteLine("");

            }
        }

        public void Change(string name, string newName, string newDescription)
        {
            Project? item = container.Find(name);

            try
            {
                if (item != null)
                {
                    container.Change(item, newName, newDescription);

                }

                else throw new Exception();
            }

            catch
            {
                Console.WriteLine("Ошибка! Невозможно изменить проект");
                Console.WriteLine("");
            }
        }

        public void Show()
        {
            try
            {
                if (container.GetList().Count != 0)
                    foreach (var item in container.GetList())
                    {
                        Console.WriteLine(item.Name);
                        Console.WriteLine(item.Description);
                        Console.WriteLine("");

                    }

                else throw new Exception();
            }
            catch
            {
                Console.WriteLine("Cписок проектов пуст");
                Console.WriteLine("");
            }

        }

        public void AddTask(string taskName, string taskDecription, string projectName = "Others")
        {
            try
            {
                if (container.Find(projectName) != null)
                {
                    try
                    {
                        if (container.FindTask(taskName, projectName) == null)
                        {
                            container.AddTask(taskName, taskDecription, projectName);
                        }

                        else throw new Exception();
                    }

                    catch
                    {
                        Console.WriteLine("Ошибка! Невозможно добавить задачу в проект");
                        Console.WriteLine("");
                    }
                }

                else throw new Exception();
            }
            catch
            {
                Console.WriteLine("Такого проекта не существует! Невозможно добавить задачу");
                Console.WriteLine("");
            }
        }

        public void RemoveTask(string taskName, string projectName = "Others")
        {
            Models.Task? item = container.FindTask(taskName, projectName);

            try
            {
                if (container.Find(projectName) != null)
                {
                    try
                    {
                        if (item != null)
                        {

                            container.RemoveTask(item, projectName);
                        }

                        else throw new Exception();
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Невозможно удалить зaдачу в проекте");
                        Console.WriteLine("");
                    }
                }

                else throw new Exception();
            }

            catch
            {
                Console.WriteLine("Такого проекта не существует! Невозможно удалить зaдачу");
                Console.WriteLine("");
            }
        }

        public void ChangeTask(string taskName, string newName, string newDescription, string projectName = "Others")
        {
            Models.Task? item = container.FindTask(taskName, projectName);
            try
            {
                if (container.Find(projectName) != null)
                {
                    try
                    {
                        if (item != null)
                        {
                            container.ChangeTask(item, newName, newDescription, projectName);

                        }

                        else throw new Exception();

                    }

                    catch
                    {
                        Console.WriteLine("Ошибка! Невозможно изменить задачу в проекте");
                        Console.WriteLine("");
                    }

                }

                else throw new Exception();
            }

            catch
            {
                Console.WriteLine("Такого проекта не существует! Невозможно изменить задачу");
                Console.WriteLine("");
            }
        }

        public void ShowTasks(string projectName = "Others")
        {
            try
            {
                if (container.Find(projectName) != null)
                {
                    try
                    {
                        if (container?.GetTasksList(projectName).Count != 0)
                        {
                            Console.WriteLine($"Задачи в проекте {projectName}: ");
                            foreach (var item in container.GetTasksList(projectName))
                            {
                                Console.WriteLine(item.Name);
                                Console.WriteLine(item.Description);
                                Console.WriteLine(item.Priority);
                                Console.WriteLine(item.DateTime);
                                if (item.IsCompleted) Console.WriteLine("Выполнена");
                                else Console.WriteLine("Не выполнена");
                                Console.WriteLine("");
                            }
                        }

                        else throw new Exception();
                    }

                    catch
                    {
                        Console.WriteLine("Cписок задач в проекте пуст");
                        Console.WriteLine("");
                    }

                }
                else throw new Exception();

            }
            catch
            {
                Console.WriteLine("Такого проекта не существует!");
                Console.WriteLine("");
            }
        }

        public void SetPriority(string taskName, int taskPriority, string projectName = "Others")
        {
            try
            {
                if (container.Find(projectName) != null)
                {
                    Models.Task? item = container.FindTask(taskName, projectName);

                    try
                    {
                        if (item != null)
                        {
                            priority.SetPriority(item, taskPriority);
                            try
                            {
                                if (item.Priority == -1)
                                {
                                    priority.SetPriority(item, 4);
                                    throw new Exception();
                                }
                            }

                            catch
                            {
                                Console.WriteLine("Ошибка! Неверно задан приоритет для задачи");
                            }
                        }
                        else throw new Exception();
                    }

                    catch
                    {
                        Console.WriteLine("Ошибка! Не удалось найти данную задачу");
                    }
                }

                else throw new Exception();
            }

            catch
            {
                Console.WriteLine("Ошибка! Не удалось найти данный проект");
            }

        }

        public void SetDeadlineTime(string taskName, int year, int month, int day, int hours = 0, int minutes = 0, int seconds = 0, string projectName = "Others")
        {
            try
            {
                if (container.Find(projectName) != null)
                {
                    Models.Task? item = container.FindTask(taskName, projectName);
                    try
                    {
                        if (item != null)
                        {
                            try
                            {
                                DateTime temp = new DateTime(year, month, day, hours, minutes, seconds);

                                if (temp >= DateTime.Now)
                                {
                                    deadline.SetDeadlineTime(item, year, month, day, hours, minutes, seconds);
                                }

                                else
                                {
                                    throw new Exception();
                                }
                            }

                            catch
                            {
                                Console.WriteLine("Ошибка! Неверно задан срок для задачи");
                            }
                        }
                        else throw new Exception();
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Не удалось найти данную задачу");
                    }
                }
                else throw new Exception();

            }
            catch
            {
                Console.WriteLine("Ошибка! Не удалось найти данный проект");
            }
        }

        public void CompleteTask(string taskName, string projectName = "Others")
        {
            Models.Task? item = container.FindTask(taskName, projectName);

            try
            {
                if (container.Find(projectName) != null)
                {
                    try
                    {
                        if (item != null)
                        {
                            container.CompleteTask(item, projectName);
                        }
                        else throw new Exception();
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Невозможно выполнить зaдачу в проекте");
                        Console.WriteLine("");
                    }
                }

                else throw new Exception();
            }

            catch
            {
                Console.WriteLine("Такого проекта не существует! Невозможно выполнить зaдачу");
                Console.WriteLine("");
            }

        }

        public void ShowComletedTasks(string projectName = "Others")
        {
            try
            {
                if (container.Find(projectName) != null)
                {
                    try
                    {
                        if (container?.GetCompletedTasksList(projectName).Count != 0)
                        {
                            Console.WriteLine($"Выполненные задачи в проекте {projectName}: ");
                            foreach (var item in container?.GetCompletedTasksList(projectName))
                            {
                                Console.WriteLine(item.Name);
                                Console.WriteLine(item.Description);
                                Console.WriteLine(item.Priority);
                                Console.WriteLine(item.DateTime);
                                if (item.IsCompleted) Console.WriteLine("Выполнена");
                                else Console.WriteLine("Не выполнена");
                                Console.WriteLine("");
                            }
                        }

                        else throw new Exception();
                    }

                    catch
                    {
                        Console.WriteLine("Cписок выполненных задач в проекте пуст");
                        Console.WriteLine("");
                    }

                }
                else throw new Exception();

            }
            catch
            {
                Console.WriteLine("Такого проекта не существует!");
                Console.WriteLine("");
            }

        }

        public void GetNotify(string taskName, string projectName = "Others")
        {
            try
            {
                if (container.Find(projectName) != null)
                {
                    try
                    {
                        Models.Task? item = container.FindTask(taskName, projectName);
                        if (item != null)
                        {

                            notify.GetNotify(item);
                        }
                        else throw new Exception();


                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Не удалось найти данную задачу");
                    }

                }
                else throw new Exception();
            }
            catch
            {
                Console.WriteLine("Ошибка! Не удалось найти данный проект");
            }
        }

        public void SortByName(string projectName = "Others")
        {
            try
            {
                if (container.Find(projectName) != null)
                {
                    try
                    {
                        if (container?.GetTasksList(projectName).Count != 0)
                        {
                            sort.SortByName(container?.GetTasksList(projectName));
                        }

                        else throw new Exception();
                    }

                    catch
                    {
                        Console.WriteLine("Cписок задач в проекте пуст");
                        Console.WriteLine("");
                    }

                }
                else throw new Exception();

            }
            catch
            {
                Console.WriteLine("Такого проекта не существует!");
                Console.WriteLine("");
            }

        }

        public void SortByPriority(string projectName = "Others")
        {
            try
            {
                if (container.Find(projectName) != null)
                {
                    try
                    {
                        if (container?.GetTasksList(projectName).Count != 0)
                        {
                            sort.SortByPriority(container?.GetTasksList(projectName));
                        }

                        else throw new Exception();
                    }

                    catch
                    {
                        Console.WriteLine("Cписок задач в проекте пуст");
                        Console.WriteLine("");
                    }

                }
                else throw new Exception();

            }
            catch
            {
                Console.WriteLine("Такого проекта не существует!");
                Console.WriteLine("");
            }

        }
    }

}
