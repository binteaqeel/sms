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
    public partial class ShowGrades : Form
    {
        public string setId;
        public string ClasssId;
        public ShowGrades(string getId)
        {
            setId = getId;
            InitializeComponent();
            LoadClasses();
        }

        private void LoadClasses()
        {
            classComboBox.Items.Clear();

            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);

                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT classes.id AS ClassID, courses.crsName AS ClassName FROM stdClassRequest JOIN classes ON stdClassRequest.classId = classes.id JOIN courses ON classes.crsId = courses.id WHERE stdClassRequest.stdId = " + setId, con);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ClassItem item = new ClassItem();

                    item.ClassId = Convert.ToInt32(dr["ClassID"]);
                    item.CrsName = dr["ClassName"].ToString();

                    classComboBox.Items.Add(item);
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        class ClassItem
        {
            public int ClassId { get; set; }
            public string CrsName { get; set; }

            public override string ToString()
            {
                return ClassId + " - " + CrsName;
            }
        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassItem selectedClass = classComboBox.SelectedItem as ClassItem;

            if (selectedClass != null)
            {
                int clsId = selectedClass.ClassId;
                string classId = clsId.ToString();

                ClasssId = classId;

                try
                {
                    string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(conString))
                    {

                        string query1 = "SELECT AssessmentType.AssessmentName, AssessmentType.totalMarks, " +
                            "Assessment.ObtainMarks FROM Assessment JOIN AssessmentType ON" +
                            " Assessment.AssessId = AssessmentType.id WHERE Assessment.stdId = " + setId + " " +
                            "AND EXISTS ( SELECT 1 FROM classes WHERE classes.id = " + ClasssId + " AND " +
                            "classes.id = AssessmentType.classId)";
                        using (SqlCommand cmd = new SqlCommand(query1, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    ada.Fill(dt);
                                    viewMarks.DataSource = dt;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Masle Masaill!! \n" + ex);
                }

                }
        }
    }
}
