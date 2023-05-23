using InterFace;
using MyClassLib.Main;

namespace Interface
{
    public partial class ProjectDetails : Form
    {
        public Controller _controller;

        private MainForm _mainForm;

        public string selectedTaskName;

        public ProjectDetails(Controller controller, MainForm mainForm)
        {
            InitializeComponent();
            listViewTasks.MouseDown += ListViewTasks_MouseDown;
            _controller = controller;
            _mainForm = mainForm;
            _mainForm.nameLabel.Text = $"Tasks in '{_mainForm.selectedProjectName}'";
            listViewTasks.Columns.Add("Name:", 500, HorizontalAlignment.Left);
            listViewTasks.View = View.Details;
            sortCheckedListBox.Hide();
            sortCheckedListBox.CheckOnClick = true;

            if (_mainForm.selectedProjectName == "Others")
            {
                deletePB.Enabled = false;
                helperPanel.Cursor = Cursors.No;
                changePB.Enabled = false;
            }

            showCTPB.Image = image1;

        }

        Image image1 = Properties.Resources.showST;
        Image image2 = Properties.Resources.hideST;


        private void GoBack()
        {
            _mainForm.nameLabel.Text = "My Projects";

            this.Close();

            _mainForm.MainPanel.Controls.Add(_mainForm.listViewProjects);

            _mainForm.listViewProjects.Items.Clear();

            foreach (var item in _mainForm.controller.container.GetList())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Name;
                listViewItem.SubItems.Add(item.Description);
                _mainForm.listViewProjects.Items.Add(listViewItem);
            }
            _mainForm.addTaskButton.Visible = true;
            _mainForm.addProjectPB.Visible = true;

        }

        public void GotoPage(object Form)
        {
            if (_mainForm.MainPanel.Controls.Count > 0)
                _mainForm.MainPanel.Controls.RemoveAt(0);
            Form fm = Form as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            _mainForm.MainPanel.Controls.Add(fm);
            _mainForm.MainPanel.Tag = fm;
            fm.Show();
        }

        private void ListViewTasks_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                ListViewItem clickedItem = listViewTasks.GetItemAt(e.X, e.Y);


                if (clickedItem != null)
                {
                    selectedTaskName = clickedItem.Text;

                    TaskDetails taskDetails = new TaskDetails(_controller, this, _mainForm);
                    GotoPage(taskDetails);
                    _mainForm.nameLabel.Text = $"Task {selectedTaskName}";

                }
            }
        }

        private void sortCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            for (int i = 0; i < sortCheckedListBox.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    sortCheckedListBox.SetItemChecked(i, false);
                }

            }

            if (sortCheckedListBox.SelectedIndex == 0)
                _controller.SortByName(_mainForm.selectedProjectName);
            else
                _controller.SortByPriority(_mainForm.selectedProjectName);
            sortCheckedListBox.Hide();

            // ProjectDetails projectDetails = new ProjectDetails(_controller, _mainForm);
            // projectDetails.listViewTasks.CheckBoxes = true;
            listViewTasks.Items.Clear();
            foreach (var item in _controller.container.GetTasksList(_mainForm.selectedProjectName))
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Name;
                listViewTasks.Items.Add(listViewItem);
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

        }

        private void backPB_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color lineColor = backPB.Tag?.ToString() == "Hovered" ? Color.Black : Color.FromArgb(126, 123, 122);

            Pen pen = new Pen(lineColor, 2);
            g.DrawLine(pen, 0, 12, 12, 0);
            g.DrawLine(pen, 0, 12, 12, 24);

        }

        private void listViewTasks_MouseMove(object sender, MouseEventArgs e)
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

        private void ProjectDetails_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen MainPen = new Pen(Color.FromArgb(222, 220, 220), 4);
            g.DrawLine(MainPen, 110, 0, 110, 400);
        }

        private void backPB_MouseEnter(object sender, EventArgs e)
        {
            backPB.Tag = "Hovered";
            backPB.Invalidate();
        }

        private void backPB_MouseLeave(object sender, EventArgs e)
        {
            backPB.Tag = null;
            backPB.Invalidate();
        }

        private void backPB_Click(object sender, EventArgs e)
        {
            GoBack();

        }

        private void ChangePB_MouseLeave(object sender, EventArgs e)
        {
            changePB.Size = new Size(32, 32);
        }

        private void ChangePB_MouseEnter(object sender, EventArgs e)
        {
            changePB.Size = new Size(36, 36);
        }

        private void SortPB_MouseLeave(object sender, EventArgs e)
        {
            sortPB.Size = new Size(32, 32);
        }

        private void SortPB_MouseEnter(object sender, EventArgs e)
        {
            sortPB.Size = new Size(36, 36);
        }

        private void DeletePB_MouseEnter(object sender, EventArgs e)
        {
            deletePB.Size = new Size(36, 36);
        }

        private void DeletePB_MouseLeave(object sender, EventArgs e)
        {
            deletePB.Size = new Size(32, 32);
        }

        private void AddPB_MouseLeave(object sender, EventArgs e)
        {
            addPB.Size = new Size(32, 32);
        }

        private void AddPB_MouseEnter(object sender, EventArgs e)
        {
            addPB.Size = new Size(36, 36);
        }

        private void ShowCTPB_MouseEnter(object sender, EventArgs e)
        {
            showCTPB.Size = new Size(36, 36);
        }

        private void ShowCTPB_MouseLeave(object sender, EventArgs e)
        {
            showCTPB.Size = new Size(32, 32);
        }

        private void showCTPB_Click(object sender, EventArgs e)
        {
            int count = _controller.container.GetTasksList(_mainForm.selectedProjectName).Count;
            if (showCTPB.Image.Equals(image1))
            {
                foreach (var item in _controller.container.GetCompletedTasksList(_mainForm.selectedProjectName))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = item.Name;
                    listViewTasks.Items.Add(listViewItem);
                    listViewItem.Font = new Font(listViewItem.Font, FontStyle.Strikeout);
                }

                showCTPB.Image = image2;
            }

            else
            {
                for (int i = count; i < count + _controller.container.GetCompletedTasksList(_mainForm.selectedProjectName).Count; i++)
                {
                    listViewTasks.Items.RemoveAt(count);
                }

                showCTPB.Image = image1;

            }

        }

        private void deletePB_Click(object sender, EventArgs e)
        {
            _controller.Remove(_mainForm.selectedProjectName);

            _mainForm.listViewProjects.Items.Clear();

            foreach (var item in _mainForm.controller.container.GetList())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Name;
                listViewItem.SubItems.Add(item.Description);
                _mainForm.listViewProjects.Items.Add(listViewItem);
            }

            GoBack();
        }

        private void changePB_Click(object sender, EventArgs e)
        {
            EditProject editProjectForm = new EditProject(_controller, _mainForm);
            GotoPage(editProjectForm);
        }

        private void addPB_Click(object sender, EventArgs e)
        {
            AddTask addProject = new AddTask(_controller, _mainForm);
            GotoPage(addProject);
        }

        private void sortPB_Click(object sender, EventArgs e)
        {
            showCTPB.Image = image1;
            if (_controller.container.GetTasksList(_mainForm.selectedProjectName).Count == 0)
                MessageBox.Show("No tasks to sort!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                sortCheckedListBox.Items.Clear();
                sortCheckedListBox.Items.Add($"By name");
                sortCheckedListBox.Items.Add($"By priority");
                sortCheckedListBox.Show();
            }
        }

        private void SortCheckedListBox_MouseLeave(object sender, EventArgs e)
        {
            sortCheckedListBox.Hide();
        }


    }
}
