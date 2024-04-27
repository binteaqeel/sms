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
    public partial class InstGrade : Form
    {
        public string setId;
        public string ClasssId;
        public InstGrade(string getId)
        {
            setId = getId;
            InitializeComponent();
            LoadClasses();
        }

        private void LoadClasses()
        {
            crsComboBox.Items.Clear();

            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);

                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT c.id AS classId, crsName FROM classes c JOIN courses cr ON c.crsId = cr.id WHERE c.instId = " + setId, con);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ClassItem item = new ClassItem();

                    item.ClassId = Convert.ToInt32(dr["classId"]);
                    item.CrsName = dr["crsName"].ToString();

                    crsComboBox.Items.Add(item);
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
                return ClassId+" - "+CrsName;
            }
        }

        private void crsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassItem selectedClass = crsComboBox.SelectedItem as ClassItem;

            if (selectedClass != null)
            {
                int clsId = selectedClass.ClassId;
                string classId = clsId.ToString();

                ClasssId = classId;

                AssessmentForm af = new AssessmentForm(setId,ClasssId);
                af.Show();
            }
        }
    }
}
