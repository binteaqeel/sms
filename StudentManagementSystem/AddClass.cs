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
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
            LoadCourses();
            LoadSemester();
        }

        private void LoadCourses()
        {
            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";

                string query = "SELECT crsName FROM courses";

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CrsComboBox.Items.Add(reader["crsName"].ToString());
                            }
                        }
                    }
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Masle Masail \n" + ex);
            }
        }

        private void LoadSemester()
        {
            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";

                string query = "SELECT SemName FROM semester";

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SemComboBox.Items.Add(reader["SemName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masle Masail \n" + ex);
            }
        }



        private void CrsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CrsComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                InstComboBox.Items.Clear();

                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";

                string selectedCourse = CrsComboBox.SelectedItem.ToString();
                string query = "SELECT i.Fname\r\nFROM instructor i\r\nJOIN InstExpertise ie ON i.id = ie.instId\r\nJOIN courses c ON ie.crsId = c.id\r\nWHERE c.crsName = @CourseName;\r\n";

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseName", selectedCourse);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                InstComboBox.Items.Add(reader["Fname"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masle Masail \n" + ex);
            }
        }

        private void e(object sender, PaintEventArgs e)
        {

        }

        private void submitClass_Click(object sender, EventArgs e)
        {
            SaveClass();
        }


        private void SaveClass()
        {
            try {
                if (CrsComboBox.SelectedItem == null || InstComboBox.SelectedItem == null || CreditHrs.Text == null)
                {
                    MessageBox.Show("Garbarrr");
                }

                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";

                string selectedCourse = CrsComboBox.SelectedItem.ToString();
                string selectedInstructor = InstComboBox.SelectedItem.ToString();
                string selestedSemester = SemComboBox.SelectedItem.ToString();

                int courseId;

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    string courseIdQuery = "SELECT id FROM courses WHERE crsName = @CourseName";

                    using (SqlCommand command = new SqlCommand(courseIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CourseName", selectedCourse);
                        courseId = (int)command.ExecuteScalar();
                    }

                    int instructorId;

                    string instructorIdQuery = "SELECT id FROM instructor WHERE Fname = @InstructorName";

                    using (SqlCommand command = new SqlCommand(instructorIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@InstructorName", selectedInstructor);
                        instructorId = (int)command.ExecuteScalar();
                    }

                    int semesterId;

                    string SemesterIdQuery = "SELECT id FROM semester WHERE SemName = @SemName";

                    using (SqlCommand command = new SqlCommand(SemesterIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SemName", selestedSemester);
                        semesterId = (int)command.ExecuteScalar();
                    }

                    string insertQuery = "INSERT INTO classes (crsId, instId,CrdHrs,semId) VALUES (@CourseId, @InstructorId,@CrdHrss,@SemsName)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CourseId", courseId);
                        command.Parameters.AddWithValue("@InstructorId", instructorId);
                        command.Parameters.AddWithValue("@CrdHrss", CreditHrs.Text);
                        command.Parameters.AddWithValue("@SemsName", semesterId);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Hogayaaa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("MasleMasail \n" + ex);
            }
            }

        private void viewClasses_Click(object sender, EventArgs e)
        {

        }
    }
}
