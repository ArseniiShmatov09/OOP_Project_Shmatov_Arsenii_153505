using MyClassLib.Main;
using MyClassLib.Models;
using MySerializer;
using System.Text;


string ProjectsFileJSON = "D:\\OOP\\MyTodoist\\MyTodoist\\data\\ProjectsJSON.txt";
string TasksFileJSON = "D:\\OOP\\MyTodoist\\MyTodoist\\data\\TasksJSON.txt";
string CompletedTasksFileJSON = "D:\\OOP\\MyTodoist\\MyTodoist\\data\\CompletedTasksJSON.txt";
string ProjectsFileXML = "D:\\OOP\\MyTodoist\\MyTodoist\\data\\ProjectsXML.txt";
string TasksFileXML = "D:\\OOP\\MyTodoist\\MyTodoist\\data\\TasksXML.txt";
string CompletedTasksFileXML = "D:\\OOP\\MyTodoist\\MyTodoist\\data\\CompletedTasksXML.txt";

Controller controller = Controller.GetInstance(); //Singleton
Serializer serializer = new Serializer();


//**********************Deserialization JSON****************************//

string jsonString = File.ReadAllText(ProjectsFileJSON);

List<Project>? projects = (List<Project>)serializer.DeserializeJSON<List<Project>>(jsonString);

foreach (var project in projects)
{
    if (projects.IndexOf(project) != 0)
        controller.Add(project.Name, project.Description);
}

jsonString = File.ReadAllText(TasksFileJSON);
string[] subsTasks = jsonString.Split("&&");

foreach (var project in projects)
{

    List<MyClassLib.Models.Task>? tasks = (List<MyClassLib.Models.Task>)serializer.DeserializeJSON<List<MyClassLib.Models.Task>>(subsTasks[projects.IndexOf(project)]);
    foreach (var task in tasks)
    {
        controller.AddTask(task.Name, task.Description, project.Name);
        controller.SetPriority(task.Name, task.Priority, project.Name);
        controller.SetDeadlineTime(task.Name, task.DateTime.Year, task.DateTime.Month,
                                    task.DateTime.Day, task.DateTime.Hour, task.DateTime.Minute,
                                    task.DateTime.Second, project.Name);
    }
}


jsonString = File.ReadAllText(CompletedTasksFileJSON);
string[] subsComplTasks = jsonString.Split("&&");

foreach (var project in projects)
{   
    List<MyClassLib.Models.Task>? tasks = (List<MyClassLib.Models.Task>)serializer.DeserializeJSON<List<MyClassLib.Models.Task>>(subsComplTasks[projects.IndexOf(project)]);
    foreach (var task in tasks)
    {
        controller.AddTask(task.Name, task.Description, project.Name);
        controller.SetPriority(task.Name, task.Priority, project.Name);
        controller.SetDeadlineTime(task.Name, task.DateTime.Year, task.DateTime.Month,
                                    task.DateTime.Day, task.DateTime.Hour, task.DateTime.Minute,
                                    task.DateTime.Second, project.Name);
        controller.CompleteTask(task.Name, project.Name);
    }
}

//**********************Deserialization JSON****************************//


//**********************Deserialization XML****************************//

