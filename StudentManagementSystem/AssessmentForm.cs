using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class AssessmentForm : Form
    {
        public string setId;
        public string setClassId;
        public string conString;
        Connection conc = new Connection();
        public AssessmentForm(string getId, string getClassId)
        {
            setId = getId;
            setClassId = getClassId;
            InitializeComponent();
            conString = conc.conStrings;
        }

        private void button52_Click(object sender, EventArgs e)
        {

        }

        private void AssessmentForm_Load(object sender, EventArgs e)
        {

        }

        private void createAssessBtn_Click(object sender, EventArgs e)
        {
            CreateAssessment ca = new CreateAssessment(setId, setClassId);
            ca.Show();
        }

        private void evalAssessBtn_Click(object sender, EventArgs e)
        {
            AssessmentEvaluation ae = new AssessmentEvaluation(setId, setClassId);
            ae.Show();
        }

        private void FinalMarksBtn_Click(object sender, EventArgs e)
        {
            int classIds = int.Parse(setClassId);
            InsertResultStatus(classIds);
        }

        private void InsertResultStatus(int classId)
        {
            try
            {
               
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    string query = @"
                INSERT INTO resultStatus (stdId, classId, Perrcentage, statuss)
                SELECT a.stdId, @classId, 
                       SUM(a.ObtainMarks) * 100.0 / SUM(at.totalMarks) AS Percentage,
                       CASE WHEN SUM(a.ObtainMarks) * 100.0 / SUM(at.totalMarks) >= s.PassingMarks THEN 'PASS' ELSE 'FAIL' END AS Status
                FROM Assessment a
                INNER JOIN AssessmentType at ON a.AssessId = at.id
                INNER JOIN classes c ON at.classId = c.id
                INNER JOIN semester s ON c.semId = s.id
                WHERE at.classId = @classId
                GROUP BY a.stdId, s.PassingMarks";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@classId", classId);
                        command.ExecuteNonQuery();
                    }
                }

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    string query = "insert into expiredClasses (classId) values (@classId)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@classId", classId);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Hogayaaaa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masle Masaill \n" + ex.Message);
            }
        }

    }
}
