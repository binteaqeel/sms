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
    public partial class InstExpertise : Form
    {
        public string SetId;
        public InstExpertise(string getId)
        {
            SetId = getId;
            InitializeComponent();
            LoadChecklistItems();
        }

        private void LoadChecklistItems()
        {
            string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";

            string query = "SELECT id,crsName,crsAbr FROM courses";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CheckBox checkBox = new CheckBox();
                            checkBox.Text = reader["id"].ToString() + " ," + reader["crsName"].ToString() + " (" + reader["crsAbr"].ToString() + ")";
                            checkBox.AutoSize = true;

                            viewCourses.Controls.Add(checkBox);
                        }
                    }
                }
            }
        }


        private void SaveSelectedItems()
        {
            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM InstExpertise WHERE instId = @InstructorId AND crsId = @CourseId";

                    foreach (Control control in viewCourses.Controls)
                    {
                        if (control is CheckBox checkBox)
                        {
                            string itemName = checkBox.Text;
                            int index = itemName.IndexOf(',');
                            string courseId = itemName.Substring(0, index);

                            if (!checkBox.Checked)
                            {
                                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@InstructorId", SetId);
                                    deleteCommand.Parameters.AddWithValue("@CourseId", courseId);
                                    deleteCommand.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                string selectQuery = "SELECT COUNT(*) FROM InstExpertise WHERE instId = @InstructorId AND crsId = @CourseId";
                                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                                {
                                    selectCommand.Parameters.AddWithValue("@InstructorId", SetId);
                                    selectCommand.Parameters.AddWithValue("@CourseId", courseId);
                                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());

                                    if (count == 0)
                                    {
                                        string insertQuery = "INSERT INTO InstExpertise (instId, crsId) VALUES (@InstructorId, @CourseId)";
                                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                                        {
                                            insertCommand.Parameters.AddWithValue("@InstructorId", SetId);
                                            insertCommand.Parameters.AddWithValue("@CourseId", courseId);
                                            insertCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    MessageBox.Show("Hogayaaaaa");
                    connection.Close();
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Masle Masail \n" + ex);
            }
        }




        private void subExp_Click(object sender, EventArgs e)
        {
            SaveSelectedItems();
        }
    }
}
