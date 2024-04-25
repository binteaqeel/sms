using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Instructor_Feedback : Form
    {
        public string setId;
        public string setRole;
        public Instructor_Feedback(string getId, string role)
        {
            setRole = role;
            setId = getId;
            InitializeComponent();
        }

        private void instFdbkTostd_Click(object sender, EventArgs e)
        {
            Feedback_To_Student fdbkstd = new Feedback_To_Student(setId, setRole);
            fdbkstd.Show();
        }

        private void instFdbkToAdmin_Click(object sender, EventArgs e)
        {
            Feedback_To_Admin adfdbk = new Feedback_To_Admin(setId, setRole);
            adfdbk.Show();
        }

        private void showInstFdbk_Click(object sender, EventArgs e)
        {
            Show_Feedback showFdbk = new Show_Feedback(setId,setRole);
            showFdbk.Show();
        }
    }
}
