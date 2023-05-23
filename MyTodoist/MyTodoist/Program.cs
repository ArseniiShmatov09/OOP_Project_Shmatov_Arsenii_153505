using LiteDB;
using MyClassLib.Main;
using MyClassLib.Models;
using MySerializer;
using System.Text;


string ProjectsFileJSON = "D:\\OOP\\MyTodoist\\MyTodoist\\data\\ProjectsJSON.json";
string TasksFileJSON = "D:\\OOP\\MyTodoist\\MyTodoist\\data\\TasksJSON.json";
string CompletedTasksFileJSON = "D:\\OOP\\MyTodoist\\MyTodoist\\data\\CompletedTasksJSON.json";
string DataFileXML = "D:\\OOP\\MyTodoist\\MyTodoist\\data\\DataXML.xml";


Controller controller = Controller.GetInstance(); //Singleton
Serializer serializer = new Serializer();


//**********************Deserialization JSON****************************//

string jsonString = File.ReadAllText(ProjectsFileJSON);

/*List<Project>? projects = (List<Project>)serializer.DeserializeJSON<List<Project>>(jsonString);

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
}*/

//**********************Deserialization JSON****************************//


//**********************Deserialization XML****************************//

/*string xmlString = File.ReadAllText(DataFileXML);

List<Project>? projects = serializer.DeserializeXML<List<Project>>(xmlString) as List<Project>;

foreach (var project in projects!)
{
    if (projects.IndexOf(project) != 0)
        controller.Add(project.Name, project.Description);
  
    var tasks = project.GetTasks();
    foreach (var task in tasks)
    {
        controller.AddTask(task.Name, task.Description, project.Name);
        controller.SetPriority(task.Name, task.Priority, project.Name);
        controller.SetDeadlineTime(task.Name, task.DateTime.Year, task.DateTime.Month,
                                    task.DateTime.Day, task.DateTime.Hour, task.DateTime.Minute,
                                    task.DateTime.Second, project.Name);
    }

    var completedTasks = project.GetCompletedTasks();
    foreach (var task in completedTasks)
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

//**********************Getting Data from DBLite****************************//

using (var db = new LiteDatabase("Data.db"))
{

    var projectsDb = db.GetCollection<Project>("projects");
    var projects = projectsDb.FindAll().ToList();
   
    foreach (var project in projects)
    {
        if (projects.IndexOf(project) != 0)
            controller.Add(project.Name, project.Description);
        
        var tasksDb = db.GetCollection<MyClassLib.Models.Task>("tasks" + project.Name);
        var tasks = tasksDb.FindAll().ToList();

        foreach (var task in tasks)
        {
            controller.AddTask(task.Name, task.Description, project.Name);
            controller.SetPriority(task.Name, task.Priority, project.Name);
            controller.SetDeadlineTime(task.Name, task.DateTime.Year, task.DateTime.Month,
                                        task.DateTime.Day, task.DateTime.Hour, task.DateTime.Minute,
                                        task.DateTime.Second, project.Name);
        }

        var completedTasksDb = db.GetCollection<MyClassLib.Models.Task>("CompletedTasks" + project.Name);
        var completedTasks = completedTasksDb.FindAll().ToList();

        foreach (var task in completedTasks)
        {
            controller.AddTask(task.Name, task.Description, project.Name);
            controller.SetPriority(task.Name, task.Priority, project.Name);
            controller.SetDeadlineTime(task.Name, task.DateTime.Year, task.DateTime.Month,
                                        task.DateTime.Day, task.DateTime.Hour, task.DateTime.Minute,
                                        task.DateTime.Second, project.Name);
            controller.CompleteTask(task.Name, project.Name);
        }

    }

}

//**********************Getting Data from DBLite****************************//









//********************************MAIN**********************************//


/*controller.Show();
//controller.Remove("A");
controller.AddTask("1", "1", "A");

controller.Add("A", "A");

controller.ShowTasks("A");
controller.ShowCompletedTasks("A");
*/

//controller.Add("A", "A");

controller.Show();

//********************************MAIN**********************************//




//**********************Serialization JSON****************************//

/*jsonString = serializer.SerializeJSON(controller.container.GetList());

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
*/

//**********************Serialization JSON****************************//



//**********************Serialization XML****************************//

/*File.WriteAllText(DataFileXML, "");

using (FileStream fs = new FileStream(DataFileXML, FileMode.OpenOrCreate))
{
    serializer.SerializeXML<List<Project>>(fs, controller.container.GetList());
    fs.Close();
  
}*/

//**********************Serialization XML****************************//


//**********************Saving Data to DBLite****************************//

using (var db = new LiteDatabase("Data.db"))
{
    var projectsDb = db.GetCollection<Project>("projects");

    db.DropCollection("projects");

    projectsDb.Insert(controller.container.GetList());

    var projects = projectsDb.FindAll().ToList();

    foreach (var project in projects)
    {
        var tasksDb = db.GetCollection<MyClassLib.Models.Task>("tasks" + project.Name);
        db.DropCollection("tasks" + project.Name);
        tasksDb.Insert(controller.container.GetTasksList(project.Name));

        var completedTasksDb = db.GetCollection<MyClassLib.Models.Task>("CompletedTasks" + project.Name);
        db.DropCollection("CompletedTasks" + project.Name);
        completedTasksDb.Insert(controller.container.GetCompletedTasksList(project.Name));
    }
}

//**********************Saving Data to DBLite****************************//
