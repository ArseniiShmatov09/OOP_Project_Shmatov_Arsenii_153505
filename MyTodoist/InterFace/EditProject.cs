using InterFace;
using MyClassLib.Main;
using System.Text.RegularExpressions;
using Timer = System.Windows.Forms.Timer;


namespace Interface
{
    public partial class EditProject : Form
    {

        public Controller _controller;

        private MainForm _mainForm;

        public EditProject(Controller controller, MainForm mainForm)
        {
            InitializeComponent();
            _controller = controller;
            _mainForm = mainForm;
            _mainForm.nameLabel.Text = "";
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.FlatAppearance.BorderSize = 1;
            editButton.BackColor = Color.White;

        }

        private Timer colorTimer;
        private Color startColor;
        private Color endColor;
        private int steps;
        private int currentStep;

        private void editButton_MouseEnter(object sender, EventArgs e)
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

        private void editButton_MouseLeave(object sender, EventArgs e)
        {
            colorTimer.Stop();
            colorTimer.Dispose();

            editButton.BackColor = Color.White;
            editButton.ForeColor = Color.Black;
        }

        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            float stepSize = 1f / steps;
            float factor = currentStep * stepSize;
            Color currentColor = InterpolateColors(startColor, endColor, factor);

            editButton.BackColor = currentColor;
            editButton.ForeColor = InvertColor(currentColor);

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

        private void editButton_Click(object sender, EventArgs e)
        {
            int buff = 0;

            Regex regex = new Regex(@"[A-z-0-9]+");
            MatchCollection matchCollectionProjects = regex.Matches(NameEnter.Text);

            string result = "";
            for (int i = 0; i < matchCollectionProjects.Count; i++)
                result += matchCollectionProjects[i].Value + " ";

            if (result.Length == 0) result = "@";

            else
                result = result.Remove(result.Length - 1);

            if (NameEnter.Text == "Enter new name")
            {
                MessageBox.Show("Fill the empty fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NameEnter.Text = "Enter new name";
                NameEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
                NameEnter.ForeColor = Color.Silver;
            }

            else if (DescriptionEnter.Text == "Enter new description")
            {
                MessageBox.Show("Fill the empty fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DescriptionEnter.Text = "Enter new description";
                DescriptionEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
                DescriptionEnter.ForeColor = Color.Silver;
            }

            else if (NameEnter.Text.Length > 20)
            {
                MessageBox.Show("Length of name should be less than 20 symbols!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NameEnter.Text = "Enter new name";
                NameEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
                NameEnter.ForeColor = Color.Silver;
            }

            else if (DescriptionEnter.Text.Length > 40)
            {
                MessageBox.Show("Length of description should be less than 40 symbols!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DescriptionEnter.Text = "Enter new description";
                DescriptionEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
                DescriptionEnter.ForeColor = Color.Silver;
            }

            else if (NameEnter.Text != result)
            {
                MessageBox.Show("Name of project should contain only A-z or 0-9 symbols!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NameEnter.Text = "Enter new name";
                NameEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
                NameEnter.ForeColor = Color.Silver;
            }

            else
            {
                foreach (var item in _mainForm.controller.container.GetList())
                {
                    if (item.Name == NameEnter.Text && NameEnter.Text != _mainForm.selectedProjectName)
                    {
                        buff++;
                    }
                }

                if (buff != 0)
                {
                    MessageBox.Show("Project with the same name already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NameEnter.Text = "Enter new name";
                    NameEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
                    NameEnter.ForeColor = Color.Silver;
                }

                else
                {
                    _controller.Change(_mainForm.selectedProjectName, NameEnter.Text, DescriptionEnter.Text);
                    _mainForm.selectedProjectName = NameEnter.Text;
                    GoBack();
                }


            }
        }

        private void NameEnter_Enter(object sender, EventArgs e)
        {
            if (NameEnter.Text == "Enter new name")
            {
                NameEnter.Text = "";
                NameEnter.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
                NameEnter.ForeColor = Color.Black;
            }
        }

        private void NameEnter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameEnter.Text))
            {
                NameEnter.Text = "Enter new name";
                NameEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
                NameEnter.ForeColor = Color.Silver;
            }
        }

        private void DescriptionEnter_Enter(object sender, EventArgs e)
        {
            if (DescriptionEnter.Text == "Enter new description")
            {
                DescriptionEnter.Text = "";
                DescriptionEnter.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
                DescriptionEnter.ForeColor = Color.Black;
            }
        }

        private void DescriptionEnter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DescriptionEnter.Text))
            {
                DescriptionEnter.Text = "Enter new description";
                DescriptionEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
                DescriptionEnter.ForeColor = Color.Silver;
            }
        }

        private void GoBack()
        {
            ProjectDetails projectDetails = new ProjectDetails(_controller, _mainForm);
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

        private void backPB_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color lineColor = backPB.Tag?.ToString() == "Hovered" ? Color.Black : Color.FromArgb(126, 123, 122);

            Pen pen = new Pen(lineColor, 2);

            g.DrawLine(pen, 0, 12, 40, 12);
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


    }
}
