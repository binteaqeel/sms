namespace StudentManagementSystem
{
    partial class AddClass
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
            this.label1 = new System.Windows.Forms.Label();
            this.CrsComboBox = new System.Windows.Forms.ComboBox();
            this.InstComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreditHrs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submitClass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SemComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.SemComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.submitClass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CreditHrs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.InstComboBox);
            this.panel1.Controls.Add(this.CrsComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 395);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.e);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Class";
            // 
            // CrsComboBox
            // 
            this.CrsComboBox.FormattingEnabled = true;
            this.CrsComboBox.Location = new System.Drawing.Point(394, 82);
            this.CrsComboBox.Name = "CrsComboBox";
            this.CrsComboBox.Size = new System.Drawing.Size(293, 21);
            this.CrsComboBox.TabIndex = 1;
            this.CrsComboBox.SelectedIndexChanged += new System.EventHandler(this.CrsComboBox_SelectedIndexChanged_1);
            // 
            // InstComboBox
            // 
            this.InstComboBox.FormattingEnabled = true;
            this.InstComboBox.Location = new System.Drawing.Point(394, 128);
            this.InstComboBox.Name = "InstComboBox";
            this.InstComboBox.Size = new System.Drawing.Size(148, 21);
            this.InstComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Instructor";
            // 
            // CreditHrs
            // 
            this.CreditHrs.Location = new System.Drawing.Point(393, 176);
            this.CreditHrs.Name = "CreditHrs";
            this.CreditHrs.Size = new System.Drawing.Size(149, 20);
            this.CreditHrs.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CreditHours";
            // 
            // submitClass
            // 
            this.submitClass.Location = new System.Drawing.Point(348, 274);
            this.submitClass.Name = "submitClass";
            this.submitClass.Size = new System.Drawing.Size(75, 23);
            this.submitClass.TabIndex = 7;
            this.submitClass.Text = "Create";
            this.submitClass.UseVisualStyleBackColor = true;
            this.submitClass.Click += new System.EventHandler(this.submitClass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Semester";
            // 
            // SemComboBox
            // 
            this.SemComboBox.FormattingEnabled = true;
            this.SemComboBox.Location = new System.Drawing.Point(394, 41);
            this.SemComboBox.Name = "SemComboBox";
            this.SemComboBox.Size = new System.Drawing.Size(148, 21);
            this.SemComboBox.TabIndex = 9;
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddClass";
            this.Text = "AddClass";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CreditHrs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox InstComboBox;
        private System.Windows.Forms.ComboBox CrsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitClass;
        private System.Windows.Forms.ComboBox SemComboBox;
        private System.Windows.Forms.Label label5;
    }
}