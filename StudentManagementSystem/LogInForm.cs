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
    public partial class LogInForm : Form
    {
        public string conString;
        Connection conc = new Connection();
        public LogInForm()
        {
            InitializeComponent();
            conString = conc.conStrings;
        }

        private void logInbtn_Click(object sender, EventArgs e)
        {
           try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (InputRole.Text == "Admin")
                {
                    SqlCommand cmd = new SqlCommand("select id,pasword from administration", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string id = InputId.Text;
                        string password = InputPass.Text;

                        if (dr["id"].ToString() == id && dr["pasword"].ToString() == password)
                        {
                            Admin_Dashboard adminDashboard = new Admin_Dashboard(id);
                            adminDashboard.Show();
                        }
                        //else
                        //{
                        //    MessageBox.Show("TRY AGAIN!");
                        //}
                    }
                    dr.Close();
                }
                else if (InputRole.Text == "Teacher")
                {
                    SqlCommand cmd = new SqlCommand("select id,pasword from instructor", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string id = InputId.Text;
                        string password = InputPass.Text;

                        if (dr["id"].ToString() == id && dr["pasword"].ToString() == password)
                        {
                            Instructor_Dashboard instDashboard = new Instructor_Dashboard(id);
                            instDashboard.Show();
                        }
                        //else
                        //{
                        //    MessageBox.Show("TRY AGAIN!");
                        //}
                    }
                    dr.Close();
                }
                else if (InputRole.Text == "Student")
                {
                    SqlCommand cmd = new SqlCommand("select id,pasword from students", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string id = InputId.Text;
                        string password = InputPass.Text;

                        if (dr["id"].ToString() == id && dr["pasword"].ToString() == password)
                        {
                            Student_Dashboard stdDashboard = new Student_Dashboard(id);
                            stdDashboard.Show();
                        }
                        //else
                        //{
                        //    MessageBox.Show("TRY AGAIN!");
                        //}
                    }
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Kuch to garbar he DAYA!!");
                }
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Masle Masail! \n" + ex);
            }
        }
    }
}
