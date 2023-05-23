using InterFace;
using MyClassLib.Main;
using Task = MyClassLib.Models.Task;
using Timer = System.Windows.Forms.Timer;

namespace Interface
{
    public partial class TaskDetails : Form
    {
        public TaskDetails(Controller controller, ProjectDetails projectDetails, MainForm mainForm)
        {
            InitializeComponent();
            _controller = controller;
            _mainForm = mainForm;
            _projectDetails = projectDetails;
            task = _controller.container.FindTask(_projectDetails.selectedTaskName, _mainForm.selectedProjectName);

            addTimeButton.FlatStyle = FlatStyle.Flat;
            addTimeButton.FlatAppearance.BorderSize = 1;
            addTimeButton.BackColor = Color.White;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.FlatAppearance.BorderSize = 1;
            saveButton.BackColor = Color.White;


            if (task == null)
            {
                foreach (var item in _controller.container.GetCompletedTasksList(_mainForm.selectedProjectName))
                {
                    if (_projectDetails.selectedTaskName == item.Name)
                    {
                        task = item;

                        deletePB.Enabled = false;
                        helperPanel.Cursor = Cursors.No;

                        changePB.Enabled = false;

                        completePB.Enabled = false;

                        notifyPB.Enabled = false;

                        priorityPB.Enabled = false;

                        deadlinePB.Enabled = false;
                    }

                }

            }

            descriptionLabel.Text = $"Description: {task.Description}";
            timeLabel.Text = $"Deadline at: {task.DateTime.ToString()}";
            priorityLabel.Text = $"Priority: {task.Priority}";
            priorityCheckedListBox.Hide();
            priorityCheckedListBox.CheckOnClick = true;
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.MinDate = DateTime.Now;
            addTimeButton.Hide();
            dateTimePicker.Hide();
            saveButton.Hide();
            //  notifyButton.Hide();
        }

        Controller _controller;
        ProjectDetails _projectDetails;
        MainForm _mainForm;
        Task task;
        int taskPriority;

        private void GoBack()
        {
            ProjectDetails projectDetails = new ProjectDetails(_controller, _mainForm);
            // projectDetails.listViewTasks.CheckBoxes = true;

            foreach (var item in _controller.container.GetTasksList(_mainForm.selectedProjectName))
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

            _mainForm.GotoPage(projectDetails);
            _mainForm.nameLabel.Text = $"Tasks in '{_mainForm.selectedProjectName}'";
        }


        private void priorityCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            for (int i = 0; i < priorityCheckedListBox.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    priorityCheckedListBox.SetItemChecked(i, false);
                }

            }

            taskPriority = priorityCheckedListBox.SelectedIndex + 1;
            _controller.SetPriority(task.Name, taskPriority, _mainForm.selectedProjectName);

