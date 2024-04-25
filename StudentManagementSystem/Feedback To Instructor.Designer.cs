namespace StudentManagementSystem
{
    partial class Feedback_To_Instructor
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
            this.Closebtn = new System.Windows.Forms.Button();
            this.SubmitFdbkBtn = new System.Windows.Forms.Button();
            this.InstFdbkDesc = new System.Windows.Forms.TextBox();
            this.instName = new System.Windows.Forms.TextBox();
            this.instId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.instIds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(452, 371);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(75, 23);
            this.Closebtn.TabIndex = 15;
            this.Closebtn.Text = "Cancel";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // SubmitFdbkBtn
            // 
            this.SubmitFdbkBtn.Location = new System.Drawing.Point(247, 371);
            this.SubmitFdbkBtn.Name = "SubmitFdbkBtn";
            this.SubmitFdbkBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitFdbkBtn.TabIndex = 14;
            this.SubmitFdbkBtn.Text = "Submit";
            this.SubmitFdbkBtn.UseVisualStyleBackColor = true;
            this.SubmitFdbkBtn.Click += new System.EventHandler(this.SubmitFdbkBtn_Click);
            // 
            // InstFdbkDesc
            // 
            this.InstFdbkDesc.Location = new System.Drawing.Point(372, 214);
            this.InstFdbkDesc.Multiline = true;
            this.InstFdbkDesc.Name = "InstFdbkDesc";
            this.InstFdbkDesc.Size = new System.Drawing.Size(198, 113);
            this.InstFdbkDesc.TabIndex = 13;
            // 
            // instName
            // 
            this.instName.Location = new System.Drawing.Point(372, 134);
            this.instName.Multiline = true;
            this.instName.Name = "instName";
            this.instName.Size = new System.Drawing.Size(198, 21);
            this.instName.TabIndex = 12;
            // 
            // instId
            // 
            this.instId.Location = new System.Drawing.Point(372, 56);
            this.instId.Multiline = true;
            this.instId.Name = "instId";
            this.instId.Size = new System.Drawing.Size(198, 21);
            this.instId.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Feedback Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Instructor Name:";
            // 
            // instIds
            // 
            this.instIds.AutoSize = true;
            this.instIds.Location = new System.Drawing.Point(231, 56);
            this.instIds.Name = "instIds";
            this.instIds.Size = new System.Drawing.Size(68, 13);
            this.instIds.TabIndex = 8;
            this.instIds.Text = "Instructor ID:";
            // 
            // Feedback_To_Instructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.SubmitFdbkBtn);
            this.Controls.Add(this.InstFdbkDesc);
            this.Controls.Add(this.instName);
            this.Controls.Add(this.instId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.instIds);
            this.Name = "Feedback_To_Instructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback_To_Instructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button SubmitFdbkBtn;
        private System.Windows.Forms.TextBox InstFdbkDesc;
        private System.Windows.Forms.TextBox instName;
        private System.Windows.Forms.TextBox instId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label instIds;
    }
}