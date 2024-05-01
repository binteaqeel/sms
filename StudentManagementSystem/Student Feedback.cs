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
    public partial class Student_Feedback : Form
    {
        public string setId;
        public string setRole;
        public string conString;
        Connection conc = new Connection();
        public Student_Feedback(string getId , string role)
        {
            setRole = role;
            setId = getId;
            InitializeComponent();
            conString = conc.conStrings;
        }

        private void stdFdbkToInst_Click(object sender, EventArgs e)
        {
            Feedback_To_Instructor fdbkinst = new Feedback_To_Instructor(setId, setRole);
            fdbkinst.Show();
        }

        private void stdFdbkToAdmin_Click(object sender, EventArgs e)
        {
            Feedback_To_Admin adfdbk = new Feedback_To_Admin(setId, setRole);
            adfdbk.Show();
        }

        private void showStdFdbk_Click(object sender, EventArgs e)
        {
            Show_Feedback showFdbk = new Show_Feedback(setId,setRole);
            showFdbk.Show();
        }
    }
}
