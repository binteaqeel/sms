namespace StudentManagementSystem
{
    partial class UpdateDeleteCrs
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
            this.updBtn = new System.Windows.Forms.Button();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.InputLname = new System.Windows.Forms.TextBox();
            this.InputFname = new System.Windows.Forms.TextBox();
            this.crsDesc = new System.Windows.Forms.Label();
            this.crsAbr = new System.Windows.Forms.Label();
            this.crsName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dltBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dltBtn);
            this.panel1.Controls.Add(this.updBtn);
            this.panel1.Controls.Add(this.InputEmail);
            this.panel1.Controls.Add(this.InputLname);
            this.panel1.Controls.Add(this.InputFname);
            this.panel1.Controls.Add(this.crsDesc);
            this.panel1.Controls.Add(this.crsAbr);
            this.panel1.Controls.Add(this.crsName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(118, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 335);
            this.panel1.TabIndex = 12;
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(164, 282);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(75, 23);
            this.updBtn.TabIndex = 31;
            this.updBtn.Text = "Upadte";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
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
            this.label1.Location = new System.Drawing.Point(222, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Course Update Form";
            // 
            // dltBtn
            // 
            this.dltBtn.Location = new System.Drawing.Point(267, 282);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(75, 23);
            this.dltBtn.TabIndex = 32;
            this.dltBtn.Text = "Delete";
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // UpdateDeleteCrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateDeleteCrs";
            this.Text = "UpdateDeleteCrs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.TextBox InputLname;
        private System.Windows.Forms.TextBox InputFname;
        private System.Windows.Forms.Label crsDesc;
        private System.Windows.Forms.Label crsAbr;
        private System.Windows.Forms.Label crsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dltBtn;
    }
}