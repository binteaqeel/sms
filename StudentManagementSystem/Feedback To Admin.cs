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
    public partial class Feedback_To_Admin : Form
    {
        public string setId;
        public string setRole;
        public Feedback_To_Admin(string getId, string role)
        {
            setRole = role;
            setId = getId;
            InitializeComponent();
        }

        private void SubmitFdbkBtn_Click(object sender, EventArgs e)
        {
            if (setRole == "Teacher")
            {
                try
                {
                    string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";
                    SqlConnection con = new SqlConnection(conString);

                    if (adminName.Text == "" || AdFdbkDesc.Text == "")
                    {
                        MessageBox.Show("Hoshyari nhi");
                    }
                    else
                    {
                        string query = "insert into instFeedbackForAdmin(adId,instId,fdbkDesc) values (" + adminId.Text + "," + setId + ",'" + AdFdbkDesc.Text + "')";
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
            else if (setRole == "student")
            {
                try
                {
                    string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";
                    SqlConnection con = new SqlConnection(conString);

                    if (adminName.Text == "" || AdFdbkDesc.Text == "")
                    {
                        MessageBox.Show("Hoshyari nhi");
                    }
                    else
                    {
                        string query = "insert into stdFeedbackForAdmin(adId,stdId,fdbkDesc) values (" + adminId.Text + "," + setId + ",'" + AdFdbkDesc.Text + "')";
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
