namespace StudentManagementSystem
{
    partial class InstExpertise
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
            this.viewCourses = new System.Windows.Forms.FlowLayoutPanel();
            this.subExp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check Your Expertise Here";
            // 
            // viewCourses
            // 
            this.viewCourses.Location = new System.Drawing.Point(296, 152);
            this.viewCourses.Name = "viewCourses";
            this.viewCourses.Size = new System.Drawing.Size(237, 226);
            this.viewCourses.TabIndex = 0;
            // 
            // subExp
            // 
            this.subExp.Location = new System.Drawing.Point(525, 99);
            this.subExp.Name = "subExp";
            this.subExp.Size = new System.Drawing.Size(102, 30);
            this.subExp.TabIndex = 2;
            this.subExp.Text = "Submit Expertise";
            this.subExp.UseVisualStyleBackColor = true;
            this.subExp.Click += new System.EventHandler(this.subExp_Click);
            // 
            // InstExpertise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subExp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewCourses);
            this.Name = "InstExpertise";
            this.Text = "InstExpertise";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel viewCourses;
        private System.Windows.Forms.Button subExp;
    }
}