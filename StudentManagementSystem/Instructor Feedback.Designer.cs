namespace StudentManagementSystem
{
    partial class Instructor_Feedback
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
            this.showInstFdbk = new System.Windows.Forms.Button();
            this.instFdbkToAdmin = new System.Windows.Forms.Button();
            this.instFdbkTostd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.showInstFdbk);
            this.panel1.Controls.Add(this.instFdbkToAdmin);
            this.panel1.Controls.Add(this.instFdbkTostd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 537);
            this.panel1.TabIndex = 2;
            // 
            // showInstFdbk
            // 
            this.showInstFdbk.Location = new System.Drawing.Point(624, 12);
            this.showInstFdbk.Name = "showInstFdbk";
            this.showInstFdbk.Size = new System.Drawing.Size(149, 38);
            this.showInstFdbk.TabIndex = 3;
            this.showInstFdbk.Text = "Show My Feedbacks";
            this.showInstFdbk.UseVisualStyleBackColor = true;
            this.showInstFdbk.Click += new System.EventHandler(this.showInstFdbk_Click);
            // 
            // instFdbkToAdmin
            // 
            this.instFdbkToAdmin.Location = new System.Drawing.Point(507, 84);
            this.instFdbkToAdmin.Name = "instFdbkToAdmin";
            this.instFdbkToAdmin.Size = new System.Drawing.Size(138, 39);
            this.instFdbkToAdmin.TabIndex = 2;
            this.instFdbkToAdmin.Text = "Feedback To Institute";
            this.instFdbkToAdmin.UseVisualStyleBackColor = true;
            this.instFdbkToAdmin.Click += new System.EventHandler(this.instFdbkToAdmin_Click);
            // 
            // instFdbkTostd
            // 
            this.instFdbkTostd.Location = new System.Drawing.Point(163, 84);
            this.instFdbkTostd.Name = "instFdbkTostd";
            this.instFdbkTostd.Size = new System.Drawing.Size(137, 39);
            this.instFdbkTostd.TabIndex = 1;
            this.instFdbkTostd.Text = "Feedback To Student";
            this.instFdbkTostd.UseVisualStyleBackColor = true;
            this.instFdbkTostd.Click += new System.EventHandler(this.instFdbkTostd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FEEDBACK FORM";
            // 
            // Instructor_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.panel1);
            this.Name = "Instructor_Feedback";
            this.Text = "Instructor_Feedback";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showInstFdbk;
        private System.Windows.Forms.Button instFdbkToAdmin;
        private System.Windows.Forms.Button instFdbkTostd;
        private System.Windows.Forms.Label label1;
    }
}