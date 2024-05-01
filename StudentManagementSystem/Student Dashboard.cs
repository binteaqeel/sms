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
    public partial class Student_Dashboard : Form
    {
        public string role = "student";
        public string setId;

        public string conString;
        Connection conc = new Connection();
        public Student_Dashboard(string getId)
        {
            setId = getId;
            InitializeComponent();
            conString = conc.conStrings;
            idShow.Text = getId;

            try
            {
                SqlConnection con = new SqlConnection(conString);

                string queryForName = "Select Fname from students where id = " + getId;
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

                string queryForLName = "Select Lname from students where id = " + getId;
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
                Console.WriteLine("Masle Masail! \n" + ex);
            }
        }

        private void feedbackbtn_Click(object sender, EventArgs e)
        {
            Student_Feedback stdFdbk = new Student_Feedback(setId, role);
            stdFdbk.Show();

        }

        private void EnrollBtn_Click(object sender, EventArgs e)
        {
            StdEnrollment ef = new StdEnrollment(setId);
            ef.Show();
        }

        private void gradeBtn_Click(object sender, EventArgs e)
        {
            ShowGrades sg = new ShowGrades(setId);
            sg.Show();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            GradeHistory gh = new GradeHistory(setId);
            gh.Show();
        }
    }
}
