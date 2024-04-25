using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentManagementSystem
{
    public partial class UpdateDeleteUsers : Form
    {
        public string setRole;
        public string setId;
        public string setFname;
        public string setLname;
        public string setDOB;
        public string setGender;
        public string setEmail;
        public string setPhoneNumber;
        public string setAdres;
        public string setPas;
        public string setConPass;

        public string fileRoleName;


        public UpdateDeleteUsers(string getRole, string getId, string getFname, string getLname, string getDOB, string getGender, string getEmail, string getPhoneNumber, string getAdres, string getPas, string getConPass)
        {

            setRole = getRole;
            setId = getId;
            setFname = getFname;
            setLname = getLname;
            setDOB = getDOB;
            setGender = getGender;
            setEmail = getEmail;
            setPhoneNumber = getPhoneNumber;
            setAdres = getAdres;
            setPas = getPas;
            setConPass = getConPass;

            InitializeComponent();
            InputRole.Text = setRole;
            InputFname.Text = setFname;
            InputLname.Text = setLname;
            InputDOB.Text = setDOB;
            InputEmail.Text = setEmail;
            InputPhNum.Text = setPhoneNumber;
            InputAdres.Text = setAdres;
            InputPas.Text = setPas;
            ConPas.Text = setConPass;

            if (setGender == "Male")
            {
                RbtnMale.Checked = true;
                RbtnFemale.Checked = false;
                RbtnOther.Checked = false;
            }
            else if (setGender == "Female")
            {
                RbtnMale.Checked = false;
                RbtnFemale.Checked = true;
                RbtnOther.Checked = false;
            }
            else
            {
                RbtnMale.Checked = false;
                RbtnFemale.Checked = false;
                RbtnOther.Checked = true;
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            string gender;
            if (RbtnFemale.Checked == true)
            {
                gender = RbtnFemale.Text;
            }
            else if (RbtnMale.Checked == true)
            {
                gender = RbtnFemale.Text;
            }
            else
            {
                gender = RbtnOther.Text;
            }

            DateTime dat = InputDOB.Value.Date;
            string DOBset = dat.ToString("yyyy-MM-dd");

           
            if(InputRole.Text == "Student")
            {
                fileRoleName = "std";
            }
            else if (InputRole.Text == "Admin")
            {
                fileRoleName = "adm";
            }
            else if (InputRole.Text == "Teacher")
            {
                fileRoleName = "inst";
            }


            try
            {
                if (setRole == "std")
                {
                    if (fileRoleName == setRole)
                    {
                        string updateQuery = "UPDATE students SET Fname = @FirstName, Lname = @LastName, DOB = @DOB, email = @Email, phoneNumber = @PhoneNumber, adres = @Address, pasword = @Password, confirmPassword = @ConfirmPassword WHERE id = @UniqueIdentifier";

                        using (SqlConnection connection = new SqlConnection(conString))
                        {
                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@FirstName", InputFname.Text);
                                command.Parameters.AddWithValue("@LastName", InputLname.Text);
                                command.Parameters.AddWithValue("@DOB", dat);
                                command.Parameters.AddWithValue("@Email", InputEmail.Text);
                                command.Parameters.AddWithValue("@PhoneNumber", InputPhNum.Text);
                                command.Parameters.AddWithValue("@Address", InputAdres.Text);
                                command.Parameters.AddWithValue("@Password", InputPas.Text);
                                command.Parameters.AddWithValue("@ConfirmPassword", ConPas.Text);
                                command.Parameters.AddWithValue("@UniqueIdentifier", setId);

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
                    else
                    {
                        if (fileRoleName == "inst")
                        {
                            string query1 = "insert into instructor (Fname,Lname,DOB,gender,email,phoneNumber,adres,pasword,confirmPassword) values ('" + InputFname.Text + "','" + InputLname.Text + "','" + DOBset + "','" + gender + "','" + InputEmail.Text + "','" + InputPhNum.Text + "','" + InputAdres.Text + "','" + InputPas.Text + "','" + ConPas.Text + "')";
                            SqlCommand command1 = new SqlCommand(query1, con);

                            string query2 = "delete from students where id = " + setId;
                            SqlCommand command2 = new SqlCommand(query2, con);

                            con.Open();
                            command1.ExecuteNonQuery();
                            command2.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Hoggayyyyaaaaa");
                        }
                        else if (fileRoleName == "adm")
                        {
                            string query1 = "insert into administration (Fname,Lname,DOB,gender,email,phoneNumber,adres,pasword,confirmPassword) values ('" + InputFname.Text + "','" + InputLname.Text + "','" + DOBset + "','" + gender + "','" + InputEmail.Text + "','" + InputPhNum.Text + "','" + InputAdres.Text + "','" + InputPas.Text + "','" + ConPas.Text + "')";
                            SqlCommand command1 = new SqlCommand(query1, con);

                            string query2 = "delete from students where id = " + setId;
                            SqlCommand command2 = new SqlCommand(query2, con);

                            con.Open();
                            command1.ExecuteNonQuery();
                            command2.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Hoggayyyyaaaaa");
                        }
                        else
                        {
                            MessageBox.Show("Ye to nhi hosaktaaaaa");
                        }
                    }
                }
                else if (setRole == "inst")
                {
                    if (fileRoleName == setRole)
                    {
                        string updateQuery = "UPDATE instructor SET Fname = @FirstName, Lname = @LastName, DOB = @DOB, email = @Email, phoneNumber = @PhoneNumber, adres = @Address, pasword = @Password, confirmPassword = @ConfirmPassword WHERE id = @UniqueIdentifier";

                        using (SqlConnection connection = new SqlConnection(conString))
                        {
                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@FirstName", InputFname.Text);
                                command.Parameters.AddWithValue("@LastName", InputLname.Text);
                                command.Parameters.AddWithValue("@DOB", dat);
                                command.Parameters.AddWithValue("@Email", InputEmail.Text);
                                command.Parameters.AddWithValue("@PhoneNumber", InputPhNum.Text);
                                command.Parameters.AddWithValue("@Address", InputAdres.Text);
                                command.Parameters.AddWithValue("@Password", InputPas.Text);
                                command.Parameters.AddWithValue("@ConfirmPassword", ConPas.Text);
                                command.Parameters.AddWithValue("@UniqueIdentifier", setId);

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
                    else
                    {
                        if (fileRoleName == "std")
                        {
                            string query1 = "insert into students (Fname,Lname,DOB,gender,email,phoneNumber,adres,pasword,confirmPassword) values ('" + InputFname.Text + "','" + InputLname.Text + "','" + DOBset + "','" + gender + "','" + InputEmail.Text + "','" + InputPhNum.Text + "','" + InputAdres.Text + "','" + InputPas.Text + "','" + ConPas.Text + "')";
                            SqlCommand command1 = new SqlCommand(query1, con);

                            string query2 = "delete from instructor where id = " + setId;
                            SqlCommand command2 = new SqlCommand(query2, con);

                            con.Open();
                            command1.ExecuteNonQuery();
                            command2.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Hoggayyyyaaaaa");
                        }
                        else if (fileRoleName == "adm")
                        {
                            string query1 = "insert into administration (Fname,Lname,DOB,gender,email,phoneNumber,adres,pasword,confirmPassword) values ('" + InputFname.Text + "','" + InputLname.Text + "','" + DOBset + "','" + gender + "','" + InputEmail.Text + "','" + InputPhNum.Text + "','" + InputAdres.Text + "','" + InputPas.Text + "','" + ConPas.Text + "')";
                            SqlCommand command1 = new SqlCommand(query1, con);

                            string query2 = "delete from instructor where id = " + setId;
                            SqlCommand command2 = new SqlCommand(query2, con);

                            con.Open();
                            command1.ExecuteNonQuery();
                            command2.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Hoggayyyyaaaaa");
                        }
                        else
                        {
                            MessageBox.Show("Ye to nhi hosaktaaaaa");
                        }
                    }

                }
                else if (setRole == "adm")
                {
                    if (fileRoleName == setRole)
                    {
                        string updateQuery = "UPDATE administration SET Fname = @FirstName, Lname = @LastName, DOB = @DOB, email = @Email, phoneNumber = @PhoneNumber, adres = @Address, pasword = @Password, confirmPassword = @ConfirmPassword WHERE id = @UniqueIdentifier";

                        using (SqlConnection connection = new SqlConnection(conString))
                        {
                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@FirstName", InputFname.Text);
                                command.Parameters.AddWithValue("@LastName", InputLname.Text);
                                command.Parameters.AddWithValue("@DOB", dat);
                                command.Parameters.AddWithValue("@Email", InputEmail.Text);
                                command.Parameters.AddWithValue("@PhoneNumber", InputPhNum.Text);
                                command.Parameters.AddWithValue("@Address", InputAdres.Text);
                                command.Parameters.AddWithValue("@Password", InputPas.Text);
                                command.Parameters.AddWithValue("@ConfirmPassword", ConPas.Text);
                                command.Parameters.AddWithValue("@UniqueIdentifier", setId);

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
                    else
                    {
                        if (fileRoleName == "std")
                        {
                            string query1 = "insert into students (Fname,Lname,DOB,gender,email,phoneNumber,adres,pasword,confirmPassword) values ('" + InputFname.Text + "','" + InputLname.Text + "','" + DOBset + "','" + gender + "','" + InputEmail.Text + "','" + InputPhNum.Text + "','" + InputAdres.Text + "','" + InputPas.Text + "','" + ConPas.Text + "')";
                            SqlCommand command1 = new SqlCommand(query1, con);

                            string query2 = "delete from administration where id = " + setId;
                            SqlCommand command2 = new SqlCommand(query2, con);

                            con.Open();
                            command1.ExecuteNonQuery();
                            command2.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Hoggayyyyaaaaa");
                        }
                        else if (fileRoleName == "inst")
                        {
                            string query1 = "insert into instructor (Fname,Lname,DOB,gender,email,phoneNumber,adres,pasword,confirmPassword) values ('" + InputFname.Text + "','" + InputLname.Text + "','" + DOBset + "','" + gender + "','" + InputEmail.Text + "','" + InputPhNum.Text + "','" + InputAdres.Text + "','" + InputPas.Text + "','" + ConPas.Text + "')";
                            SqlCommand command1 = new SqlCommand(query1, con);

                            string query2 = "delete from administration where id = " + setId;
                            SqlCommand command2 = new SqlCommand(query2, con);

                            con.Open();
                            command1.ExecuteNonQuery();
                            command2.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Hoggayyyyaaaaa");
                        }
                        else
                        {
                            MessageBox.Show("Ye to nhi hosaktaaaaa");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Garbar he");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Masle Masaail");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            if(setRole == "std")
            {
                try
                {
                    string query = "delete from students where id = " + setId;

                    SqlCommand comd = new SqlCommand(query, con);

                    con.Open();
                    int a = comd.ExecuteNonQuery();
                    con.Close();

                    if (a > 0)
                    {
                        MessageBox.Show("HOGAYYYYYAAAAAAA");
                    }
                    else
                    {
                        MessageBox.Show("Garbar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Masle Masail");
                }
            }
            else if (setRole == "inst")
            {
                try
                {
                    string query = "delete from instructor where id = " + setId;

                    SqlCommand comd = new SqlCommand(query, con);

                    con.Open();
                    int a = comd.ExecuteNonQuery();
                    con.Close();

                    if (a > 0)
                    {
                        MessageBox.Show("HOGAYYYYYAAAAAAA");
                    }
                    else
                    {
                        MessageBox.Show("Garbar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Masle Masail");
                }
            }
            else if (setRole == "adm")
            {
                try
                {
                    string query = "delete from administration where id = " + setId;

                    SqlCommand comd = new SqlCommand(query, con);

                    con.Open();
                    int a = comd.ExecuteNonQuery();
                    con.Close();

                    if (a > 0)
                    {
                        MessageBox.Show("HOGAYYYYYAAAAAAA");
                    }
                    else
                    {
                        MessageBox.Show("Garbar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Masle Masail");
                }
            }
        }
    }
}
