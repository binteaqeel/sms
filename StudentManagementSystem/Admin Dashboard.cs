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
    public partial class Admin_Dashboard : Form
    {
        public string role = "admin";
        public string setId;
        public Admin_Dashboard(string getId)
        {
            setId = getId;
            InitializeComponent();
            idShow.Text = getId;

            string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            string queryForName = "Select Fname from administration where id = " + getId;
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


            string queryForLName = "Select Lname from administration where id = " + getId;
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

        private void feedbackbtn_Click(object sender, EventArgs e)
        {
            Admin_Feedback adfdbk = new Admin_Feedback(setId, role);
            this.Close();
            adfdbk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Admission_Form admis = new Student_Admission_Form();
            this.Close();
            admis.Show();
        }

        private void crsbtn_Click(object sender, EventArgs e)
        {
            Add_Courses crs = new Add_Courses();
            crs.Show();
            this.Close();
        }

        private void addClass_Click(object sender, EventArgs e)
        {
            AddClass ac = new AddClass();
            this.Close();
            ac.Show();
        }

        private void semesterBtn_Click(object sender, EventArgs e)
        {
            CreateSemester cs = new CreateSemester();
            cs.Show();
            this.Close();
        }

        private void upgStd_Click(object sender, EventArgs e)
        {
            UpgradeStds updStd = new UpgradeStds();
            updStd.Show();
            this.Close();
        }
    }
}
