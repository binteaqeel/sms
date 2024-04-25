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
    public partial class StdEnrollment : Form
    {
        public string setId;
        public string NoOfCrses;
        public StdEnrollment(string getId)
        {
            setId = getId;
            
            InitializeComponent();
            LoadChecklistItems();

        }

        private void LoadChecklistItems()
        {
            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";

                string query = "SELECT c.crsName, cl.id AS class_id FROM UpdrageStudents us JOIN classes cl ON us.semId = cl.semId JOIN courses c ON cl.crsId = c.id WHERE us.stdId = " + setId;

                viewCourses.Controls.Clear();

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
                                checkBox.Text = reader["class_id"].ToString() + " - " + reader["crsName"].ToString();
                                checkBox.AutoSize = true;

                                viewCourses.Controls.Add(checkBox);
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

        private void requestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);

                string queryForcorses = "SELECT s.noOfCrs FROM UpdrageStudents us JOIN semester s ON us.semId = s.id WHERE us.stdId = " + setId;
                SqlCommand command = new SqlCommand(queryForcorses, con);
                con.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        NoOfCrses = reader[i].ToString();

                    }
                }


                reader.Close();
                command.Dispose();
                

                int checkedCount = viewCourses.Controls.OfType
                <CheckBox>()
                .Count(cb => cb.Checked);
                int numberOfCourses = int.Parse(NoOfCrses);
                if (checkedCount == numberOfCourses)
                {
                    string deleteQuery = "DELETE FROM stdClassRequest WHERE stdId = @studentId AND classId = @classId";

                    foreach (Control control in viewCourses.Controls)
                    {
                        if (control is CheckBox checkBox)
                        {
                            string itemName = checkBox.Text;
                            int index = itemName.IndexOf('-');
                            string classesId = itemName.Substring(0, index).Trim();
                            if (!checkBox.Checked)
                            {
                                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, con))
                                {
                                    deleteCommand.Parameters.AddWithValue("@studentId", setId);
                                    deleteCommand.Parameters.AddWithValue("@classId", classesId);
                                    deleteCommand.ExecuteNonQuery();
                                }
                            }
                            else {
                                string selectQuery = "SELECT COUNT(*) FROM stdClassRequest WHERE stdId = @studentId AND classId = @classId";
                                using (SqlCommand selectCommand = new SqlCommand(selectQuery, con))
                                {
                                    selectCommand.Parameters.AddWithValue("@studentId", setId);
                                    selectCommand.Parameters.AddWithValue("@classId", classesId);

                                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());

                                    if (count == 0)
                                    {
                                        string insertQuery = "INSERT INTO stdClassRequest (stdId, classId) VALUES (@studentId, @classId)";
                                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, con))
                                        {
                                            insertCommand.Parameters.AddWithValue("@studentId", setId);
                                            insertCommand.Parameters.AddWithValue("@classId", classesId);

                                            insertCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }
                    }

                    MessageBox.Show("Hogayaaaaa!");
                    PaymentBill pB = new PaymentBill(setId);
                    pB.Show();
                }
                else
                {
                    MessageBox.Show("Select " + numberOfCourses + " Courses!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("masle Masail \n" + ex);
            }
            
        }
    }
}
