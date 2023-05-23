namespace Interface
{
    partial class AddProject
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
            NameEnter = new TextBox();
            DescriptionEnter = new TextBox();
            Add = new Button();
            backPB = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backPB).BeginInit();
            SuspendLayout();
            // 
            // NameEnter
            // 
            NameEnter.Cursor = Cursors.Hand;
            NameEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
            NameEnter.ForeColor = Color.Silver;
            NameEnter.Location = new Point(205, 134);
            NameEnter.Name = "NameEnter";
            NameEnter.Size = new Size(240, 44);
            NameEnter.TabIndex = 0;
            NameEnter.Text = "Enter Name";
            NameEnter.Enter += NameEnter_Enter;
            NameEnter.Leave += NameEnter_Leave;
            // 
            // DescriptionEnter
            // 
            DescriptionEnter.Cursor = Cursors.Hand;
            DescriptionEnter.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
            DescriptionEnter.ForeColor = Color.Silver;
            DescriptionEnter.Location = new Point(205, 178);
            DescriptionEnter.Name = "DescriptionEnter";
            DescriptionEnter.Size = new Size(240, 44);
            DescriptionEnter.TabIndex = 0;
            DescriptionEnter.Text = "Enter Description";
            DescriptionEnter.Enter += DescriptionEnter_Enter;
            DescriptionEnter.Leave += DescriptionEnter_Leave;
            // 
            // Add
            // 
            Add.BackColor = SystemColors.Control;
            Add.Cursor = Cursors.Hand;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Add.Location = new Point(205, 222);
            Add.Name = "Add";
            Add.Size = new Size(240, 44);
            Add.TabIndex = 1;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += button1_Click;
            Add.MouseEnter += Add_MouseEnter;
            Add.MouseLeave += Add_MouseLeave;
            // 
            // backPB
            // 
            backPB.Cursor = Cursors.Hand;
            backPB.Location = new Point(10, 10);
            backPB.Name = "backPB";
            backPB.Size = new Size(40, 28);
            backPB.TabIndex = 2;
            backPB.TabStop = false;
            backPB.Click += backPB_Click;
            backPB.Paint += backPB_Paint;
            backPB.MouseEnter += backPB_MouseEnter;
            backPB.MouseLeave += backPB_MouseLeave;
            // 
            // AddProject
            // 
            AcceptButton = Add;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 400);
            Controls.Add(backPB);
            Controls.Add(Add);
            Controls.Add(DescriptionEnter);
            Controls.Add(NameEnter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProject";
            Text = "AddProject";
            ((System.ComponentModel.ISupportInitialize)backPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private TextBox NameEnter;
        private TextBox DescriptionEnter;
        private Button Add;
        private PictureBox backPB;
    }
}