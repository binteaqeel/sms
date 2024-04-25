namespace StudentManagementSystem
{
    partial class View_Users
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
            this.displayUsers = new System.Windows.Forms.DataGridView();
            this.hd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // displayUsers
            // 
            this.displayUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayUsers.Location = new System.Drawing.Point(12, 60);
            this.displayUsers.Name = "displayUsers";
            this.displayUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayUsers.Size = new System.Drawing.Size(1016, 339);
            this.displayUsers.TabIndex = 0;
            this.displayUsers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayUsers_CellContentDoubleClick);
            this.displayUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.displayUsers_MouseDoubleClick);
            // 
            // hd
            // 
            this.hd.AutoSize = true;
            this.hd.Location = new System.Drawing.Point(467, 21);
            this.hd.Name = "hd";
            this.hd.Size = new System.Drawing.Size(35, 13);
            this.hd.TabIndex = 1;
            this.hd.Text = "label1";
            // 
            // View_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.hd);
            this.Controls.Add(this.displayUsers);
            this.Name = "View_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Users";
            ((System.ComponentModel.ISupportInitialize)(this.displayUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView displayUsers;
        private System.Windows.Forms.Label hd;
    }
}