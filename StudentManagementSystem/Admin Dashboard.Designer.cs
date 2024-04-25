namespace StudentManagementSystem
{
    partial class Admin_Dashboard
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
            this.LnameShow = new System.Windows.Forms.Label();
            this.FnameShow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idShow = new System.Windows.Forms.Label();
            this.feedbackbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.crsbtn = new System.Windows.Forms.Button();
            this.addClass = new System.Windows.Forms.Button();
            this.semesterBtn = new System.Windows.Forms.Button();
            this.upgStd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LnameShow
            // 
            this.LnameShow.AutoSize = true;
            this.LnameShow.Location = new System.Drawing.Point(208, 82);
            this.LnameShow.Name = "LnameShow";
            this.LnameShow.Size = new System.Drawing.Size(35, 13);
            this.LnameShow.TabIndex = 15;
            this.LnameShow.Text = "label4";
            // 
            // FnameShow
            // 
            this.FnameShow.AutoSize = true;
            this.FnameShow.Location = new System.Drawing.Point(137, 82);
            this.FnameShow.Name = "FnameShow";
            this.FnameShow.Size = new System.Drawing.Size(35, 13);
            this.FnameShow.TabIndex = 14;
            this.FnameShow.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Admin ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Admin Name:";
            // 
            // idShow
            // 
            this.idShow.AutoSize = true;
            this.idShow.Location = new System.Drawing.Point(137, 29);
            this.idShow.Name = "idShow";
            this.idShow.Size = new System.Drawing.Size(35, 13);
            this.idShow.TabIndex = 11;
            this.idShow.Text = "label1";
            // 
            // feedbackbtn
            // 
            this.feedbackbtn.Location = new System.Drawing.Point(73, 130);
            this.feedbackbtn.Name = "feedbackbtn";
            this.feedbackbtn.Size = new System.Drawing.Size(75, 23);
            this.feedbackbtn.TabIndex = 16;
            this.feedbackbtn.Text = "Feedback";
            this.feedbackbtn.UseVisualStyleBackColor = true;
            this.feedbackbtn.Click += new System.EventHandler(this.feedbackbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Admission";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crsbtn
            // 
            this.crsbtn.Location = new System.Drawing.Point(73, 242);
            this.crsbtn.Name = "crsbtn";
            this.crsbtn.Size = new System.Drawing.Size(75, 23);
            this.crsbtn.TabIndex = 18;
            this.crsbtn.Text = "Courses";
            this.crsbtn.UseVisualStyleBackColor = true;
            this.crsbtn.Click += new System.EventHandler(this.crsbtn_Click);
            // 
            // addClass
            // 
            this.addClass.Location = new System.Drawing.Point(73, 296);
            this.addClass.Name = "addClass";
            this.addClass.Size = new System.Drawing.Size(75, 23);
            this.addClass.TabIndex = 19;
            this.addClass.Text = "Create Class";
            this.addClass.UseVisualStyleBackColor = true;
            this.addClass.Click += new System.EventHandler(this.addClass_Click);
            // 
            // semesterBtn
            // 
            this.semesterBtn.Location = new System.Drawing.Point(73, 351);
            this.semesterBtn.Name = "semesterBtn";
            this.semesterBtn.Size = new System.Drawing.Size(75, 23);
            this.semesterBtn.TabIndex = 20;
            this.semesterBtn.Text = "Semester";
            this.semesterBtn.UseVisualStyleBackColor = true;
            this.semesterBtn.Click += new System.EventHandler(this.semesterBtn_Click);
            // 
            // upgStd
            // 
            this.upgStd.Location = new System.Drawing.Point(211, 130);
            this.upgStd.Name = "upgStd";
            this.upgStd.Size = new System.Drawing.Size(75, 23);
            this.upgStd.TabIndex = 21;
            this.upgStd.Text = "Upgrade Students";
            this.upgStd.UseVisualStyleBackColor = true;
            this.upgStd.Click += new System.EventHandler(this.upgStd_Click);
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.upgStd);
            this.Controls.Add(this.semesterBtn);
            this.Controls.Add(this.addClass);
            this.Controls.Add(this.crsbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.feedbackbtn);
            this.Controls.Add(this.LnameShow);
            this.Controls.Add(this.FnameShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idShow);
            this.Name = "Admin_Dashboard";
            this.Text = "Admin_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LnameShow;
        private System.Windows.Forms.Label FnameShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idShow;
        private System.Windows.Forms.Button feedbackbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button crsbtn;
        private System.Windows.Forms.Button addClass;
        private System.Windows.Forms.Button semesterBtn;
        private System.Windows.Forms.Button upgStd;
    }
}