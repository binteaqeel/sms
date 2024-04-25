namespace StudentManagementSystem
{
    partial class Admin_Feedback
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
            this.showAdFdbk = new System.Windows.Forms.Button();
            this.adFdbkToStd = new System.Windows.Forms.Button();
            this.adFdbkToInst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowUsersFdbk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.ShowUsersFdbk);
            this.panel1.Controls.Add(this.showAdFdbk);
            this.panel1.Controls.Add(this.adFdbkToStd);
            this.panel1.Controls.Add(this.adFdbkToInst);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 537);
            this.panel1.TabIndex = 1;
            // 
            // showAdFdbk
            // 
            this.showAdFdbk.Location = new System.Drawing.Point(624, 12);
            this.showAdFdbk.Name = "showAdFdbk";
            this.showAdFdbk.Size = new System.Drawing.Size(149, 38);
            this.showAdFdbk.TabIndex = 3;
            this.showAdFdbk.Text = "Show My Feedbacks";
            this.showAdFdbk.UseVisualStyleBackColor = true;
            this.showAdFdbk.Click += new System.EventHandler(this.showAdFdbk_Click);
            // 
            // adFdbkToStd
            // 
            this.adFdbkToStd.Location = new System.Drawing.Point(507, 84);
            this.adFdbkToStd.Name = "adFdbkToStd";
            this.adFdbkToStd.Size = new System.Drawing.Size(138, 39);
            this.adFdbkToStd.TabIndex = 2;
            this.adFdbkToStd.Text = "Feedback To Students";
            this.adFdbkToStd.UseVisualStyleBackColor = true;
            this.adFdbkToStd.Click += new System.EventHandler(this.adFdbkToStd_Click);
            // 
            // adFdbkToInst
            // 
            this.adFdbkToInst.Location = new System.Drawing.Point(163, 84);
            this.adFdbkToInst.Name = "adFdbkToInst";
            this.adFdbkToInst.Size = new System.Drawing.Size(137, 39);
            this.adFdbkToInst.TabIndex = 1;
            this.adFdbkToInst.Text = "Feedback To Instructor";
            this.adFdbkToInst.UseVisualStyleBackColor = true;
            this.adFdbkToInst.Click += new System.EventHandler(this.adFdbkToInst_Click);
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
            // ShowUsersFdbk
            // 
            this.ShowUsersFdbk.Location = new System.Drawing.Point(3, 12);
            this.ShowUsersFdbk.Name = "ShowUsersFdbk";
            this.ShowUsersFdbk.Size = new System.Drawing.Size(149, 38);
            this.ShowUsersFdbk.TabIndex = 4;
            this.ShowUsersFdbk.Text = "Show Users Feedbacks";
            this.ShowUsersFdbk.UseVisualStyleBackColor = true;
            this.ShowUsersFdbk.Click += new System.EventHandler(this.ShowUsersFdbk_Click);
            // 
            // Admin_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Feedback";
            this.Text = "Admin_Feedback";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showAdFdbk;
        private System.Windows.Forms.Button adFdbkToStd;
        private System.Windows.Forms.Button adFdbkToInst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowUsersFdbk;
    }
}