            priorityCheckedListBox.Hide();
            priorityLabel.Text = $"Priority {task.Priority}";

        }

        private void priorityCheckedListBox_MouseLeave(object sender, EventArgs e)
        {
            priorityCheckedListBox.Hide();
        }


        private void addTimeButton_Click(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Time;

        }



        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Format == DateTimePickerFormat.Short)
                _controller.SetDeadlineTime(_projectDetails.selectedTaskName, dateTimePicker.Value.Year,
                                            dateTimePicker.Value.Month, dateTimePicker.Value.Day,
                                            0, 0, 0, _mainForm.selectedProjectName);
            else
                _controller.SetDeadlineTime(_projectDetails.selectedTaskName, dateTimePicker.Value.Year,
                                            dateTimePicker.Value.Month, dateTimePicker.Value.Day,
                                            dateTimePicker.Value.Hour, dateTimePicker.Value.Minute,
                                            dateTimePicker.Value.Second, _mainForm.selectedProjectName);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            timeLabel.Text = $"Deadline at: {task.DateTime.ToString()}";
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Hide();
            addTimeButton.Hide();
            saveButton.Hide();

            deletePB.Enabled = true;
            changePB.Enabled = true;
            completePB.Enabled = true;
            notifyPB.Enabled = true;
            priorityPB.Enabled = true;
            deadlinePB.Enabled = true;
            helperPanel.Cursor = Cursors.Default;
        }




        private void backPB_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color lineColor = backPB.Tag?.ToString() == "Hovered" ? Color.Black : Color.FromArgb(126, 123, 122);

            Pen pen = new Pen(lineColor, 2);
            g.DrawLine(pen, 0, 12, 12, 0);
            g.DrawLine(pen, 0, 12, 12, 24);

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

        private void deletePB_Click(object sender, EventArgs e)
        {
            _controller.RemoveTask(task.Name, _mainForm.selectedProjectName);
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

        private void DeletePB_MouseEnter(object sender, EventArgs e)
        {
            deletePB.Size = new Size(36, 36);
        }

        private void DeletePB_MouseLeave(object sender, EventArgs e)
        {
            deletePB.Size = new Size(32, 32);
        }

        private void changePB_Click(object sender, EventArgs e)
        {
            EditTask editTask = new EditTask(_controller, _mainForm, _projectDetails, this);
            _mainForm.GotoPage(editTask);
        }

        private void completePB_Click(object sender, EventArgs e)
        {
            _controller.CompleteTask(task.Name, _mainForm.selectedProjectName);
            GoBack();
        }

        private void completePB_MouseEnter(object sender, EventArgs e)
        {
            completePB.Size = new Size(36, 36);
            completePB.Image = Properties.Resources.complete1;
        }

        private void completePB_MouseLeave(object sender, EventArgs e)
        {
            completePB.Size = new Size(32, 32);
            completePB.Image = Properties.Resources.complete;

        }

        private void priorityPB_Click(object sender, EventArgs e)
        {
            priorityCheckedListBox.Items.Clear();

            for (int i = 1; i < 5; i++)
            {
                priorityCheckedListBox.Items.Add($"Priority {i}");

            }
            priorityCheckedListBox.Show();
        }

        private void priorityPB_MouseEnter(object sender, EventArgs e)
        {
            priorityPB.Size = new Size(36, 36);
        }

        private void priorityPB_MouseLeave(object sender, EventArgs e)
        {
            priorityPB.Size = new Size(32, 32);
        }

        private void deadlinePB_Click(object sender, EventArgs e)
        {

            addTimeButton.Show();
            saveButton.Show();
            dateTimePicker.Show();

            deletePB.Enabled = false;
            helperPanel.Cursor = Cursors.No;

            changePB.Enabled = false;

            completePB.Enabled = false;

            notifyPB.Enabled = false;

            priorityPB.Enabled = false;

            deadlinePB.Enabled = false;


        }

        private void TaskDetails_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen MainPen = new Pen(Color.FromArgb(222, 220, 220), 4);
            g.DrawLine(MainPen, 110, 0, 110, 400);
            g.DrawLine(MainPen, 110, 35, 650, 35);
            g.DrawLine(MainPen, 110, 78, 650, 78);


        }

        private void deadlinePB_MouseEnter(object sender, EventArgs e)
        {
            deadlinePB.Size = new Size(36, 36);
        }

        private void deadlinePB_MouseLeave(object sender, EventArgs e)
        {
            deadlinePB.Size = new Size(32, 32);
        }

        private void notifyPB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_controller.GetNotify(task.Name, _mainForm.selectedProjectName), "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void notifyPB_MouseEnter(object sender, EventArgs e)
        {
            notifyPB.Size = new Size(36, 36);
        }

        private void notifyPB_MouseLeave(object sender, EventArgs e)
        {
            notifyPB.Size = new Size(32, 32);
        }

        private Timer colorTimer;
        private Color startColor;
        private Color endColor;
        private int steps;
        private int currentStep;

        private void addTimeButton_MouseEnter(object sender, EventArgs e)
        {
            startColor = Color.White;
            endColor = Color.Black;

            steps = 10;
            currentStep = 0;

            colorTimer = new Timer();
            colorTimer.Interval = 15;
            colorTimer.Tick += ColorTimer_Tick;
            colorTimer.Start();
        }

        private void addTimeButton_MouseLeave(object sender, EventArgs e)
        {
            colorTimer.Stop();
            colorTimer.Dispose();

            addTimeButton.BackColor = Color.White;
            addTimeButton.ForeColor = Color.Black;
        }


        private void saveButton_MouseEnter(object sender, EventArgs e)
        {
            startColor = Color.White;
            endColor = Color.Black;

            steps = 10;
            currentStep = 0;

            colorTimer = new Timer();
            colorTimer.Interval = 15;
            colorTimer.Tick += ColorTimer_Tick1;
            colorTimer.Start();
        }

        private void saveButton_MouseLeave(object sender, EventArgs e)
        {
            colorTimer.Stop();
            colorTimer.Dispose();

            saveButton.BackColor = Color.White;
            saveButton.ForeColor = Color.Black;
        }

        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            float stepSize = 1f / steps;
            float factor = currentStep * stepSize;
            Color currentColor = InterpolateColors(startColor, endColor, factor);

            addTimeButton.BackColor = currentColor;
            addTimeButton.ForeColor = InvertColor(currentColor);

            currentStep++;

            if (currentStep > steps)
            {
                colorTimer.Stop();
                colorTimer.Dispose();
            }
        }

        private void ColorTimer_Tick1(object sender, EventArgs e)
        {
            float stepSize = 1f / steps;
            float factor = currentStep * stepSize;
            Color currentColor = InterpolateColors(startColor, endColor, factor);

            saveButton.BackColor = currentColor;
            saveButton.ForeColor = InvertColor(currentColor);

            currentStep++;

            if (currentStep > steps)
            {
                colorTimer.Stop();
                colorTimer.Dispose();
            }
        }

        private Color InterpolateColors(Color startColor, Color endColor, float factor)
        {
            int r = (int)(startColor.R + factor * (endColor.R - startColor.R));
            int g = (int)(startColor.G + factor * (endColor.G - startColor.G));
            int b = (int)(startColor.B + factor * (endColor.B - startColor.B));
            return Color.FromArgb(r, g, b);
        }

        private Color InvertColor(Color color)
        {
            int r = 255 - color.R;
            int g = 255 - color.G;
            int b = 255 - color.B;
            return Color.FromArgb(r, g, b);
        }


    }
}
