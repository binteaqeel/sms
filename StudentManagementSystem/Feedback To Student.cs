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
    public partial class Feedback_To_Student : Form
    {
        public string setId;
        public string setRole;
        public string conString;
        Connection conc = new Connection();
        public Feedback_To_Student(string getId, string role)
        {
            setRole = role;
            setId = getId;
            InitializeComponent();
            conString = conc.conStrings;
        }

        private void SubmitFdbkBtn_Click(object sender, EventArgs e)
        {
            if (setRole == "Teacher")
            {
                try
                {
                     SqlConnection con = new SqlConnection(conString);

                    if (stdName.Text == "" || stdFdbkDesc.Text == "")
                    {
                        MessageBox.Show("Hoshyari nhi");
                    }
                    else
                    {
                        string query = "insert into instFeedbackForStudent(stdId,instId,fdbkDesc) values (" + stdId.Text + "," + setId + ",'" + stdFdbkDesc.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, con);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Hogayaaaa!!!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Masle Masaail hein \n" + ex);
                }
            }
            else if (setRole == "admin")
            {
                try
                {
                    SqlConnection con = new SqlConnection(conString);

                    if (stdName.Text == "" || stdFdbkDesc.Text == "")
                    {
                        MessageBox.Show("Hoshyari nhi");
                    }
                    else
                    {
                        string query = "insert into AdminFeedbackForStudent(stdId,adId,fdbkDesc) values (" + stdId.Text + "," + setId + ",'" + stdFdbkDesc.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, con);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Hogayaaaa!!!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Masle Masaail hein" + ex);
                }
            }
            else
            {
                MessageBox.Show("Masleeeee");
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
