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
    public partial class UpgradeStds : Form
    {
        public string semId;
        public UpgradeStds()
        {
            InitializeComponent();
            LoadSemester();
            LoadChecklistItems();
        }

        private void LoadSemester()
        {
            semComboBox.Items.Clear();

            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);

                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT id, SemName FROM semester", con);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    SemesterItem item = new SemesterItem();

                    item.SemesterId = Convert.ToInt32(dr["id"]);
                    item.SemesterName = dr["SemName"].ToString();

                    semComboBox.Items.Add(item);
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        class SemesterItem
        {
            public int SemesterId { get; set; }
            public string SemesterName { get; set; }

            public override string ToString()
            {
                return SemesterName;
            }
        }

        private void LoadChecklistItems()
        {
            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";

                string query = "SELECT id , Fname,Lname FROM students";

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
                                checkBox.Text = reader["id"].ToString() + "- " + reader["Fname"].ToString() + " " + reader["Lname"].ToString();
                                checkBox.AutoSize = true;

                                ViewStds.Controls.Add(checkBox);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Masle Masail \n" +ex);
            }
        }

        private void UpgStdsBtn_Click(object sender, EventArgs e)
        {
            SaveSelectedItems();
        }

        private void SaveSelectedItems()
        {
            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM UpdrageStudents WHERE stdId = @studentId AND semId = @SemesterId";

                    foreach (Control control in ViewStds.Controls)
                    {
                        if (control is CheckBox checkBox)
                        {
                            string itemName = checkBox.Text;
                            int index = itemName.IndexOf('-');
                            string studentId = itemName.Substring(0, index).Trim();

                            if (!checkBox.Checked)
                            {
                                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@studentId", studentId);
                                    deleteCommand.Parameters.AddWithValue("@SemesterId", semId);
                                    deleteCommand.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                string selectQuery = "SELECT COUNT(*) FROM UpdrageStudents WHERE stdId = @studentId AND semId = @SemesterId";
                                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                                {
                                    selectCommand.Parameters.AddWithValue("@studentId", studentId);
                                    selectCommand.Parameters.AddWithValue("@SemesterId", semId);
                                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());

                                    if (count == 0)
                                    {
                                        string insertQuery = "INSERT INTO UpdrageStudents (stdId, semId) VALUES (@studentId, @SemesterId)";
                                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                                        {
                                            insertCommand.Parameters.AddWithValue("@studentId", studentId);
                                            insertCommand.Parameters.AddWithValue("@SemesterId", semId);
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
            catch (Exception ex)
            {
                MessageBox.Show("Masle Masail \n" + ex);
            }
        }


        private void semComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SemesterItem selectedSemester = semComboBox.SelectedItem as SemesterItem;

            if (selectedSemester != null)
            {
                int SemId = selectedSemester.SemesterId;
                string semssId = SemId.ToString();

                semId = semssId;
            }
        }
    }
}
