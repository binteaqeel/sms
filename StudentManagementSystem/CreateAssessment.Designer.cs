namespace StudentManagementSystem
{
    partial class CreateAssessment
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
            this.label6 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.assessmentType = new System.Windows.Forms.TextBox();
            this.Desc = new System.Windows.Forms.TextBox();
            this.totalMarks = new System.Windows.Forms.TextBox();
            this.HOD = new System.Windows.Forms.DateTimePicker();
            this.SD = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.SD);
            this.panel1.Controls.Add(this.HOD);
            this.panel1.Controls.Add(this.totalMarks);
            this.panel1.Controls.Add(this.Desc);
            this.panel1.Controls.Add(this.assessmentType);
            this.panel1.Controls.Add(this.createBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(49, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 426);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE ASSESSMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assessment Type ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Marks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hand Over Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Submission Date";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(320, 336);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(87, 31);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "CREATE";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // assessmentType
            // 
            this.assessmentType.Location = new System.Drawing.Point(373, 64);
            this.assessmentType.Name = "assessmentType";
            this.assessmentType.Size = new System.Drawing.Size(249, 20);
            this.assessmentType.TabIndex = 7;
            // 
            // Desc
            // 
            this.Desc.Location = new System.Drawing.Point(373, 118);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(249, 20);
            this.Desc.TabIndex = 8;
            // 
            // totalMarks
            // 
            this.totalMarks.Location = new System.Drawing.Point(373, 166);
            this.totalMarks.Name = "totalMarks";
            this.totalMarks.Size = new System.Drawing.Size(249, 20);
            this.totalMarks.TabIndex = 9;
            // 
            // HOD
            // 
            this.HOD.Location = new System.Drawing.Point(373, 216);
            this.HOD.Name = "HOD";
            this.HOD.Size = new System.Drawing.Size(249, 20);
            this.HOD.TabIndex = 10;
            // 
            // SD
            // 
            this.SD.Location = new System.Drawing.Point(373, 271);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(249, 20);
            this.SD.TabIndex = 11;
            // 
            // CreateAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CreateAssessment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAssessment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker SD;
        private System.Windows.Forms.DateTimePicker HOD;
        private System.Windows.Forms.TextBox totalMarks;
        private System.Windows.Forms.TextBox Desc;
        private System.Windows.Forms.TextBox assessmentType;
        private System.Windows.Forms.Button createBtn;
    }
}