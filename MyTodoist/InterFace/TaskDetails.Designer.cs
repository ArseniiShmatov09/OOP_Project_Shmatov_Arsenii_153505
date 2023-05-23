namespace Interface
{
    partial class TaskDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDetails));
            descriptionLabel = new Label();
            priorityCheckedListBox = new CheckedListBox();
            priorityLabel = new Label();
            dateTimePicker = new DateTimePicker();
            addTimeButton = new Button();
            timeLabel = new Label();
            saveButton = new Button();
            backPB = new PictureBox();
            deletePB = new PictureBox();
            changePB = new PictureBox();
            helperPanel = new Panel();
            notifyPB = new PictureBox();
            priorityPB = new PictureBox();
            completePB = new PictureBox();
            deadlinePB = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deletePB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)changePB).BeginInit();
            helperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)notifyPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priorityPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)completePB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deadlinePB).BeginInit();
            SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AllowDrop = true;
            descriptionLabel.AutoEllipsis = true;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Calibri", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(115, 86);
            descriptionLabel.MaximumSize = new Size(500, 350);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(73, 35);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "label";
            // 
            // priorityCheckedListBox
            // 
            priorityCheckedListBox.BackColor = Color.FromArgb(222, 220, 220);
            priorityCheckedListBox.BorderStyle = BorderStyle.None;
            priorityCheckedListBox.Font = new Font("Calibri", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            priorityCheckedListBox.ForeColor = Color.White;
            priorityCheckedListBox.FormattingEnabled = true;
            priorityCheckedListBox.Location = new Point(0, 246);
            priorityCheckedListBox.Name = "priorityCheckedListBox";
            priorityCheckedListBox.Size = new Size(657, 155);
            priorityCheckedListBox.TabIndex = 3;
            priorityCheckedListBox.ItemCheck += priorityCheckedListBox_ItemCheck;
            priorityCheckedListBox.MouseLeave += priorityCheckedListBox_MouseLeave;
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            priorityLabel.Location = new Point(115, 9);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(61, 24);
            priorityLabel.TabIndex = 4;
            priorityLabel.Text = "label1";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            dateTimePicker.Cursor = Cursors.Hand;
            dateTimePicker.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker.Location = new Point(88, 166);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(237, 36);
            dateTimePicker.TabIndex = 6;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // addTimeButton
            // 
            addTimeButton.Cursor = Cursors.Hand;
            addTimeButton.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addTimeButton.Location = new Point(88, 200);
            addTimeButton.Name = "addTimeButton";
            addTimeButton.Size = new Size(237, 36);
            addTimeButton.TabIndex = 1;
            addTimeButton.Text = "add time";
            addTimeButton.UseVisualStyleBackColor = true;
            addTimeButton.Click += addTimeButton_Click;
            addTimeButton.MouseEnter += addTimeButton_MouseEnter;
            addTimeButton.MouseLeave += addTimeButton_MouseLeave;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            timeLabel.Location = new Point(115, 50);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(61, 24);
            timeLabel.TabIndex = 4;
            timeLabel.Text = "label1";
            // 
            // saveButton
            // 
            saveButton.Cursor = Cursors.Hand;
            saveButton.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(88, 234);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(237, 36);
            saveButton.TabIndex = 1;
            saveButton.Text = "save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            saveButton.MouseEnter += saveButton_MouseEnter;
            saveButton.MouseLeave += saveButton_MouseLeave;
            // 
            // backPB
            // 
            backPB.Cursor = Cursors.Hand;
            backPB.Location = new Point(10, 10);
            backPB.Name = "backPB";
            backPB.Size = new Size(13, 25);
            backPB.TabIndex = 7;
            backPB.TabStop = false;
            backPB.Paint += backPB_Paint;
            backPB.MouseClick += backPB_Click;
            backPB.MouseEnter += backPB_MouseEnter;
            backPB.MouseLeave += backPB_MouseLeave;
            // 
            // deletePB
            // 
            deletePB.Cursor = Cursors.Hand;
            deletePB.Image = (Image)resources.GetObject("deletePB.Image");
            deletePB.Location = new Point(7, 32);
            deletePB.Name = "deletePB";
            deletePB.Size = new Size(32, 32);
            deletePB.SizeMode = PictureBoxSizeMode.Zoom;
            deletePB.TabIndex = 9;
            deletePB.TabStop = false;
            deletePB.Click += deletePB_Click;
            deletePB.MouseEnter += DeletePB_MouseEnter;
            deletePB.MouseLeave += DeletePB_MouseLeave;
            // 
            // changePB
            // 
            changePB.Cursor = Cursors.Hand;
            changePB.Image = (Image)resources.GetObject("changePB.Image");
            changePB.Location = new Point(7, 89);
            changePB.Name = "changePB";
            changePB.Size = new Size(32, 32);
            changePB.SizeMode = PictureBoxSizeMode.Zoom;
            changePB.TabIndex = 10;
            changePB.TabStop = false;
            changePB.Click += changePB_Click;
            changePB.MouseEnter += ChangePB_MouseEnter;
            changePB.MouseLeave += ChangePB_MouseLeave;
            // 
            // helperPanel
            // 
            helperPanel.Controls.Add(notifyPB);
            helperPanel.Controls.Add(changePB);
            helperPanel.Controls.Add(priorityPB);
            helperPanel.Controls.Add(completePB);
            helperPanel.Controls.Add(deletePB);
            helperPanel.Controls.Add(deadlinePB);
            helperPanel.Location = new Point(32, 32);
            helperPanel.Name = "helperPanel";
            helperPanel.Size = new Size(50, 356);
            helperPanel.TabIndex = 13;
            // 
            // notifyPB
            // 
            notifyPB.Cursor = Cursors.Hand;
            notifyPB.Image = Properties.Resources.notification;
            notifyPB.Location = new Point(7, 317);
            notifyPB.Name = "notifyPB";
            notifyPB.Size = new Size(32, 32);
            notifyPB.SizeMode = PictureBoxSizeMode.Zoom;
            notifyPB.TabIndex = 15;
            notifyPB.TabStop = false;
            notifyPB.Click += notifyPB_Click;
            notifyPB.MouseEnter += notifyPB_MouseEnter;
            notifyPB.MouseLeave += notifyPB_MouseLeave;
            // 
            // priorityPB
            // 
            priorityPB.Cursor = Cursors.Hand;
            priorityPB.Image = Properties.Resources.priority;
            priorityPB.Location = new Point(7, 260);
            priorityPB.Name = "priorityPB";
            priorityPB.Size = new Size(32, 32);
            priorityPB.SizeMode = PictureBoxSizeMode.Zoom;
            priorityPB.TabIndex = 15;
            priorityPB.TabStop = false;
            priorityPB.Click += priorityPB_Click;
            priorityPB.MouseEnter += priorityPB_MouseEnter;
            priorityPB.MouseLeave += priorityPB_MouseLeave;
            // 
            // completePB
            // 
            completePB.Cursor = Cursors.Hand;
            completePB.Image = Properties.Resources.complete;
            completePB.Location = new Point(7, 146);
            completePB.Name = "completePB";
            completePB.Size = new Size(32, 32);
            completePB.SizeMode = PictureBoxSizeMode.Zoom;
            completePB.TabIndex = 14;
            completePB.TabStop = false;
            completePB.Click += completePB_Click;
            completePB.MouseEnter += completePB_MouseEnter;
            completePB.MouseLeave += completePB_MouseLeave;
            // 
            // deadlinePB
            // 
            deadlinePB.Cursor = Cursors.Hand;
            deadlinePB.Image = Properties.Resources.deadline;
            deadlinePB.Location = new Point(7, 203);
            deadlinePB.Name = "deadlinePB";
            deadlinePB.Size = new Size(32, 32);
            deadlinePB.SizeMode = PictureBoxSizeMode.Zoom;
            deadlinePB.TabIndex = 15;
            deadlinePB.TabStop = false;
            deadlinePB.Click += deadlinePB_Click;
            deadlinePB.MouseEnter += deadlinePB_MouseEnter;
            deadlinePB.MouseLeave += deadlinePB_MouseLeave;
            // 
            // TaskDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 400);
            Controls.Add(dateTimePicker);
            Controls.Add(saveButton);
            Controls.Add(addTimeButton);
            Controls.Add(priorityCheckedListBox);
            Controls.Add(helperPanel);
            Controls.Add(backPB);
            Controls.Add(timeLabel);
            Controls.Add(priorityLabel);
            Controls.Add(descriptionLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaskDetails";
            Text = "TaskDetails";
            Paint += TaskDetails_Paint;
            ((System.ComponentModel.ISupportInitialize)backPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)deletePB).EndInit();
            ((System.ComponentModel.ISupportInitialize)changePB).EndInit();
            helperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)notifyPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)priorityPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)completePB).EndInit();
            ((System.ComponentModel.ISupportInitialize)deadlinePB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label descriptionLabel;
        private CheckedListBox priorityCheckedListBox;
        private Label priorityLabel;
        private DateTimePicker dateTimePicker;
        private Button button1;
        private Button addTimeButton;
        private Label timeLabel;
        private Button saveButton;
        private PictureBox backPB;
        private PictureBox deletePB;
        private PictureBox changePB;
        private Panel helperPanel;
        private PictureBox completePB;
        private PictureBox priorityPB;
        private PictureBox deadlinePB;
        private PictureBox notifyPB;
    }
}