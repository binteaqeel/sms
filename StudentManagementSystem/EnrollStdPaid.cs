﻿using System;
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
    public partial class EnrollStdPaid : Form
    {
        public string semId;
        public string conString;
        Connection conc = new Connection();
        public EnrollStdPaid()
        {
            InitializeComponent();
            conString = conc.conStrings;
            LoadSemester();
        }

        private void LoadSemester()
        {
            semComboBox.Items.Clear();

            try
            {
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
                
                string query = "SELECT DISTINCT sr.stdId, CONCAT(s.Fname, ' ', s.Lname) AS StudentName FROM stdClassRequest sr INNER JOIN classes c ON sr.classId = c.id INNER JOIN semester sem ON c.semId = sem.id INNER JOIN students s ON sr.stdId = s.id LEFT JOIN paidEnrollment pe ON sr.stdId = pe.stdId AND sem.id = pe.semId WHERE sem.id = "+semId+ " AND pe.id IS NULL";

                viewStds.Controls.Clear();

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
                                checkBox.Text = reader["stdId"].ToString() + " - " + reader["StudentName"].ToString();
                                checkBox.AutoSize = true;

                                viewStds.Controls.Add(checkBox);
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

        private void semComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SemesterItem selectedSemester = semComboBox.SelectedItem as SemesterItem;

            if (selectedSemester != null)
            {
                int SemId = selectedSemester.SemesterId;
                string semssId = SemId.ToString();

                semId = semssId;
                LoadChecklistItems();
            }
        }

        private void enrollBtn_Click(object sender, EventArgs e)
        {
            SaveSelectedItems();
        }

        private void SaveSelectedItems()
        {
            try
            {
                
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM paidEnrollment WHERE stdId = @studentId AND semId = @SemesterId";

                    foreach (Control control in viewStds.Controls)
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
                                string selectQuery = "SELECT COUNT(*) FROM paidEnrollment WHERE stdId = @studentId AND semId = @SemesterId";
                                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                                {
                                    selectCommand.Parameters.AddWithValue("@studentId", studentId);
                                    selectCommand.Parameters.AddWithValue("@SemesterId", semId);
                                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());

                                    if (count == 0)
                                    {
                                        string insertQuery = "INSERT INTO paidEnrollment (stdId, semId) VALUES (@studentId, @SemesterId)";
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
    }
}
