using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class FamilyClass
    {
        public string CodeInTxt { get; set; }
        public string FamilyStatus { get; set; }
        public double Factor { get; set; }

        public FamilyClass(string codeInTxt, string familyStatus, double factor)
        {
            CodeInTxt = codeInTxt;
            FamilyStatus = familyStatus;
            Factor = factor;
        }

    }
}
