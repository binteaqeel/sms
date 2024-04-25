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
    public partial class Admin_Feedback : Form
    {
        public string setId;
        public string setRole;
        public Admin_Feedback(string getId, string role)
        {
            setRole = role;
            setId = getId;
            InitializeComponent();
        }

        private void adFdbkToInst_Click(object sender, EventArgs e)
        {
            Feedback_To_Instructor fdbkinst = new Feedback_To_Instructor(setId,setRole);
            fdbkinst.Show();
        }

        private void adFdbkToStd_Click(object sender, EventArgs e)
        {
            Feedback_To_Student fdbkstd = new Feedback_To_Student(setId,setRole);
            fdbkstd.Show();
        }

        private void showAdFdbk_Click(object sender, EventArgs e)
        {
            Show_Feedback fdbkss = new Show_Feedback(setId, setRole);
            fdbkss.Show();
        }

        private void ShowUsersFdbk_Click(object sender, EventArgs e)
        {
            Show_Feedback showFdbk = new Show_Feedback(setId);
            showFdbk.Show();
        }
    }
}
