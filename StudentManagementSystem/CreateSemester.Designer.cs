namespace StudentManagementSystem
{
    partial class CreateSemester
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addSemBtn = new System.Windows.Forms.Button();
            this.noOfCrs = new System.Windows.Forms.TextBox();
            this.FeePerCrdHr = new System.Windows.Forms.TextBox();
            this.SemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passingMarks = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.passingMarks);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.addSemBtn);
            this.panel1.Controls.Add(this.noOfCrs);
            this.panel1.Controls.Add(this.FeePerCrdHr);
            this.panel1.Controls.Add(this.SemName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(155, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 393);
            this.panel1.TabIndex = 0;
            // 
            // addSemBtn
            // 
            this.addSemBtn.Location = new System.Drawing.Point(247, 296);
            this.addSemBtn.Name = "addSemBtn";
            this.addSemBtn.Size = new System.Drawing.Size(113, 23);
            this.addSemBtn.TabIndex = 7;
            this.addSemBtn.Text = "Add Semester";
            this.addSemBtn.UseVisualStyleBackColor = true;
            this.addSemBtn.Click += new System.EventHandler(this.addSemBtn_Click);
            // 
            // noOfCrs
            // 
            this.noOfCrs.Location = new System.Drawing.Point(344, 212);
            this.noOfCrs.Name = "noOfCrs";
            this.noOfCrs.Size = new System.Drawing.Size(147, 20);
            this.noOfCrs.TabIndex = 6;
            // 
            // FeePerCrdHr
            // 
            this.FeePerCrdHr.Location = new System.Drawing.Point(344, 145);
            this.FeePerCrdHr.Name = "FeePerCrdHr";
            this.FeePerCrdHr.Size = new System.Drawing.Size(147, 20);
            this.FeePerCrdHr.TabIndex = 5;
            // 
            // SemName
            // 
            this.SemName.Location = new System.Drawing.Point(344, 89);
            this.SemName.Name = "SemName";
            this.SemName.Size = new System.Drawing.Size(147, 20);
            this.SemName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No. Of Courses Required To Register";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fees Per Credit Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semester Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Passing Marks";
            // 
            // passingMarks
            // 
            this.passingMarks.Location = new System.Drawing.Point(344, 256);
            this.passingMarks.Name = "passingMarks";
            this.passingMarks.Size = new System.Drawing.Size(147, 20);
            this.passingMarks.TabIndex = 9;
            // 
            // CreateSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CreateSemester";
            this.Text = "CreateSemester";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSemBtn;
        private System.Windows.Forms.TextBox noOfCrs;
        private System.Windows.Forms.TextBox FeePerCrdHr;
        private System.Windows.Forms.TextBox SemName;
        private System.Windows.Forms.TextBox passingMarks;
        private System.Windows.Forms.Label label5;
    }
}