using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class RoleClass
    {
        public string CodeInTxt { get; set; }
        public string Role { get; set; }
        public double Factor { get; set; }

        public RoleClass(string codeInTxt, string role, double factor)
        {
            CodeInTxt = codeInTxt;
            Role = role;
            Factor = factor;
        }


    }
}
