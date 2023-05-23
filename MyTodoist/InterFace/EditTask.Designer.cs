namespace Interface
{
    partial class EditTask
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
            backPB = new PictureBox();
            editButton = new Button();
            DescriptionEnter = new TextBox();
            NameEnter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)backPB).BeginInit();
            SuspendLayout();
            // 
            // backPB
            // 
            backPB.Cursor = Cursors.Hand;
            backPB.Location = new Point(9, 8);
            backPB.Name = "backPB";
            backPB.Size = new Size(40, 28);
            backPB.TabIndex = 10;
            backPB.TabStop = false;
            backPB.Click += backPB_Click;
            backPB.Paint += backPB_Paint;
            backPB.MouseEnter += backPB_MouseEnter;
            backPB.MouseLeave += backPB_MouseLeave;
            // 
            // editButton
            // 
            editButton.Cursor = Cursors.Hand;
            editButton.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            editButton.Location = new Point(181, 220);
            editButton.Name = "editButton";
            editButton.Size = new Size(286, 44);
            editButton.TabIndex = 9;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            editButton.MouseEnter += editButton_MouseEnter;
            editButton.MouseLeave += editButton_MouseLeave;
            // 
            // DescriptionEnter
            // 
            DescriptionEnter.BackColor = Color.White;
            DescriptionEnter.Cursor = Cursors.Hand;
            DescriptionEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
            DescriptionEnter.ForeColor = Color.Silver;
            DescriptionEnter.Location = new Point(181, 176);
            DescriptionEnter.Name = "DescriptionEnter";
            DescriptionEnter.Size = new Size(286, 44);
            DescriptionEnter.TabIndex = 7;
            DescriptionEnter.Text = "New task description";
            DescriptionEnter.Enter += DescriptionEnter_Enter;
            DescriptionEnter.Leave += DescriptionEnter_Leave;
            // 
            // NameEnter
            // 
            NameEnter.BackColor = Color.White;
            NameEnter.Cursor = Cursors.Hand;
            NameEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
            NameEnter.ForeColor = Color.Silver;
            NameEnter.Location = new Point(181, 132);
            NameEnter.Name = "NameEnter";
            NameEnter.Size = new Size(286, 44);
            NameEnter.TabIndex = 8;
            NameEnter.Text = "New task name";
            NameEnter.Enter += NameEnter_Enter;
            NameEnter.Leave += NameEnter_Leave;
            // 
            // EditTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 400);
            Controls.Add(backPB);
            Controls.Add(editButton);
            Controls.Add(DescriptionEnter);
            Controls.Add(NameEnter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditTask";
            Text = "EditTask";
            ((System.ComponentModel.ISupportInitialize)backPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox backPB;
        private Button editButton;
        private TextBox DescriptionEnter;
        private TextBox NameEnter;
    }
}