namespace StudentManagementSystem
{
    partial class Student_Admission_Form
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
            this.InputRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submitBtn = new System.Windows.Forms.Button();
            this.RbtnOther = new System.Windows.Forms.RadioButton();
            this.ConPas = new System.Windows.Forms.TextBox();
            this.InputPas = new System.Windows.Forms.TextBox();
            this.InputAdres = new System.Windows.Forms.TextBox();
            this.InputPhNum = new System.Windows.Forms.TextBox();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.RbtnFemale = new System.Windows.Forms.RadioButton();
            this.RbtnMale = new System.Windows.Forms.RadioButton();
            this.InputDOB = new System.Windows.Forms.DateTimePicker();
            this.InputLname = new System.Windows.Forms.TextBox();
            this.InputFname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewStudents = new System.Windows.Forms.Button();
            this.viewAdmins = new System.Windows.Forms.Button();
            this.viewInstructor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputRole
            // 
            this.InputRole.AllowDrop = true;
            this.InputRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputRole.FormattingEnabled = true;
            this.InputRole.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Admin"});
            this.InputRole.Location = new System.Drawing.Point(224, 50);
            this.InputRole.Name = "InputRole";
            this.InputRole.Size = new System.Drawing.Size(200, 21);
            this.InputRole.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Role";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.viewInstructor);
            this.panel1.Controls.Add(this.viewAdmins);
            this.panel1.Controls.Add(this.viewStudents);
            this.panel1.Controls.Add(this.submitBtn);
            this.panel1.Controls.Add(this.RbtnOther);
            this.panel1.Controls.Add(this.ConPas);
            this.panel1.Controls.Add(this.InputPas);
            this.panel1.Controls.Add(this.InputAdres);
            this.panel1.Controls.Add(this.InputPhNum);
            this.panel1.Controls.Add(this.InputEmail);
            this.panel1.Controls.Add(this.RbtnFemale);
            this.panel1.Controls.Add(this.RbtnMale);
            this.panel1.Controls.Add(this.InputDOB);
            this.panel1.Controls.Add(this.InputLname);
            this.panel1.Controls.Add(this.InputFname);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.InputRole);
            this.panel1.Location = new System.Drawing.Point(117, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 426);
            this.panel1.TabIndex = 10;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(224, 390);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 31;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // RbtnOther
            // 
            this.RbtnOther.AutoSize = true;
            this.RbtnOther.Location = new System.Drawing.Point(365, 187);
            this.RbtnOther.Name = "RbtnOther";
            this.RbtnOther.Size = new System.Drawing.Size(51, 17);
            this.RbtnOther.TabIndex = 30;
            this.RbtnOther.TabStop = true;
            this.RbtnOther.Text = "Other";
            this.RbtnOther.UseVisualStyleBackColor = true;
            // 
            // ConPas
            // 
            this.ConPas.Location = new System.Drawing.Point(224, 337);
            this.ConPas.Name = "ConPas";
            this.ConPas.Size = new System.Drawing.Size(200, 20);
            this.ConPas.TabIndex = 29;
            // 
            // InputPas
            // 
            this.InputPas.Location = new System.Drawing.Point(224, 303);
            this.InputPas.Name = "InputPas";
            this.InputPas.Size = new System.Drawing.Size(200, 20);
            this.InputPas.TabIndex = 28;
            // 
            // InputAdres
            // 
            this.InputAdres.Location = new System.Drawing.Point(224, 273);
            this.InputAdres.Name = "InputAdres";
            this.InputAdres.Size = new System.Drawing.Size(200, 20);
            this.InputAdres.TabIndex = 27;
            // 
            // InputPhNum
            // 
            this.InputPhNum.Location = new System.Drawing.Point(224, 241);
            this.InputPhNum.Name = "InputPhNum";
            this.InputPhNum.Size = new System.Drawing.Size(200, 20);
            this.InputPhNum.TabIndex = 26;
            // 
            // InputEmail
            // 
            this.InputEmail.Location = new System.Drawing.Point(224, 215);
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(200, 20);
            this.InputEmail.TabIndex = 25;
            // 
            // RbtnFemale
            // 
            this.RbtnFemale.AutoSize = true;
            this.RbtnFemale.Location = new System.Drawing.Point(295, 187);
            this.RbtnFemale.Name = "RbtnFemale";
            this.RbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.RbtnFemale.TabIndex = 24;
            this.RbtnFemale.TabStop = true;
            this.RbtnFemale.Text = "Female";
            this.RbtnFemale.UseVisualStyleBackColor = true;
            // 
            // RbtnMale
            // 
            this.RbtnMale.AutoSize = true;
            this.RbtnMale.Location = new System.Drawing.Point(224, 187);
            this.RbtnMale.Name = "RbtnMale";
            this.RbtnMale.Size = new System.Drawing.Size(48, 17);
            this.RbtnMale.TabIndex = 23;
            this.RbtnMale.TabStop = true;
            this.RbtnMale.Text = "Male";
            this.RbtnMale.UseVisualStyleBackColor = true;
            // 
            // InputDOB
            // 
            this.InputDOB.Location = new System.Drawing.Point(224, 153);
            this.InputDOB.Name = "InputDOB";
            this.InputDOB.Size = new System.Drawing.Size(200, 20);
            this.InputDOB.TabIndex = 22;
            // 
            // InputLname
            // 
            this.InputLname.Location = new System.Drawing.Point(224, 127);
            this.InputLname.Name = "InputLname";
            this.InputLname.Size = new System.Drawing.Size(200, 20);
            this.InputLname.TabIndex = 21;
            // 
            // InputFname
            // 
            this.InputFname.Location = new System.Drawing.Point(224, 89);
            this.InputFname.Name = "InputFname";
            this.InputFname.Size = new System.Drawing.Size(200, 20);
            this.InputFname.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(123, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Confirm Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Admission Form";
            // 
            // viewStudents
            // 
            this.viewStudents.Location = new System.Drawing.Point(439, 16);
            this.viewStudents.Name = "viewStudents";
            this.viewStudents.Size = new System.Drawing.Size(105, 23);
            this.viewStudents.TabIndex = 32;
            this.viewStudents.Text = "View All Students";
            this.viewStudents.UseVisualStyleBackColor = true;
            this.viewStudents.Click += new System.EventHandler(this.viewStudents_Click);
            // 
            // viewAdmins
            // 
            this.viewAdmins.Location = new System.Drawing.Point(439, 74);
            this.viewAdmins.Name = "viewAdmins";
            this.viewAdmins.Size = new System.Drawing.Size(105, 23);
            this.viewAdmins.TabIndex = 33;
            this.viewAdmins.Text = "View All Admins";
            this.viewAdmins.UseVisualStyleBackColor = true;
            this.viewAdmins.Click += new System.EventHandler(this.viewAdmins_Click);
            // 
            // viewInstructor
            // 
            this.viewInstructor.Location = new System.Drawing.Point(439, 45);
            this.viewInstructor.Name = "viewInstructor";
            this.viewInstructor.Size = new System.Drawing.Size(105, 23);
            this.viewInstructor.TabIndex = 34;
            this.viewInstructor.Text = "View All Instructors";
            this.viewInstructor.UseVisualStyleBackColor = true;
            this.viewInstructor.Click += new System.EventHandler(this.viewInstructor_Click);
            // 
            // Student_Admission_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Student_Admission_Form";
            this.Text = "Student_Admission_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox InputRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker InputDOB;
        private System.Windows.Forms.TextBox InputLname;
        private System.Windows.Forms.TextBox InputFname;
        private System.Windows.Forms.TextBox ConPas;
        private System.Windows.Forms.TextBox InputPas;
        private System.Windows.Forms.TextBox InputAdres;
        private System.Windows.Forms.TextBox InputPhNum;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.RadioButton RbtnFemale;
        private System.Windows.Forms.RadioButton RbtnMale;
        private System.Windows.Forms.RadioButton RbtnOther;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button viewStudents;
        private System.Windows.Forms.Button viewInstructor;
        private System.Windows.Forms.Button viewAdmins;
    }
}