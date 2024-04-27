namespace StudentManagementSystem
{
    partial class EnrollStdPaid
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
            this.label2 = new System.Windows.Forms.Label();
            this.viewStds = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.semComboBox = new System.Windows.Forms.ComboBox();
            this.enrollBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYMENT STATUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Students";
            // 
            // viewStds
            // 
            this.viewStds.Location = new System.Drawing.Point(340, 112);
            this.viewStds.Name = "viewStds";
            this.viewStds.Size = new System.Drawing.Size(257, 436);
            this.viewStds.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Semester";
            // 
            // semComboBox
            // 
            this.semComboBox.FormattingEnabled = true;
            this.semComboBox.Location = new System.Drawing.Point(340, 59);
            this.semComboBox.Name = "semComboBox";
            this.semComboBox.Size = new System.Drawing.Size(166, 21);
            this.semComboBox.TabIndex = 4;
            this.semComboBox.SelectedIndexChanged += new System.EventHandler(this.semComboBox_SelectedIndexChanged);
            // 
            // enrollBtn
            // 
            this.enrollBtn.Location = new System.Drawing.Point(665, 48);
            this.enrollBtn.Name = "enrollBtn";
            this.enrollBtn.Size = new System.Drawing.Size(75, 23);
            this.enrollBtn.TabIndex = 5;
            this.enrollBtn.Text = "ENROLL";
            this.enrollBtn.UseVisualStyleBackColor = true;
            this.enrollBtn.Click += new System.EventHandler(this.enrollBtn_Click);
            // 
            // EnrollStdPaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.enrollBtn);
            this.Controls.Add(this.semComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewStds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EnrollStdPaid";
            this.Text = "EnrollStdPaid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel viewStds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox semComboBox;
        private System.Windows.Forms.Button enrollBtn;
    }
}