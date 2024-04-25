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
using System.Xml.Linq;

namespace StudentManagementSystem
{
    public partial class Instructor_Dashboard : Form
    {
        public string role = "Teacher";
        string setId;
        public Instructor_Dashboard(string getId)
        {
            setId = getId;
            InitializeComponent();
            idShow.Text = getId;

            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                string queryForName = "Select Fname from instructor where id = " + getId;
                SqlCommand command = new SqlCommand(queryForName, con);
                con.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        FnameShow.Text = reader[i].ToString();

                    }
                }


                reader.Close();
                command.Dispose();


                string queryForLName = "Select Lname from instructor where id = " + getId;
                SqlCommand command2 = new SqlCommand(queryForLName, con);

                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    for (int i = 0; i < reader2.FieldCount; i++)
                    {
                        LnameShow.Text = reader2[i].ToString();

                    }
                }


                reader2.Close();
                command2.Dispose();

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Masle Masaail \n" + ex);
            }
        }

        private void feedbackbtn_Click(object sender, EventArgs e)
        {
            Instructor_Feedback instFdbk = new Instructor_Feedback(setId, role);
            instFdbk.Show();
            this.Close();   

        }

        private void expertiseBtn_Click(object sender, EventArgs e)
        {
            InstExpertise exp = new InstExpertise(setId);
            exp.Show();
            this.Close();

        }
    }
}
