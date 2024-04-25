namespace StudentManagementSystem
{
    partial class StdEnrollment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewCourses = new System.Windows.Forms.FlowLayoutPanel();
            this.requestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENROLL COURSES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Courses:";
            // 
            // viewCourses
            // 
            this.viewCourses.Location = new System.Drawing.Point(371, 77);
            this.viewCourses.Name = "viewCourses";
            this.viewCourses.Size = new System.Drawing.Size(294, 506);
            this.viewCourses.TabIndex = 2;
            // 
            // requestBtn
            // 
            this.requestBtn.Location = new System.Drawing.Point(644, 15);
            this.requestBtn.Name = "requestBtn";
            this.requestBtn.Size = new System.Drawing.Size(93, 23);
            this.requestBtn.TabIndex = 3;
            this.requestBtn.Text = "Send Request";
            this.requestBtn.UseVisualStyleBackColor = true;
            this.requestBtn.Click += new System.EventHandler(this.requestBtn_Click);
            // 
            // StdEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.requestBtn);
            this.Controls.Add(this.viewCourses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StdEnrollment";
            this.Text = "StdEnrollment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel viewCourses;
        private System.Windows.Forms.Button requestBtn;
    }
}