/*string xmlString = File.ReadAllText(ProjectsFileXML);

List<Project>? projects = serializer.DeserializeXML<List<Project>>(xmlString) as List<Project>;

foreach (var project in projects!)
{
    if (projects.IndexOf(project) != 0)
        controller.Add(project.Name, project.Description); 
}

xmlString = File.ReadAllText(TasksFileXML);
string[] subsTasks = xmlString.Split("&&");

foreach (var project in projects)
{

    List<MyClassLib.Models.Task>? tasks = (List<MyClassLib.Models.Task>)serializer.DeserializeXML<List<MyClassLib.Models.Task>>(subsTasks[projects.IndexOf(project)]);
    foreach (var task in tasks)
    {
        controller.AddTask(task.Name, task.Description, project.Name);
        controller.SetPriority(task.Name, task.Priority, project.Name);
        controller.SetDeadlineTime(task.Name, task.DateTime.Year, task.DateTime.Month,
                                    task.DateTime.Day, task.DateTime.Hour, task.DateTime.Minute,
                                    task.DateTime.Second, project.Name);
    }
}

xmlString = File.ReadAllText(CompletedTasksFileXML);
string[] subsComplTasks = xmlString.Split("&&");

foreach (var project in projects)
{
    List<MyClassLib.Models.Task>? tasks = (List<MyClassLib.Models.Task>)serializer.DeserializeXML<List<MyClassLib.Models.Task>>(subsComplTasks[projects.IndexOf(project)]);
    foreach (var task in tasks)
    {
        controller.AddTask(task.Name, task.Description, project.Name);
        controller.SetPriority(task.Name, task.Priority, project.Name);
        controller.SetDeadlineTime(task.Name, task.DateTime.Year, task.DateTime.Month,
                                    task.DateTime.Day, task.DateTime.Hour, task.DateTime.Minute,
                                    task.DateTime.Second, project.Name);
        controller.CompleteTask(task.Name, project.Name);
    }
}*/

//**********************Deserialization XML****************************//



//********************************MAIN**********************************//

controller.Show();
controller.ShowTasks();
controller.ShowComletedTasks();
//controller.ShowComletedTasks("B");

//controller.Remove("A");
//controller.AddTask("cccc", "vv", "B");
//controller.AddTask("1", "1");
//controller.CompleteTask("w");
//controller.AddTask("b", "b", "B");
//controller.CompleteTask("b", "B");
//controller.Remove("B");

//********************************MAIN**********************************//
 



//**********************Serialization JSON****************************//

jsonString = serializer.SerializeJSON(controller.container.GetList());

File.WriteAllText(ProjectsFileJSON, jsonString);
jsonString = "";

foreach (var item in controller.container.GetList())
{
    jsonString += serializer.SerializeJSON(item.GetTasks()) + "&&";
}

jsonString = jsonString.Remove(jsonString.Length - 2, 2);
File.WriteAllText(TasksFileJSON, jsonString);
jsonString = "";

foreach (var item in controller.container.GetList())
{
    jsonString += serializer.SerializeJSON(item.GetCompletedTasks()) + "&&";
}


jsonString = jsonString.Remove(jsonString.Length - 2, 2);
File.WriteAllText(CompletedTasksFileJSON, jsonString);

//**********************Serialization JSON****************************//



//**********************Serialization XML****************************//

File.WriteAllText(ProjectsFileXML, "");

using (FileStream fs = new FileStream(ProjectsFileXML, FileMode.OpenOrCreate))
{
    serializer.SerializeXML<List<Project>>(fs, controller.container.GetList());
    fs.Close();
  
}

byte[] buffer = Encoding.Default.GetBytes("&&");
File.WriteAllText(TasksFileXML, "");

using (FileStream fs = new FileStream(TasksFileXML, FileMode.OpenOrCreate))
{
    foreach (var item in controller.container.GetList())
    {
        serializer.SerializeXML<List<MyClassLib.Models.Task>>(fs, item.GetTasks());

        if (controller.container.GetList().IndexOf(item) != controller.container.GetList().Count - 1)
            fs.Write(buffer, 0, buffer.Length);
    }

}

File.WriteAllText(CompletedTasksFileXML, "");

using (FileStream fs = new FileStream(CompletedTasksFileXML, FileMode.OpenOrCreate))
{
    foreach (var item in controller.container.GetList())
    {
        serializer.SerializeXML<List<MyClassLib.Models.Task>>(fs, item.GetCompletedTasks());

        if (controller.container.GetList().IndexOf(item) != controller.container.GetList().Count - 1)
            fs.Write(buffer, 0, buffer.Length);
    }

}

//**********************Serialization XML****************************//
