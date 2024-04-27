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
    public partial class CreateAssessment : Form
    {
        public string setId;
        public string setClassId;
        public CreateAssessment(string getId , string getClassId)
        {
            setId = getId;
            setClassId = getClassId;
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            DateTime dat1 = HOD.Value.Date;
            string DOBset1 = dat1.ToString("yyyy-MM-dd");

            DateTime dat2 = SD.Value.Date;
            string DOBset2 = dat2.ToString("yyyy-MM-dd");


            if (assessmentType.Text == "" || assessmentType.Text == null || Desc.Text == "" || Desc.Text == null || totalMarks.Text == "" || totalMarks.Text == null)
            {
                MessageBox.Show("Hoshyariiii?????");
            }
            else
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";

                string query = "INSERT INTO AssessmentType (AssessmentName, AssessDesc, totalMarks,HOdate,SubDate,classId) VALUES (@Value1, @Value2, @Value3 ,@Value4,@Value5,@Value6)";

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Value1", assessmentType.Text);
                        command.Parameters.AddWithValue("@Value2", Desc.Text);
                        command.Parameters.AddWithValue("@Value3", totalMarks.Text);
                        command.Parameters.AddWithValue("@Value4", DOBset1);
                        command.Parameters.AddWithValue("@Value5", DOBset2);
                        command.Parameters.AddWithValue("@Value6", setClassId);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Hogayaaa");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Masle Masail \n " + ex);
                        }
                    }
                }
            }
        }
    }
}
