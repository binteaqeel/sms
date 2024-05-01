using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagementSystem
{
    public partial class CreateSemester : Form
    {
        public string conString;
        Connection conc = new Connection();
        public CreateSemester()
        {
            InitializeComponent();
            conString = conc.conStrings;
        }

        private void addSemBtn_Click(object sender, EventArgs e)
        {
            
            string query = "INSERT INTO semester (SemName, FeePerCrdHr, noOfCrs , PassingMarks) VALUES (@Value1, @Value2, @Value3 ,@Value4)";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value1", SemName.Text);
                    command.Parameters.AddWithValue("@Value2", FeePerCrdHr.Text);
                    command.Parameters.AddWithValue("@Value3", noOfCrs.Text);
                    command.Parameters.AddWithValue("@Value4", passingMarks.Text);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Hogayaaa");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Masle Masail \n " + ex);
                    }
                }
            }
        }
    }
}
