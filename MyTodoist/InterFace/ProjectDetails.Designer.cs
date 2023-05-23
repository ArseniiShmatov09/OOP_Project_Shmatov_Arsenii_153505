namespace Interface
{
    partial class ProjectDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectDetails));
            listViewTasks = new ListView();
            sortCheckedListBox = new CheckedListBox();
            backPB = new PictureBox();
            changePB = new PictureBox();
            sortPB = new PictureBox();
            deletePB = new PictureBox();
            addPB = new PictureBox();
            showCTPB = new PictureBox();
            helperPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)backPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)changePB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sortPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deletePB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showCTPB).BeginInit();
            SuspendLayout();
            // 
            // listViewTasks
            // 
            listViewTasks.BackColor = Color.White;
            listViewTasks.BorderStyle = BorderStyle.None;
            listViewTasks.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViewTasks.GridLines = true;
            listViewTasks.Location = new Point(112, 0);
            listViewTasks.Name = "listViewTasks";
            listViewTasks.Size = new Size(546, 410);
            listViewTasks.TabIndex = 1;
            listViewTasks.UseCompatibleStateImageBehavior = false;
            listViewTasks.MouseMove += listViewTasks_MouseMove;
            // 
            // sortCheckedListBox
            // 
            sortCheckedListBox.BackColor = Color.FromArgb(222, 220, 220);
            sortCheckedListBox.BorderStyle = BorderStyle.None;
            sortCheckedListBox.Cursor = Cursors.Hand;
            sortCheckedListBox.Font = new Font("Calibri", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            sortCheckedListBox.ForeColor = Color.White;
            sortCheckedListBox.FormattingEnabled = true;
            sortCheckedListBox.Location = new Point(0, 283);
            sortCheckedListBox.Name = "sortCheckedListBox";
            sortCheckedListBox.Size = new Size(671, 140);
            sortCheckedListBox.TabIndex = 4;
            sortCheckedListBox.ItemCheck += sortCheckedListBox_ItemCheck;
            sortCheckedListBox.MouseLeave += SortCheckedListBox_MouseLeave;
            // 
            // backPB
            // 
            backPB.Cursor = Cursors.Hand;
            backPB.Location = new Point(10, 10);
            backPB.Name = "backPB";
            backPB.Size = new Size(13, 25);
            backPB.TabIndex = 5;
            backPB.TabStop = false;
            backPB.Click += backPB_Click;
            backPB.Paint += backPB_Paint;
            backPB.MouseEnter += backPB_MouseEnter;
            backPB.MouseLeave += backPB_MouseLeave;
            // 
            // changePB
            // 
            changePB.Cursor = Cursors.Hand;
            changePB.Image = (Image)resources.GetObject("changePB.Image");
            changePB.Location = new Point(39, 122);
            changePB.Name = "changePB";
            changePB.Size = new Size(32, 32);
            changePB.SizeMode = PictureBoxSizeMode.Zoom;
            changePB.TabIndex = 6;
            changePB.TabStop = false;
            changePB.Click += changePB_Click;
            changePB.MouseEnter += ChangePB_MouseEnter;
            changePB.MouseLeave += ChangePB_MouseLeave;
            // 
            // sortPB
            // 
            sortPB.Cursor = Cursors.Hand;
            sortPB.Image = (Image)resources.GetObject("sortPB.Image");
            sortPB.Location = new Point(39, 293);
            sortPB.Name = "sortPB";
            sortPB.Size = new Size(32, 32);
            sortPB.SizeMode = PictureBoxSizeMode.Zoom;
            sortPB.TabIndex = 6;
            sortPB.TabStop = false;
            sortPB.Click += sortPB_Click;
            sortPB.MouseEnter += SortPB_MouseEnter;
            sortPB.MouseLeave += SortPB_MouseLeave;
            // 
            // deletePB
            // 
            deletePB.Cursor = Cursors.Hand;
            deletePB.Image = (Image)resources.GetObject("deletePB.Image");
            deletePB.Location = new Point(39, 65);
            deletePB.Name = "deletePB";
            deletePB.Size = new Size(32, 32);
            deletePB.SizeMode = PictureBoxSizeMode.Zoom;
            deletePB.TabIndex = 6;
            deletePB.TabStop = false;
            deletePB.Click += deletePB_Click;
            deletePB.MouseEnter += DeletePB_MouseEnter;
            deletePB.MouseLeave += DeletePB_MouseLeave;
            // 
            // addPB
            // 
            addPB.Cursor = Cursors.Hand;
            addPB.Image = (Image)resources.GetObject("addPB.Image");
            addPB.Location = new Point(39, 179);
            addPB.Name = "addPB";
            addPB.Size = new Size(32, 32);
            addPB.SizeMode = PictureBoxSizeMode.Zoom;
            addPB.TabIndex = 6;
            addPB.TabStop = false;
            addPB.Click += addPB_Click;
            addPB.MouseEnter += AddPB_MouseEnter;
            addPB.MouseLeave += AddPB_MouseLeave;
            // 
            // showCTPB
            // 
            showCTPB.Cursor = Cursors.Hand;
            showCTPB.Image = Properties.Resources.showST;
            showCTPB.Location = new Point(39, 236);
            showCTPB.Name = "showCTPB";
            showCTPB.Size = new Size(32, 32);
            showCTPB.SizeMode = PictureBoxSizeMode.Zoom;
            showCTPB.TabIndex = 6;
            showCTPB.TabStop = false;
            showCTPB.Click += showCTPB_Click;
            showCTPB.MouseEnter += ShowCTPB_MouseEnter;
            showCTPB.MouseLeave += ShowCTPB_MouseLeave;
            // 
            // helperPanel
            // 
            helperPanel.Location = new Point(33, 65);
            helperPanel.Name = "helperPanel";
            helperPanel.Size = new Size(46, 104);
            helperPanel.TabIndex = 8;
            // 
            // ProjectDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 400);
            Controls.Add(sortCheckedListBox);
            Controls.Add(listViewTasks);
            Controls.Add(showCTPB);
            Controls.Add(addPB);
            Controls.Add(deletePB);
            Controls.Add(sortPB);
            Controls.Add(changePB);
            Controls.Add(backPB);
            Controls.Add(helperPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProjectDetails";
            Text = "ProjectDetails";
            Paint += ProjectDetails_Paint;
            ((System.ComponentModel.ISupportInitialize)backPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)changePB).EndInit();
            ((System.ComponentModel.ISupportInitialize)sortPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)deletePB).EndInit();
            ((System.ComponentModel.ISupportInitialize)addPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)showCTPB).EndInit();
            ResumeLayout(false);
        }


        #endregion
        public ListView listViewTasks;
        private CheckedListBox sortCheckedListBox;
        private PictureBox backPB;
        private PictureBox changePB;
        private PictureBox sortPB;
        private PictureBox deletePB;
        private PictureBox addPB;
        private PictureBox showCTPB;
        private Panel helperPanel;
    }
}