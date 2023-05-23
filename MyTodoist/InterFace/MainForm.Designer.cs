namespace InterFace
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainPanel = new Panel();
            listViewProjects = new ListView();
            addTaskButton = new Button();
            nameLabel = new Label();
            close = new PictureBox();
            hide = new PictureBox();
            addProjectPB = new PictureBox();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addProjectPB).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(listViewProjects);
            MainPanel.Location = new Point(1, 36);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(650, 400);
            MainPanel.TabIndex = 1;
            // 
            // listViewProjects
            // 
            listViewProjects.BorderStyle = BorderStyle.None;
            listViewProjects.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViewProjects.GridLines = true;
            listViewProjects.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewProjects.Location = new Point(0, 5);
            listViewProjects.Margin = new Padding(0);
            listViewProjects.Name = "listViewProjects";
            listViewProjects.Size = new Size(650, 400);
            listViewProjects.TabIndex = 2;
            listViewProjects.UseCompatibleStateImageBehavior = false;
            // 
            // addTaskButton
            // 
            addTaskButton.Cursor = Cursors.Hand;
            addTaskButton.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addTaskButton.ForeColor = SystemColors.ActiveCaptionText;
            addTaskButton.Location = new Point(308, 450);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(40, 40);
            addTaskButton.TabIndex = 0;
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            addTaskButton.Paint += addTaskButton_Paint;
            addTaskButton.MouseEnter += AddTaskButton_MouseEnter;
            addTaskButton.MouseLeave += AddTaskButton_MouseLeave;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(0, 0);
            nameLabel.MaximumSize = new Size(600, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(175, 35);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "MY PROJECTS";
            // 
            // close
            // 
            close.Cursor = Cursors.Hand;
            close.Image = (Image)resources.GetObject("close.Image");
            close.Location = new Point(636, 0);
            close.Name = "close";
            close.Size = new Size(15, 15);
            close.SizeMode = PictureBoxSizeMode.Zoom;
            close.TabIndex = 4;
            close.TabStop = false;
            close.Click += close_Click;
            close.MouseEnter += close_MouseEnter;
            close.MouseLeave += close_MouseLeave;
            // 
            // hide
            // 
            hide.Cursor = Cursors.Hand;
            hide.Image = (Image)resources.GetObject("hide.Image");
            hide.Location = new Point(615, 0);
            hide.Name = "hide";
            hide.Size = new Size(15, 15);
            hide.SizeMode = PictureBoxSizeMode.Zoom;
            hide.TabIndex = 4;
            hide.TabStop = false;
            hide.Click += hide_Click;
            hide.MouseEnter += hide_MouseEnter;
            hide.MouseLeave += hide_MouseLeave;
            // 
            // addProjectPB
            // 
            addProjectPB.Cursor = Cursors.Hand;
            addProjectPB.Location = new Point(155, 10);
            addProjectPB.Name = "addProjectPB";
            addProjectPB.Size = new Size(20, 20);
            addProjectPB.TabIndex = 5;
            addProjectPB.TabStop = false;
            addProjectPB.Click += addProjectPB_Click;
            addProjectPB.Paint += AddProjectPB_Paint;
            addProjectPB.MouseEnter += AddProjectPB_MouseEnter;
            addProjectPB.MouseLeave += AddProjectPB_MouseLeave;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 220, 220);
            ClientSize = new Size(650, 506);
            Controls.Add(addProjectPB);
            Controls.Add(addTaskButton);
            Controls.Add(hide);
            Controls.Add(close);
            Controls.Add(nameLabel);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Form1";
            Load += Form_Load;
            MouseDown += MainForm_MouseDown;
            MouseMove += MainForm_MouseMove;
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ((System.ComponentModel.ISupportInitialize)hide).EndInit();
            ((System.ComponentModel.ISupportInitialize)addProjectPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Panel MainPanel;
        public ListView listViewProjects;
        public Label nameLabel;
        public Button addTaskButton;
        private PictureBox close;
        private PictureBox hide;
        public PictureBox addProjectPB;
    }
}