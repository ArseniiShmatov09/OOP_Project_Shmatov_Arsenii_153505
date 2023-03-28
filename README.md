

This project is a task management system that allows users to create projects, include tasks in them, receive reminders, and generate reports on completed tasks.

The main functional system includes:

Creating projects with a given name and description
Adding tasks to projects with a name, description, and start and end dates
Setting reminders for tasks with the title, description, date and time, and status (active or inactive)
Search for tasks in a project by name and start and end dates
Exporting a list of project tasks or all projects to a CSV file
Deleting projects and tasks from the list
Calculation of a large number of completed tasks in a project
Exporting a report on completed project tasks to a CSV or PDF file
Thus, the task management system provides an opportunity to easily organize and perform tasks within various projects, as well as receive reports on the work performed.




Here you can see that the User class interacts with the Project, TaskManager and Reminder classes through the CreateProject, AssignTask, GetTaskList methods, etc. The Project class interacts with the TaskManager class through the addTask, RemoveTask, GetTaskList methods, etc. The TaskManager class interacts with the Project, Report and Task classes through the addProject, RemoveProject, GetProjects, FindTasks, ExportCSV methods, ExportAllCSV, etc. The Reminder class interacts with the Task class through the methods setTitle, SetDescription, SetDateTime and setStatus. The Report class interacts with the Project and Task classes via the CalculateTotalCompletedTasks, ExportCSV, and ExportPDF methods.







Class User:

CreateProject(name: string, description: string): creates a new project with the specified name and description and adds it to the user's project list.
AssignTask(projectName: string, task: Task): adds a task to a project with the specified name.
GetTaskList(projectName: string): returns a list of tasks in the project with the specified name.

class Project:

AddTask(task: Task): adds a task to the project's task list.
RemoveTask(task: Task): Removes a task from the project's task list.
GetTaskList(): Returns a list of tasks in the project.
GetProject(): Returns information about the project (name and description).

class TaskManager:

AddProject(project: Project): adds a project to the list of projects.
RemoveProject(project: Project): Removes a project from the list of projects.
GetProjects(): returns a list of projects.
FindTasks(projectName: string, startDate: DateTime, endDate: DateTime): returns a list of tasks in the project with the specified name and in the specified date range.
ExportCSV(projectName: string): exports the list of project tasks to a CSV file.
ExportAllCSV(): Exports the task lists of all projects to a CSV file.

Class Reminder:

SetTitle(title: string): sets the reminder title.
SetDescription(description: string): sets the reminder description.
SetDateTime(dateTime: DateTime): sets the date and time of the reminder.
setStatus(status: bool): Sets the status (active or inactive) of the reminder.

class Report:

CalculateCompletedTasks(projectName: string): calculates the total number of completed tasks in a project with a given name.
ExportCSV(projectName: string): exports a report on completed project tasks to a CSV file.
ExportPDF(projectName: string): exports a report on completed project tasks to a PDF file.

class Task :

getName(): returns the name of the task.
getDescription(): returns a description of the task.
GetStartDate(): Returns the start date of the task.
GetEndDate(): Returns the completion date of the task.
GetStatus(): returns the status of the task (completed or not).

