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
        public string conString;
        Connection conc = new Connection();
        public StdEnrollment(string getId)
        {
            setId = getId;
            
            InitializeComponent();
            conString = conc.conStrings;
            LoadChecklistItems();

        }

        private void LoadChecklistItems()
        {
            try
            {
                
                string query = "SELECT \r\n    C.ClassId,\r\n    C.CourseName\r\nFROM \r\n    (\r\n    " +
                    "SELECT \r\n        c.id AS ClassId,\r\n        crs.crsName AS CourseName\r\n   " +
                    " FROM \r\n        classes c\r\n    INNER JOIN \r\n        courses crs ON c.crsId " +
                    "= crs.id\r\n    INNER JOIN \r\n        UpdrageStudents us ON c.semId = us.semId\r\n" +
                    "    WHERE \r\n        us.stdId = "+setId+"\r\n        AND c.semId = (SELECT MAX(semId) FROM" +
                    " UpdrageStudents WHERE stdId = "+setId+")\r\n    ) AS C\r\nINNER JOIN\r\n    (\r\n    " +
                    "SELECT\r\n        A.ClassId,\r\n        A.CourseName\r\n    FROM\r\n     " +
                    "   (\r\n        SELECT\r\n            c.id AS ClassId,\r\n           " +
                    " crs.crsName AS CourseName\r\n        FROM\r\n            classes c\r\n  " +
                    "      INNER JOIN\r\n            courses crs ON c.crsId = crs.id\r\n      " +
                    "  ) AS A\r\n    LEFT JOIN\r\n        (\r\n        SELECT\r\n          " +
                    "  c.id AS ClassId,\r\n            crs.crsName AS CourseName\r\n       " +
                    " FROM\r\n            classes c\r\n        INNER JOIN\r\n            courses crs" +
                    " ON c.crsId = crs.id\r\n        INNER JOIN\r\n            " +
                    "resultStatus rs ON c.id = rs.classId\r\n        WHERE\r\n         " +
                    "   rs.stdId = "+setId+"\r\n            AND rs.statuss = 'PASS'\r\n        " +
                    ") AS B ON A.CourseName = B.CourseName\r\n    WHERE\r\n       " +
                    " B.ClassId IS NULL\r\n    ) AS D ON C.ClassId = D.ClassId AND C.CourseName " +
                    "= D.CourseName;\r\n";

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
                                checkBox.Text = reader["classId"].ToString() + " - " + reader["CourseName"].ToString();
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

                    List<string> selectedCourses = new List<string>();

                    foreach (Control control in viewCourses.Controls)
                    {
                        if (control is CheckBox checkBox && checkBox.Checked)
                        {
                            string itemName = checkBox.Text;
                            int index = itemName.IndexOf('-');
                            string classesId = itemName.Substring(0, index).Trim();
                            string courseName = itemName.Substring(index + 1).Trim();

                            if (selectedCourses.Contains(courseName))
                            {
                                MessageBox.Show("Select only one class for each course!");
                                return;
                            }
                            else
                            {
                                selectedCourses.Add(courseName);
                            }

                            using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, con))
                            {
                                deleteCommand.Parameters.AddWithValue("@studentId", setId);
                                deleteCommand.Parameters.AddWithValue("@classId", classesId);
                                deleteCommand.ExecuteNonQuery();
                            }

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
                MessageBox.Show("Masle Masail \n" + ex);
            }
        }
            
            
        }
    }

