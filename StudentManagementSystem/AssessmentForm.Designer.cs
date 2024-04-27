namespace StudentManagementSystem
{
    partial class AssessmentForm
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
            this.createAssessBtn = new System.Windows.Forms.Button();
            this.evalAssessBtn = new System.Windows.Forms.Button();
            this.FinalMarksBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createAssessBtn
            // 
            this.createAssessBtn.Location = new System.Drawing.Point(381, 27);
            this.createAssessBtn.Name = "createAssessBtn";
            this.createAssessBtn.Size = new System.Drawing.Size(119, 33);
            this.createAssessBtn.TabIndex = 0;
            this.createAssessBtn.Text = "Create Assessment";
            this.createAssessBtn.UseVisualStyleBackColor = true;
            this.createAssessBtn.Click += new System.EventHandler(this.createAssessBtn_Click);
            // 
            // evalAssessBtn
            // 
            this.evalAssessBtn.Location = new System.Drawing.Point(381, 107);
            this.evalAssessBtn.Name = "evalAssessBtn";
            this.evalAssessBtn.Size = new System.Drawing.Size(119, 33);
            this.evalAssessBtn.TabIndex = 1;
            this.evalAssessBtn.Text = "Evaluate Assessment";
            this.evalAssessBtn.UseVisualStyleBackColor = true;
            this.evalAssessBtn.Click += new System.EventHandler(this.evalAssessBtn_Click);
            // 
            // FinalMarksBtn
            // 
            this.FinalMarksBtn.Location = new System.Drawing.Point(381, 187);
            this.FinalMarksBtn.Name = "FinalMarksBtn";
            this.FinalMarksBtn.Size = new System.Drawing.Size(119, 33);
            this.FinalMarksBtn.TabIndex = 2;
            this.FinalMarksBtn.Text = "Finalize Marks";
            this.FinalMarksBtn.UseVisualStyleBackColor = true;
            this.FinalMarksBtn.Click += new System.EventHandler(this.FinalMarksBtn_Click);
            // 
            // AssessmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FinalMarksBtn);
            this.Controls.Add(this.evalAssessBtn);
            this.Controls.Add(this.createAssessBtn);
            this.Name = "AssessmentForm";
            this.Text = "AssessmentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AssessmentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAssessBtn;
        private System.Windows.Forms.Button evalAssessBtn;
        private System.Windows.Forms.Button FinalMarksBtn;
    }
}