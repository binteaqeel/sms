using System;
using System.Collections;
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
    public partial class Show_Feedback : Form
    {
        public string setId;
        public string setRole;
        public Show_Feedback(string getId, string role)
        {
            setRole = role;
            setId = getId;
            InitializeComponent();
            this.ShowData();
        }

        public Show_Feedback(string getId)
        {
            setId = getId;
            InitializeComponent();
            this.ShowAdminData();
        }

        public void ShowAdminData()
        {
            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(conString))
                {
                    Table1Hd.Text = "Feedback From Students To Instructors";
                    Table2Hd.Text = "Feedbacks From Instructors To Students";
                    string query1 = "SELECT \r\n    f.fdbkDesc AS FeedbackDescription,\r\n    s.Fname AS StudentFirstName,\r\n    s.Lname AS StudentLastName,\r\n    s.id AS StudentID,\r\n    i.Fname AS InstructorFirstName,\r\n    i.Lname AS InstructorLastName,\r\n    i.id AS InstructorID\r\nFROM \r\n    instFeedbackForStudent f\r\nJOIN \r\n    students s ON f.stdId = s.id\r\nJOIN \r\n    instructor i ON f.instId = i.id;";
                    using (SqlCommand cmd = new SqlCommand(query1, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                ada.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }

                    string query2 = "SELECT \r\n    f.fdbkDesc AS FeedbackDescription,\r\n    s.Fname AS StudentFirstName,\r\n    s.Lname AS StudentLastName,\r\n    s.id AS StudentID,\r\n    i.Fname AS InstructorFirstName,\r\n    i.Lname AS InstructorLastName,\r\n    i.id AS InstructorID\r\nFROM \r\n    stdFeedbackForInst f\r\nJOIN \r\n    students s ON f.stdId = s.id\r\nJOIN \r\n    instructor i ON f.instId = i.id;\r\n";
                    using (SqlCommand cmd = new SqlCommand(query2, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                ada.Fill(dt);
                                dataGridView2.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ShowData()
        {
            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (setRole == "admin")
                    {
                        Table1Hd.Text = "Instructor Feedback";
                        Table2Hd.Text = "Student Feedback";
                        string query1 = "select fdbkDesc from instFeedbackForAdmin where adId =" + setId;
                        using (SqlCommand cmd = new SqlCommand(query1, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    ada.Fill(dt);
                                    dataGridView1.DataSource = dt;
                                }
                            }
                        }

                        string query2 = "select fdbkDesc from stdFeedbackForAdmin where adId =" + setId;
                        using (SqlCommand cmd = new SqlCommand(query2, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    ada.Fill(dt);
                                    dataGridView2.DataSource = dt;
                                }
                            }
                        }
                    }
                    else if (setRole == "student")
                    {
                        Table1Hd.Text = "Instructor Feedback";
                        Table2Hd.Text = "Admin Feedback";
                        string query1 = "select fdbkDesc from instFeedbackForStudent where stdId =" + setId;
                        using (SqlCommand cmd = new SqlCommand(query1, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    ada.Fill(dt);
                                    dataGridView1.DataSource = dt;
                                }
                            }
                        }

                        string query2 = "select fdbkDesc from AdminFeedbackForStudent where stdId =" + setId;
                        using (SqlCommand cmd = new SqlCommand(query2, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    ada.Fill(dt);
                                    dataGridView2.DataSource = dt;
                                }
                            }
                        }
                    }
                    else if (setRole == "Teacher")
                    {
                        Table1Hd.Text = "Student Feedback";
                        Table2Hd.Text = "Admin Feedback";

                        string query1 = "select fdbkDesc from stdFeedbackForInst where instId =" + setId;
                        using (SqlCommand cmd = new SqlCommand(query1, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    ada.Fill(dt);
                                    dataGridView1.DataSource = dt;
                                }
                            }
                        }

                        string query2 = "select fdbkDesc from AdminFeedbackForInstructor where InstId =" + setId;
                        using (SqlCommand cmd = new SqlCommand(query2, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    ada.Fill(dt);
                                    dataGridView2.DataSource = dt;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Masleeeeeee");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masle Masaail \n" +ex);
            }
        }
    }
}
