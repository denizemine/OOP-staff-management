using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class LanguageClass
    {
        public string CodeInTxt { get; set; }
        public string ForeignLanguage { get; set; }
        public double Factor { get; set; }
        public LanguageClass(string codeInTxt, string foreignlanguage, double factor)
        {
            CodeInTxt = codeInTxt;
            ForeignLanguage = foreignlanguage;
            Factor = factor;
        }
    }
}
