﻿namespace StudentManagementSystem
{
    partial class UpgradeStds
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
            this.UpgStdsBtn = new System.Windows.Forms.Button();
            this.semComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ViewStds = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPGRADE STUDENTS";
            // 
            // UpgStdsBtn
            // 
            this.UpgStdsBtn.Location = new System.Drawing.Point(691, 40);
            this.UpgStdsBtn.Name = "UpgStdsBtn";
            this.UpgStdsBtn.Size = new System.Drawing.Size(75, 23);
            this.UpgStdsBtn.TabIndex = 1;
            this.UpgStdsBtn.Text = "UPGRADE";
            this.UpgStdsBtn.UseVisualStyleBackColor = true;
            this.UpgStdsBtn.Click += new System.EventHandler(this.UpgStdsBtn_Click);
            // 
            // semComboBox
            // 
            this.semComboBox.FormattingEnabled = true;
            this.semComboBox.Location = new System.Drawing.Point(450, 74);
            this.semComboBox.Name = "semComboBox";
            this.semComboBox.Size = new System.Drawing.Size(187, 21);
            this.semComboBox.TabIndex = 2;
            this.semComboBox.SelectedIndexChanged += new System.EventHandler(this.semComboBox_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Upgrade To Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Students:";
            // 
            // ViewStds
            // 
            this.ViewStds.Location = new System.Drawing.Point(450, 116);
            this.ViewStds.Name = "ViewStds";
            this.ViewStds.Size = new System.Drawing.Size(213, 322);
            this.ViewStds.TabIndex = 5;
            // 
            // UpgradeStds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.ViewStds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.semComboBox);
            this.Controls.Add(this.UpgStdsBtn);
            this.Controls.Add(this.label1);
            this.Name = "UpgradeStds";
            this.Text = "UpgradeStds";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpgStdsBtn;
        private System.Windows.Forms.ComboBox semComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel ViewStds;
    }
}