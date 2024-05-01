using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManagementSystem
{
    internal class Connection:ConnectionString
    {
        private string conString = "Data Source=DESKTOP-0DG72N5\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True";

        public string conStrings
        {
            get { return conString; }
            set { conString = value; }
        }

        public string GetConnectionString()
        {
            return conStrings;
        }
    }
}
