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
    public partial class GradeHistory : Form
    {
        public GradeHistory(string getId)
        {
            InitializeComponent();

            try
            {
                string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(conString))
                {

                    string query1 = "SELECT  rs.classId, MIN(c.crsName) AS CourseName, " +
                        "MAX(rs.statuss) AS Status, CONCAT(MAX(rs.Perrcentage), '%') " +
                        "AS Percentage FROM resultStatus rs INNER JOIN classes cl ON " +
                        "rs.classId = cl.id INNER JOIN courses c ON cl.crsId = c.id " +
                        "WHERE  rs.stdId = "+getId+" GROUP BY rs.classId";
                    using (SqlCommand cmd = new SqlCommand(query1, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                ada.Fill(dt);
                                gradeView.DataSource = dt;
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
