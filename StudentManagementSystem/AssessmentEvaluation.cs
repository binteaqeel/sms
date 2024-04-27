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
    public partial class AssessmentEvaluation : Form
    {
        public string setId;
        public string setClassId;
        public string AssesssId;
        public AssessmentEvaluation(string getId , string getClassId)
        {
            setId = getId;
            setClassId = getClassId;
            InitializeComponent();
            LoadAssessmentType();
        }

        private void LoadAssessmentType()
        {
            AssessTypeComboBox.Items.Clear();

            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);

                con.Open();

                SqlCommand cmd = new SqlCommand("select id,AssessmentName from AssessmentType where classId = " + setClassId, con);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    AssessItem item = new AssessItem();

                    item.assessId = Convert.ToInt32(dr["id"]);
                    item.assessName = dr["AssessmentName"].ToString();

                    AssessTypeComboBox.Items.Add(item);
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        class AssessItem
        {
            public int assessId { get; set; }
            public string assessName { get; set; }

            public override string ToString()
            {
                return assessName;
            }
        }

        private void AssessTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssessItem selectedAssesId = AssessTypeComboBox.SelectedItem as AssessItem;

            if (selectedAssesId != null)
            {
                int asId = selectedAssesId.assessId;
                string classId = asId.ToString();

                AssesssId = classId;
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT students.id, Fname + ' ' + Lname AS FullName FROM students INNER JOIN paidEnrollment ON students.id = paidEnrollment.stdId WHERE paidEnrollment.semId = (SELECT semId FROM AssessmentType WHERE id = "+ AssesssId + ")";
                DataTable dtStudents = new DataTable();
                SqlDataAdapter daStudents = new SqlDataAdapter(cmd);
                daStudents.Fill(dtStudents);

                foreach (DataRow row in dtStudents.Rows)
                {
                    Label lblStudentName = new Label();
                    lblStudentName.Text = row["id"].ToString()+" - "+ row["FullName"].ToString();
                    lblStudentName.AutoSize = true;

                    TextBox txtObtainMarks = new TextBox();
                    txtObtainMarks.Name = "txtObtainMarks_" + row["id"].ToString(); 
                    txtObtainMarks.Width = 50;

                    viewGrading.Controls.Add(lblStudentName);
                    viewGrading.Controls.Add(txtObtainMarks);

                    viewGrading.SetFlowBreak(txtObtainMarks, true);
                }

                cmd.CommandText = "SELECT * FROM AssessmentType WHERE id = " + AssesssId;
                DataTable dtAssessmentType = new DataTable();
                SqlDataAdapter daAssessmentType = new SqlDataAdapter(cmd);
                daAssessmentType.Fill(dtAssessmentType);
                if (dtAssessmentType.Rows.Count > 0)
                {
                    Label lblAssessmentType = new Label();
                    lblAssessmentType.Text = "Assessment Type: " + dtAssessmentType.Rows[0]["AssessmentName"].ToString();
                    lblAssessmentType.AutoSize = true;

                    Label lblTotalMarks = new Label();
                    lblTotalMarks.Text = "Total Marks: " + dtAssessmentType.Rows[0]["totalMarks"].ToString();
                    lblTotalMarks.AutoSize = true;

                    viewGrading.Controls.Add(lblAssessmentType);
                    viewGrading.Controls.Add(lblTotalMarks);
                }

                Button btnSave = new Button();
                btnSave.Text = "Save";
                btnSave.Click += btnSave_Click;

                viewGrading.Controls.Add(btnSave);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                foreach (Control control in viewGrading.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox txtBox = (TextBox)control;
                        int stdId = int.Parse(txtBox.Name.Split('_')[1]); 
                        int obtainMarks = int.Parse(txtBox.Text);

                        cmd.CommandText = "IF EXISTS (SELECT 1 FROM Assessment WHERE stdId = @stdId AND AssessId = "+ AssesssId + ") " +
                                          "UPDATE Assessment SET ObtainMarks = @ObtainMarks WHERE stdId = @stdId AND AssessId = "+ AssesssId + " " +
                                          "ELSE " +
                                          "INSERT INTO Assessment (stdId, ObtainMarks, AssessId) VALUES (@stdId, @ObtainMarks, "+ AssesssId + ")";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@stdId", stdId);
                        cmd.Parameters.AddWithValue("@ObtainMarks", obtainMarks);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Hogayaaaaaa");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
