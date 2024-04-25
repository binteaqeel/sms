namespace StudentManagementSystem
{
    partial class Show_Feedback
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Table1Hd = new System.Windows.Forms.Label();
            this.Table2Hd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 117);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 127);
            this.dataGridView2.TabIndex = 1;
            // 
            // Table1Hd
            // 
            this.Table1Hd.AutoSize = true;
            this.Table1Hd.Location = new System.Drawing.Point(344, 13);
            this.Table1Hd.Name = "Table1Hd";
            this.Table1Hd.Size = new System.Drawing.Size(35, 13);
            this.Table1Hd.TabIndex = 2;
            this.Table1Hd.Text = "label1";
            // 
            // Table2Hd
            // 
            this.Table2Hd.AutoSize = true;
            this.Table2Hd.Location = new System.Drawing.Point(344, 238);
            this.Table2Hd.Name = "Table2Hd";
            this.Table2Hd.Size = new System.Drawing.Size(35, 13);
            this.Table2Hd.TabIndex = 3;
            this.Table2Hd.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.Table1Hd);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.Table2Hd);
            this.panel1.Location = new System.Drawing.Point(5, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 450);
            this.panel1.TabIndex = 4;
            // 
            // Show_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.panel1);
            this.Name = "Show_Feedback";
            this.Text = "Show_Feedback";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label Table1Hd;
        private System.Windows.Forms.Label Table2Hd;
        private System.Windows.Forms.Panel panel1;
    }
}