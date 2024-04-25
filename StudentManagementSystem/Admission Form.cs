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
    public partial class Student_Admission_Form : Form
    {
        public Student_Admission_Form()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dat = InputDOB.Value.Date;
                string DOBset = dat.ToString("yyyy-MM-dd");

                string gender = null;
                if (RbtnMale.Checked == true)
                {
                    gender = RbtnMale.Text;
                }
                else if (RbtnFemale.Checked == true)
                {
                    gender = RbtnFemale.Text;
                }
                else
                {
                    gender = RbtnOther.Text;
                }

                if (InputPas.Text != ConPas.Text)
                {
                    MessageBox.Show("Your Passwords Donot Match!");
                }
                else
                if (InputFname.Text == "" || InputLname.Text == "" || gender == null || InputEmail.Text == "" || InputPhNum.Text == "" || InputEmail.Text == "" || InputAdres.Text == "" || InputPas.Text == "" || ConPas.Text == "")
                {
                    MessageBox.Show("Hoshyari Nahi");
                }
                else
                {
                    string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";
                    SqlConnection con = new SqlConnection(conString);

                    if (InputRole.Text == "Student")
                    {
                        string query = "insert into students (Fname,Lname,DOB,gender,email,phoneNumber,adres,pasword,confirmPassword) values ('" + InputFname.Text + "','" + InputLname.Text + "','" + DOBset + "','" + gender + "','" + InputEmail.Text + "','" + InputPhNum.Text + "','" + InputAdres.Text + "','" + InputPas.Text + "','" + ConPas.Text + "')";
                        SqlCommand command = new SqlCommand(query, con);

                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Hoggayyyyaaaaa");
                    }
                    else if (InputRole.Text == "Admin")
                    {
                        string query = "insert into administration (Fname,Lname,DOB,gender,email,phoneNumber,adres,pasword,confirmPassword) values ('" + InputFname.Text + "','" + InputLname.Text + "','" + DOBset + "','" + gender + "','" + InputEmail.Text + "','" + InputPhNum.Text + "','" + InputAdres.Text + "','" + InputPas.Text + "','" + ConPas.Text + "')";
                        SqlCommand command = new SqlCommand(query, con);

                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Hoggayyyyaaaaa");
                    }
                    else if (InputRole.Text == "Teacher")
                    {
                        string query = "insert into instructor (Fname,Lname,DOB,gender,email,phoneNumber,adres,pasword,confirmPassword) values ('" + InputFname.Text + "','" + InputLname.Text + "','" + DOBset + "','" + gender + "','" + InputEmail.Text + "','" + InputPhNum.Text + "','" + InputAdres.Text + "','" + InputPas.Text + "','" + ConPas.Text + "')";
                        SqlCommand command = new SqlCommand(query, con);

                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Hoggayyyyaaaaa");
                    }
                    else
                    {
                        MessageBox.Show("Masla He bhai");
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masle Masail \n" + ex);
            }
            
        }

        private void viewStudents_Click(object sender, EventArgs e)
        {
            View_Users view = new View_Users("std");
            view.Show();
           
        }

        private void viewInstructor_Click(object sender, EventArgs e)
        {
            View_Users view = new View_Users("inst");
            view.Show();
           
        }

        private void viewAdmins_Click(object sender, EventArgs e)
        {
            View_Users view = new View_Users("adm");
            view.Show();
            
        }
    }
}
