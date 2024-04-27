namespace StudentManagementSystem
{
    partial class Student_Dashboard
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
            this.feedbackbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LnameShow = new System.Windows.Forms.Label();
            this.FnameShow = new System.Windows.Forms.Label();
            this.idShow = new System.Windows.Forms.Label();
            this.EnrollBtn = new System.Windows.Forms.Button();
            this.gradeBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feedbackbtn
            // 
            this.feedbackbtn.Location = new System.Drawing.Point(46, 121);
            this.feedbackbtn.Name = "feedbackbtn";
            this.feedbackbtn.Size = new System.Drawing.Size(75, 23);
            this.feedbackbtn.TabIndex = 12;
            this.feedbackbtn.Text = "Feedback";
            this.feedbackbtn.UseVisualStyleBackColor = true;
            this.feedbackbtn.Click += new System.EventHandler(this.feedbackbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student ID:";
            // 
            // LnameShow
            // 
            this.LnameShow.AutoSize = true;
            this.LnameShow.Location = new System.Drawing.Point(186, 69);
            this.LnameShow.Name = "LnameShow";
            this.LnameShow.Size = new System.Drawing.Size(35, 13);
            this.LnameShow.TabIndex = 9;
            this.LnameShow.Text = "label1";
            // 
            // FnameShow
            // 
            this.FnameShow.AutoSize = true;
            this.FnameShow.Location = new System.Drawing.Point(115, 69);
            this.FnameShow.Name = "FnameShow";
            this.FnameShow.Size = new System.Drawing.Size(35, 13);
            this.FnameShow.TabIndex = 8;
            this.FnameShow.Text = "label1";
            // 
            // idShow
            // 
            this.idShow.AutoSize = true;
            this.idShow.Location = new System.Drawing.Point(115, 33);
            this.idShow.Name = "idShow";
            this.idShow.Size = new System.Drawing.Size(35, 13);
            this.idShow.TabIndex = 7;
            this.idShow.Text = "label1";
            // 
            // EnrollBtn
            // 
            this.EnrollBtn.Location = new System.Drawing.Point(46, 173);
            this.EnrollBtn.Name = "EnrollBtn";
            this.EnrollBtn.Size = new System.Drawing.Size(75, 23);
            this.EnrollBtn.TabIndex = 13;
            this.EnrollBtn.Text = "Enroll";
            this.EnrollBtn.UseVisualStyleBackColor = true;
            this.EnrollBtn.Click += new System.EventHandler(this.EnrollBtn_Click);
            // 
            // gradeBtn
            // 
            this.gradeBtn.Location = new System.Drawing.Point(46, 228);
            this.gradeBtn.Name = "gradeBtn";
            this.gradeBtn.Size = new System.Drawing.Size(75, 23);
            this.gradeBtn.TabIndex = 14;
            this.gradeBtn.Text = "Grades";
            this.gradeBtn.UseVisualStyleBackColor = true;
            this.gradeBtn.Click += new System.EventHandler(this.gradeBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.Location = new System.Drawing.Point(46, 276);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(87, 23);
            this.historyBtn.TabIndex = 15;
            this.historyBtn.Text = "Grade History";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // Student_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.gradeBtn);
            this.Controls.Add(this.EnrollBtn);
            this.Controls.Add(this.feedbackbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LnameShow);
            this.Controls.Add(this.FnameShow);
            this.Controls.Add(this.idShow);
            this.Name = "Student_Dashboard";
            this.Text = "Student_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button feedbackbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LnameShow;
        private System.Windows.Forms.Label FnameShow;
        private System.Windows.Forms.Label idShow;
        private System.Windows.Forms.Button EnrollBtn;
        private System.Windows.Forms.Button gradeBtn;
        private System.Windows.Forms.Button historyBtn;
    }
}