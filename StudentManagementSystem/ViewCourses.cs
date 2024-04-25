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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace StudentManagementSystem
{
   

    public partial class ViewCourses : Form
    {
        public string crsId;
        public string crsName;
        public string crsAbr;
        public string crsDesc;
        public ViewCourses()
        {
            InitializeComponent();

            string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=smsCheck4;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    string query1 = "select * from courses";
                    using (SqlCommand cmd = new SqlCommand(query1, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                ada.Fill(dt);
                                CrsView.DataSource = dt;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Masle Masail \n" + ex);
                }
            }
        }


        private void CrsView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
 
        }

        private void CrsView_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (CrsView.SelectedRows.Count >= 0)
                {
                    crsId = CrsView.SelectedRows[0].Cells[0].Value.ToString();
                    crsName = CrsView.SelectedRows[0].Cells[1].Value.ToString();
                    crsAbr = CrsView.SelectedRows[0].Cells[2].Value.ToString();
                    crsDesc = CrsView.SelectedRows[0].Cells[3].Value.ToString();

                    UpdateDeleteCrs udcrs = new UpdateDeleteCrs(crsId, crsName, crsAbr, crsDesc);
                    udcrs.Show();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Masle Masail! \n" + ex);
            }
        }
    }
}
