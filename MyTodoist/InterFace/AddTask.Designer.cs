namespace Interface
{
    partial class AddTask
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
            DescriptionEnter = new TextBox();
            addButton = new Button();
            NameEnter = new TextBox();
            backPB = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backPB).BeginInit();
            SuspendLayout();
            // 
            // DescriptionEnter
            // 
            DescriptionEnter.BackColor = Color.White;
            DescriptionEnter.Cursor = Cursors.Hand;
            DescriptionEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
            DescriptionEnter.ForeColor = Color.Silver;
            DescriptionEnter.Location = new Point(205, 178);
            DescriptionEnter.Name = "DescriptionEnter";
            DescriptionEnter.Size = new Size(240, 44);
            DescriptionEnter.TabIndex = 0;
            DescriptionEnter.Text = "Description of task";
            DescriptionEnter.Enter += DescriptionEnter_Enter;
            DescriptionEnter.Leave += DescriptionEnter_Leave;
            // 
            // addButton
            // 
            addButton.Cursor = Cursors.Hand;
            addButton.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(205, 222);
            addButton.Name = "addButton";
            addButton.Size = new Size(240, 44);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            addButton.MouseEnter += addButton_MouseEnter;
            addButton.MouseLeave += addButton_MouseLeave;
            // 
            // NameEnter
            // 
            NameEnter.BackColor = Color.White;
            NameEnter.Cursor = Cursors.Hand;
            NameEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
            NameEnter.ForeColor = Color.Silver;
            NameEnter.Location = new Point(205, 134);
            NameEnter.Name = "NameEnter";
            NameEnter.Size = new Size(240, 44);
            NameEnter.TabIndex = 0;
            NameEnter.Text = "Name of task";
            NameEnter.Enter += NameEnter_Enter;
            NameEnter.Leave += NameEnter_Leave;
            // 
            // backPB
            // 
            backPB.Cursor = Cursors.Hand;
            backPB.Location = new Point(10, 10);
            backPB.Name = "backPB";
            backPB.Size = new Size(40, 28);
            backPB.TabIndex = 3;
            backPB.TabStop = false;
            backPB.Click += backPB_Click;
            backPB.Paint += backPB_Paint;
            backPB.MouseEnter += backPB_MouseEnter;
            backPB.MouseLeave += backPB_MouseLeave;
            // 
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 400);
            Controls.Add(backPB);
            Controls.Add(addButton);
            Controls.Add(NameEnter);
            Controls.Add(DescriptionEnter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTask";
            Text = "AddTask";
            ((System.ComponentModel.ISupportInitialize)backPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DescriptionEnter;
        private Button addButton;
        private TextBox NameEnter;
        private Button backButton;
        private PictureBox backPB;
    }
}