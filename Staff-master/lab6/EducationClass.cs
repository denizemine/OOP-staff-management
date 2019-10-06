using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class EducationClass
    {
        public string CodeInTxt { get; set; }
        public string EducationDegree { get; set; }
        public double Factor { get; set; }

        public EducationClass(string codeInTxt, string educationDegree, double factor)
        {
            CodeInTxt = codeInTxt;
            EducationDegree = educationDegree;
            Factor = factor;
        }

    }
}
