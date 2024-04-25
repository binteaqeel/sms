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

namespace StudentManagementSystem
{
    public partial class UpdateDeleteCrs : Form
    {
        public string setCrsId;
        public string setCrsName;
        public string setCrsAbr;
        public string setCrsDesc;

        public UpdateDeleteCrs(string getCrsId , string getCrsName , string getCrsAbr , string CrsDesc)
        {
            setCrsId = getCrsId;
            setCrsName = getCrsName;
            setCrsAbr = getCrsAbr;
            setCrsDesc = CrsDesc;

            InitializeComponent();

            InputFname.Text = setCrsName;
            InputLname.Text = setCrsAbr;
            InputEmail.Text = setCrsDesc;
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            string updateQuery = "UPDATE courses SET crsName = @FirstName, crsAbr = @LastName, crsDesc = @DOB WHERE id = @UniqueIdentifier";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", InputFname.Text);
                    command.Parameters.AddWithValue("@LastName", InputLname.Text);
                    command.Parameters.AddWithValue("@DOB", InputEmail.Text);
                    command.Parameters.AddWithValue("@Email", InputEmail.Text);
                    command.Parameters.AddWithValue("@UniqueIdentifier", setCrsId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Hogayaaa");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Malse Masaail \n" + ex);
                    }

                }
            }
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            string updateQuery = "delete from courses WHERE id = @UniqueIdentifier";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@UniqueIdentifier", setCrsId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Hogayaaa");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Malse Masaail \n" + ex);
                    }

                }
            }
        }
    }
}
