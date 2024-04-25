namespace StudentManagementSystem
{
    partial class LogInForm
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
            this.InputRole = new System.Windows.Forms.ComboBox();
            this.InputPass = new System.Windows.Forms.TextBox();
            this.InputId = new System.Windows.Forms.TextBox();
            this.logInbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.InputRole);
            this.panel1.Controls.Add(this.InputPass);
            this.panel1.Controls.Add(this.InputId);
            this.panel1.Controls.Add(this.logInbtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(194, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 340);
            this.panel1.TabIndex = 1;
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
            this.InputRole.Location = new System.Drawing.Point(149, 201);
            this.InputRole.Name = "InputRole";
            this.InputRole.Size = new System.Drawing.Size(178, 21);
            this.InputRole.TabIndex = 7;
            // 
            // InputPass
            // 
            this.InputPass.Location = new System.Drawing.Point(149, 135);
            this.InputPass.Name = "InputPass";
            this.InputPass.Size = new System.Drawing.Size(178, 20);
            this.InputPass.TabIndex = 6;
            // 
            // InputId
            // 
            this.InputId.Location = new System.Drawing.Point(149, 71);
            this.InputId.Name = "InputId";
            this.InputId.Size = new System.Drawing.Size(178, 20);
            this.InputId.TabIndex = 5;
            // 
            // logInbtn
            // 
            this.logInbtn.Location = new System.Drawing.Point(127, 259);
            this.logInbtn.Name = "logInbtn";
            this.logInbtn.Size = new System.Drawing.Size(172, 36);
            this.logInbtn.TabIndex = 4;
            this.logInbtn.Text = "LOGIN";
            this.logInbtn.UseVisualStyleBackColor = true;
            this.logInbtn.Click += new System.EventHandler(this.logInbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ROLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(46, 71);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN FORM";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "LogInForm";
            this.Text = "Log In ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox InputRole;
        private System.Windows.Forms.TextBox InputPass;
        private System.Windows.Forms.TextBox InputId;
        private System.Windows.Forms.Button logInbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
    }
}

