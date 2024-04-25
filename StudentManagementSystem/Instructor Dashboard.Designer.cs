namespace StudentManagementSystem
{
    partial class Instructor_Dashboard
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
            this.LnameShow = new System.Windows.Forms.Label();
            this.FnameShow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idShow = new System.Windows.Forms.Label();
            this.expertiseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feedbackbtn
            // 
            this.feedbackbtn.Location = new System.Drawing.Point(93, 131);
            this.feedbackbtn.Name = "feedbackbtn";
            this.feedbackbtn.Size = new System.Drawing.Size(75, 23);
            this.feedbackbtn.TabIndex = 13;
            this.feedbackbtn.Text = "Feedback";
            this.feedbackbtn.UseVisualStyleBackColor = true;
            this.feedbackbtn.Click += new System.EventHandler(this.feedbackbtn_Click);
            // 
            // LnameShow
            // 
            this.LnameShow.AutoSize = true;
            this.LnameShow.Location = new System.Drawing.Point(195, 81);
            this.LnameShow.Name = "LnameShow";
            this.LnameShow.Size = new System.Drawing.Size(35, 13);
            this.LnameShow.TabIndex = 12;
            this.LnameShow.Text = "label4";
            // 
            // FnameShow
            // 
            this.FnameShow.AutoSize = true;
            this.FnameShow.Location = new System.Drawing.Point(119, 81);
            this.FnameShow.Name = "FnameShow";
            this.FnameShow.Size = new System.Drawing.Size(35, 13);
            this.FnameShow.TabIndex = 11;
            this.FnameShow.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Instructor ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Instructor Name:";
            // 
            // idShow
            // 
            this.idShow.AutoSize = true;
            this.idShow.Location = new System.Drawing.Point(119, 41);
            this.idShow.Name = "idShow";
            this.idShow.Size = new System.Drawing.Size(35, 13);
            this.idShow.TabIndex = 8;
            this.idShow.Text = "label1";
            // 
            // expertiseBtn
            // 
            this.expertiseBtn.Location = new System.Drawing.Point(93, 180);
            this.expertiseBtn.Name = "expertiseBtn";
            this.expertiseBtn.Size = new System.Drawing.Size(75, 23);
            this.expertiseBtn.TabIndex = 14;
            this.expertiseBtn.Text = "Expertise";
            this.expertiseBtn.UseVisualStyleBackColor = true;
            this.expertiseBtn.Click += new System.EventHandler(this.expertiseBtn_Click);
            // 
            // Instructor_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.expertiseBtn);
            this.Controls.Add(this.feedbackbtn);
            this.Controls.Add(this.LnameShow);
            this.Controls.Add(this.FnameShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idShow);
            this.Name = "Instructor_Dashboard";
            this.Text = "Instructor_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button feedbackbtn;
        private System.Windows.Forms.Label LnameShow;
        private System.Windows.Forms.Label FnameShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idShow;
        private System.Windows.Forms.Button expertiseBtn;
    }
}