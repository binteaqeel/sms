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
    public partial class View_Users : Form
    {
        public string setRole;
        public string id;
        public string Fname;
        public string Lname;
        public string DOB;
        public string gender;
        public string email;
        public string phoneNumber;
        public string adres;
        public string pasword;
        public string confirmPassword;
        public View_Users(string getRole)
        {
            setRole = getRole;
            InitializeComponent();

            string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conString))
            {

                try
                {
                    if (setRole == "std")
                    {
                        hd.Text = "STUDENTS";
                        string query1 = "select * from students";
                        using (SqlCommand cmd = new SqlCommand(query1, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    ada.Fill(dt);
                                    displayUsers.DataSource = dt;
                                }
                            }
                        }
                    }
                    else if (setRole == "inst")
                    {
                        hd.Text = "INSTRUCTOR";
                        string query1 = "select * from instructor";
                        using (SqlCommand cmd = new SqlCommand(query1, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    ada.Fill(dt);
                                    displayUsers.DataSource = dt;
                                }
                            }
                        }
                    }
                    else if (setRole == "adm")
                    {
                        hd.Text = "ADMIN";
                        string query1 = "select * from administration";
                        using (SqlCommand cmd = new SqlCommand(query1, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    ada.Fill(dt);
                                    displayUsers.DataSource = dt;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("koi to garbar he");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Masle Masail hein!! \n" + ex);
                }
            }
            }

        private void displayUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void displayUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            try
            {
                if (displayUsers.SelectedRows.Count >= 0)
                {
                    id = displayUsers.SelectedRows[0].Cells[0].Value.ToString();
                    Fname = displayUsers.SelectedRows[0].Cells[1].Value.ToString();
                    Lname = displayUsers.SelectedRows[0].Cells[2].Value.ToString();
                    DOB = displayUsers.SelectedRows[0].Cells[3].Value.ToString();
                    gender = displayUsers.SelectedRows[0].Cells[4].Value.ToString();
                    email = displayUsers.SelectedRows[0].Cells[5].Value.ToString();
                    phoneNumber = displayUsers.SelectedRows[0].Cells[6].Value.ToString();
                    adres = displayUsers.SelectedRows[0].Cells[7].Value.ToString();
                    pasword = displayUsers.SelectedRows[0].Cells[8].Value.ToString();
                    confirmPassword = displayUsers.SelectedRows[0].Cells[9].Value.ToString();



                    UpdateDeleteUsers UDuser = new UpdateDeleteUsers(setRole, id, Fname, Lname, DOB, gender, email, phoneNumber, adres, pasword, confirmPassword);
                    UDuser.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Masle Masail! \n" + ex);
            }
        }
    }
}
