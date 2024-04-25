namespace StudentManagementSystem
{
    partial class Add_Courses
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
            this.viewCourses = new System.Windows.Forms.Button();
            this.addCrsBtn = new System.Windows.Forms.Button();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.InputLname = new System.Windows.Forms.TextBox();
            this.InputFname = new System.Windows.Forms.TextBox();
            this.crsDesc = new System.Windows.Forms.Label();
            this.crsAbr = new System.Windows.Forms.Label();
            this.crsName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.viewCourses);
            this.panel1.Controls.Add(this.addCrsBtn);
            this.panel1.Controls.Add(this.InputEmail);
            this.panel1.Controls.Add(this.InputLname);
            this.panel1.Controls.Add(this.InputFname);
            this.panel1.Controls.Add(this.crsDesc);
            this.panel1.Controls.Add(this.crsAbr);
            this.panel1.Controls.Add(this.crsName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(118, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 335);
            this.panel1.TabIndex = 11;
            // 
            // viewCourses
            // 
            this.viewCourses.Location = new System.Drawing.Point(439, 16);
            this.viewCourses.Name = "viewCourses";
            this.viewCourses.Size = new System.Drawing.Size(105, 23);
            this.viewCourses.TabIndex = 32;
            this.viewCourses.Text = "View All Courses";
            this.viewCourses.UseVisualStyleBackColor = true;
            this.viewCourses.Click += new System.EventHandler(this.viewCourses_Click);
            // 
            // addCrsBtn
            // 
            this.addCrsBtn.Location = new System.Drawing.Point(225, 287);
            this.addCrsBtn.Name = "addCrsBtn";
            this.addCrsBtn.Size = new System.Drawing.Size(75, 23);
            this.addCrsBtn.TabIndex = 31;
            this.addCrsBtn.Text = "Add Course";
            this.addCrsBtn.UseVisualStyleBackColor = true;
            this.addCrsBtn.Click += new System.EventHandler(this.addCrsBtn_Click);
            // 
            // InputEmail
            // 
            this.InputEmail.Location = new System.Drawing.Point(225, 169);
            this.InputEmail.Multiline = true;
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(199, 81);
            this.InputEmail.TabIndex = 25;
            // 
            // InputLname
            // 
            this.InputLname.Location = new System.Drawing.Point(225, 131);
            this.InputLname.Name = "InputLname";
            this.InputLname.Size = new System.Drawing.Size(200, 20);
            this.InputLname.TabIndex = 21;
            // 
            // InputFname
            // 
            this.InputFname.Location = new System.Drawing.Point(225, 96);
            this.InputFname.Name = "InputFname";
            this.InputFname.Size = new System.Drawing.Size(200, 20);
            this.InputFname.TabIndex = 20;
            // 
            // crsDesc
            // 
            this.crsDesc.AutoSize = true;
            this.crsDesc.Location = new System.Drawing.Point(123, 172);
            this.crsDesc.Name = "crsDesc";
            this.crsDesc.Size = new System.Drawing.Size(96, 13);
            this.crsDesc.TabIndex = 15;
            this.crsDesc.Text = "Course Description";
            // 
            // crsAbr
            // 
            this.crsAbr.AutoSize = true;
            this.crsAbr.Location = new System.Drawing.Point(123, 134);
            this.crsAbr.Name = "crsAbr";
            this.crsAbr.Size = new System.Drawing.Size(102, 13);
            this.crsAbr.TabIndex = 12;
            this.crsAbr.Text = "Course Abbreviation";
            // 
            // crsName
            // 
            this.crsName.AutoSize = true;
            this.crsName.Location = new System.Drawing.Point(123, 96);
            this.crsName.Name = "crsName";
            this.crsName.Size = new System.Drawing.Size(71, 13);
            this.crsName.TabIndex = 11;
            this.crsName.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Course";
            // 
            // Add_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Courses";
            this.Text = "Add_Courses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button viewCourses;
        private System.Windows.Forms.Button addCrsBtn;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.TextBox InputLname;
        private System.Windows.Forms.TextBox InputFname;
        private System.Windows.Forms.Label crsDesc;
        private System.Windows.Forms.Label crsAbr;
        private System.Windows.Forms.Label crsName;
        private System.Windows.Forms.Label label1;
    }
}