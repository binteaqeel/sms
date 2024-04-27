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
    public partial class PaymentBill : Form
    {
        public string setId;
        public PaymentBill(string getId)
        {
            InitializeComponent();
            setId = getId;

            stdId.Text = setId;

            string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string queryForName = "Select Fname from students where id = " + getId;
            SqlCommand command = new SqlCommand(queryForName, con);
            
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    stdName.Text = reader[i].ToString();

                }
            }

            reader.Close();
            command.Dispose();



            string queryForCrdHr = "SELECT SUM(CrdHrs) AS TotalCreditHours FROM classes c JOIN stdClassRequest sr ON c.id = sr.classId JOIN semester s ON c.semId = s.id WHERE sr.stdId = " + getId;
            SqlCommand command2 = new SqlCommand(queryForCrdHr, con);

            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                for (int i = 0; i < reader2.FieldCount; i++)
                {
                    TNOCH.Text = reader2[i].ToString();

                }
            }

            reader2.Close();
            command2.Dispose();


            string queryForTotalFee = "SELECT SUM(C.CrdHrs * S.FeePerCrdHr) AS TotalFee FROM classes C JOIN semester S ON C.semId = S.id JOIN stdClassRequest SR ON C.id = SR.classId WHERE SR.stdId =" + getId;
            SqlCommand command3 = new SqlCommand(queryForTotalFee, con);

            SqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {
                for (int i = 0; i < reader3.FieldCount; i++)
                {
                    TotalBill.Text = reader3[i].ToString();

                }
            }

            reader3.Close();
            command3.Dispose();

            string queryForFeePerCreditHr = "SELECT s.FeePerCrdHr FROM semester s JOIN UpdrageStudents us ON s.id = us.semId WHERE us.stdId =" + getId;
            SqlCommand command4 = new SqlCommand(queryForFeePerCreditHr, con);

            SqlDataReader reader4 = command4.ExecuteReader();

            while (reader4.Read())
            {
                for (int i = 0; i < reader4.FieldCount; i++)
                {
                    FeeCrdHr.Text = reader4[i].ToString();
                }
            }

            reader4.Close();
            command4.Dispose();
            con.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
