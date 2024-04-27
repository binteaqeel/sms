namespace StudentManagementSystem
{
    partial class AssessmentEvaluation
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
            this.AssessTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewGrading = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.viewGrading);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AssessTypeComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 530);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EVALUATION";
            // 
            // AssessTypeComboBox
            // 
            this.AssessTypeComboBox.FormattingEnabled = true;
            this.AssessTypeComboBox.Location = new System.Drawing.Point(405, 60);
            this.AssessTypeComboBox.Name = "AssessTypeComboBox";
            this.AssessTypeComboBox.Size = new System.Drawing.Size(181, 21);
            this.AssessTypeComboBox.TabIndex = 1;
            this.AssessTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.AssessTypeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Evaluation Type";
            // 
            // viewGrading
            // 
            this.viewGrading.Location = new System.Drawing.Point(3, 92);
            this.viewGrading.Name = "viewGrading";
            this.viewGrading.Size = new System.Drawing.Size(759, 425);
            this.viewGrading.TabIndex = 3;
            // 
            // AssessmentEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.panel1);
            this.Name = "AssessmentEvaluation";
            this.Text = "AssessmentEvaluation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AssessTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel viewGrading;
    }
}