namespace StudentManagementSystem
{
    partial class CrerateTimeTableEnviroment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NoOfWeeks = new System.Windows.Forms.TextBox();
            this.HrPerClass = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.selectSemester = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.selectSemester);
            this.panel1.Controls.Add(this.startDate);
            this.panel1.Controls.Add(this.HrPerClass);
            this.panel1.Controls.Add(this.NoOfWeeks);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(145, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 336);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE ENVIROMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. Of Weeks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hour Per Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Date Of Semester";
            // 
            // NoOfWeeks
            // 
            this.NoOfWeeks.Location = new System.Drawing.Point(214, 98);
            this.NoOfWeeks.Name = "NoOfWeeks";
            this.NoOfWeeks.Size = new System.Drawing.Size(247, 20);
            this.NoOfWeeks.TabIndex = 5;
            // 
            // HrPerClass
            // 
            this.HrPerClass.Location = new System.Drawing.Point(214, 143);
            this.HrPerClass.Name = "HrPerClass";
            this.HrPerClass.Size = new System.Drawing.Size(247, 20);
            this.HrPerClass.TabIndex = 6;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(214, 196);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(247, 20);
            this.startDate.TabIndex = 7;
            // 
            // selectSemester
            // 
            this.selectSemester.FormattingEnabled = true;
            this.selectSemester.Location = new System.Drawing.Point(214, 53);
            this.selectSemester.Name = "selectSemester";
            this.selectSemester.Size = new System.Drawing.Size(247, 21);
            this.selectSemester.TabIndex = 8;
            // 
            // CrerateTimeTableEnviroment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CrerateTimeTableEnviroment";
            this.Text = "CrerateTimeTableEnviroment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectSemester;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.TextBox HrPerClass;
        private System.Windows.Forms.TextBox NoOfWeeks;
    }
}