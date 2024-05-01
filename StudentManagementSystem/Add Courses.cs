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
    public partial class Add_Courses : Form
    {
        public string conString;
        Connection conc = new Connection();
        public Add_Courses()
        {
            InitializeComponent();
            conString = conc.conStrings;
        }

        private void addCrsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (crsName.Text == "" || crsName.Text == null || crsDesc.Text == "" || crsDesc.Text == null || crsAbr.Text == "" || crsAbr.Text == null)
                {
                    MessageBox.Show("Hoshyari Nhi");
                }
                else
                {
                    SqlConnection con = new SqlConnection(conString);

                    string query = "insert into courses (crsName,crsAbr,crsDesc) values ('" + InputFname.Text + "','" + InputLname.Text + "','" + InputEmail.Text + "')";
                    SqlCommand command = new SqlCommand(query, con);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Hoggayyyyaaaaa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masle Masail \n" + ex);
            }
        }

        private void viewCourses_Click(object sender, EventArgs e)
        {
            ViewCourses vc = new ViewCourses();
            vc.Show();
        }
    }
}
