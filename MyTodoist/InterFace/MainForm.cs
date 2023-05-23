using Interface;
using LiteDB;
using MyClassLib.Main;
using MyClassLib.Models;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace InterFace
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //**********************Getting Data from DBLite****************************//

            using (var db = new LiteDatabase("DataBaseARS.db"))
            {

                var projectsDb = db.GetCollection<Project>("projects");
                var projects = projectsDb.FindAll().ToList();

                foreach (var project in projects)
                {
                    if (projects.IndexOf(project) != 0)
                        controller.Add(project.Name, project.Description);
                    string namehelp = project.Name.Replace(" ", "");
                    var tasksDb = db.GetCollection<MyClassLib.Models.Task>("tasks" + namehelp);
                    var tasks = tasksDb.FindAll().ToList();

                    foreach (var task in tasks)
                    {
                        controller.AddTask(task.Name, task.Description, project.Name);
                        controller.SetPriority(task.Name, task.Priority, project.Name);
                        controller.SetDeadlineTime(task.Name, task.DateTime.Year, task.DateTime.Month,
                                                    task.DateTime.Day, task.DateTime.Hour, task.DateTime.Minute,
                                                    task.DateTime.Second, project.Name);
                    }


                    var completedTasksDb = db.GetCollection<MyClassLib.Models.Task>("CompletedTasks" + namehelp);
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

            InitializeComponent();


            listViewProjects.MouseDown += ListViewProjects_MouseDown;
            listViewProjects.MouseMove += listViewProjects_MouseMove;
            listViewProjects.View = System.Windows.Forms.View.Details;

            listViewProjects.Columns.Add("Name", 210, HorizontalAlignment.Left);
            listViewProjects.Columns.Add("Description", 440, HorizontalAlignment.Center);

            nameLabel.Text = $"My Projects";
            addTaskButton.FlatStyle = FlatStyle.Flat; // Установка стиля кнопки на Flat
            addTaskButton.FlatAppearance.BorderSize = 0;
            addTaskButton.FlatAppearance.BorderColor = Color.Black;
            addTaskButton.Image = image1;

            listViewProjects.Items.Clear();

            foreach (var item in controller.container.GetList())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Name;
                listViewItem.SubItems.Add(item.Description);
                listViewProjects.Items.Add(listViewItem);
            }

        }


        Image image1 = Interface.Properties.Resources.addTask70;
        Image image2 = Interface.Properties.Resources.addTask;

        public int buttonCount = 0;
        public string selectedProjectName = "";

        public Controller controller = Controller.GetInstance();
        public void GotoPage(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form fm = Form as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(fm);
            this.MainPanel.Tag = fm;
            fm.Show();
        }

        private void ListViewProjects_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                ListViewItem clickedItem = listViewProjects.GetItemAt(e.X, e.Y);


                if (clickedItem != null)
                {
                    selectedProjectName = clickedItem.Text;

                    addProjectPB.Visible = false;
                    addTaskButton.Visible = false;

                    ProjectDetails projectDetails = new ProjectDetails(controller, this);


                    foreach (var item in controller.container.GetTasksList(selectedProjectName))
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Text = item.Name;
                        projectDetails.listViewTasks.Items.Add(listViewItem);
                        //  listViewItem.Checked = true;
                        if (item.Priority == 1)
                            listViewItem.ForeColor = Color.DarkRed;
                        else if (item.Priority == 2)
                            listViewItem.ForeColor = Color.DarkGreen;
                        else if (item.Priority == 3)
                            listViewItem.ForeColor = Color.DarkBlue;
                        else
                            listViewItem.ForeColor = Color.Black;
                    }

                    GotoPage(projectDetails);

                }

            }
        }
        private void listViewProjects_MouseMove(object sender, MouseEventArgs e)
        {
            ListView listView = (ListView)sender;
            ListViewItem item = listView.GetItemAt(e.X, e.Y);
            if (item != null)
            {
                listView.Cursor = Cursors.Hand;

            }
            else
            {
                listView.Cursor = Cursors.Default;

            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            int formWidth = this.Width;
            int formHeight = this.Height;

            int x = (screenWidth - formWidth) / 2;
            int y = (screenHeight - formHeight) / 2;

            this.Location = new Point(x, y);
        }
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            selectedProjectName = "Others";
            AddTask addTask = new AddTask(controller, this);
            GotoPage(addTask);
            addTaskButton.Visible = false;
            addProjectPB.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            //**********************Saving Data to DBLite****************************//

            using (var db = new LiteDatabase("DataBaseARS.db"))
            {
                var projectsDb = db.GetCollection<Project>("projects");

                db.DropCollection("projects");

                projectsDb.Insert(controller.container.GetList());

                var projects = projectsDb.FindAll().ToList();

                foreach (var project in projects)
                {
                    string namehelp = project.Name.Replace(" ", "");
                    var tasksDb = db.GetCollection<MyClassLib.Models.Task>("tasks" + namehelp);
                    db.DropCollection("tasks" + project.Name);
                    tasksDb.Insert(controller.container.GetTasksList(project.Name));

                    var completedTasksDb = db.GetCollection<MyClassLib.Models.Task>("CompletedTasks" + namehelp);
                    db.DropCollection("CompletedTasks" + project.Name);
                    completedTasksDb.Insert(controller.container.GetCompletedTasksList(project.Name));
                }
            }

            //**********************Saving Data to DBLite****************************//

            Application.Exit();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(199, 197, 197);
        }

        private void hide_MouseLeave(object sender, EventArgs e)
        {
            hide.BackColor = Color.FromArgb(222, 220, 220);
        }

        private void hide_MouseEnter(object sender, EventArgs e)
        {
            hide.BackColor = Color.FromArgb(199, 197, 197);
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(222, 220, 220);
        }
        private void hide_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //нажатие ЛКМ в зоне приложения
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void addTaskButton_Paint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, button.Width, button.Height); // Создаем эллипсовидный путь

                button.Region = new Region(path);

            }
        }


        private void AddTaskButton_MouseEnter(object sender, EventArgs e)
        {
            addTaskButton.Size = new Size(50, 50);
            addTaskButton.Image = image2;
            Point point = addTaskButton.Location;

            addTaskButton.Location = new Point(point.X - 5, point.Y - 5);

        }

        private void AddTaskButton_MouseLeave(object sender, EventArgs e)
        {
            addTaskButton.Size = new Size(40, 40);
            addTaskButton.Image = image1;
            Point point = addTaskButton.Location;

            addTaskButton.Location = new Point(point.X + 5, point.Y + 5);
        }




        private void AddProjectPB_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color lineColor = addProjectPB.Tag?.ToString() == "Hovered" ? Color.FromArgb(126, 123, 122) : Color.FromArgb(169, 167, 167);

            Pen pen = new Pen(lineColor, 2);

            g.DrawLine(pen, 0, 10, 20, 10);
            g.DrawLine(pen, 10, 0, 10, 20);
        }

        private void AddProjectPB_MouseEnter(object sender, EventArgs e)
        {
            addProjectPB.Tag = "Hovered";
            addProjectPB.Invalidate();
        }

        private void AddProjectPB_MouseLeave(object sender, EventArgs e)
        {
            addProjectPB.Tag = null;
            addProjectPB.Invalidate();
        }

        private void addProjectPB_Click(object sender, EventArgs e)
        {
            AddProject addProjectForm = new AddProject(controller, this);
            GotoPage(addProjectForm);
            addProjectPB.Visible = false;
            addTaskButton.Visible = false;

        }
    }
}