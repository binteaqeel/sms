using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal interface ConnectionString
    {
        string conStrings { get; set; }
        string GetConnectionString();
    }
}
