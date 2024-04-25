namespace StudentManagementSystem
{
    partial class Student_Feedback
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
            this.showStdFdbk = new System.Windows.Forms.Button();
            this.stdFdbkToAdmin = new System.Windows.Forms.Button();
            this.stdFdbkToInst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.showStdFdbk);
            this.panel1.Controls.Add(this.stdFdbkToAdmin);
            this.panel1.Controls.Add(this.stdFdbkToInst);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 537);
            this.panel1.TabIndex = 1;
            // 
            // showStdFdbk
            // 
            this.showStdFdbk.Location = new System.Drawing.Point(624, 12);
            this.showStdFdbk.Name = "showStdFdbk";
            this.showStdFdbk.Size = new System.Drawing.Size(149, 38);
            this.showStdFdbk.TabIndex = 3;
            this.showStdFdbk.Text = "Show My Feedbacks";
            this.showStdFdbk.UseVisualStyleBackColor = true;
            this.showStdFdbk.Click += new System.EventHandler(this.showStdFdbk_Click);
            // 
            // stdFdbkToAdmin
            // 
            this.stdFdbkToAdmin.Location = new System.Drawing.Point(507, 84);
            this.stdFdbkToAdmin.Name = "stdFdbkToAdmin";
            this.stdFdbkToAdmin.Size = new System.Drawing.Size(138, 39);
            this.stdFdbkToAdmin.TabIndex = 2;
            this.stdFdbkToAdmin.Text = "Feedback To Institute";
            this.stdFdbkToAdmin.UseVisualStyleBackColor = true;
            this.stdFdbkToAdmin.Click += new System.EventHandler(this.stdFdbkToAdmin_Click);
            // 
            // stdFdbkToInst
            // 
            this.stdFdbkToInst.Location = new System.Drawing.Point(163, 84);
            this.stdFdbkToInst.Name = "stdFdbkToInst";
            this.stdFdbkToInst.Size = new System.Drawing.Size(137, 39);
            this.stdFdbkToInst.TabIndex = 1;
            this.stdFdbkToInst.Text = "Feedback To Instructor";
            this.stdFdbkToInst.UseVisualStyleBackColor = true;
            this.stdFdbkToInst.Click += new System.EventHandler(this.stdFdbkToInst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FEEDBACK FORM";
            // 
            // Student_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.panel1);
            this.Name = "Student_Feedback";
            this.Text = "Student_Feedback";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showStdFdbk;
        private System.Windows.Forms.Button stdFdbkToAdmin;
        private System.Windows.Forms.Button stdFdbkToInst;
        private System.Windows.Forms.Label label1;
    }
}