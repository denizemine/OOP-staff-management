using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class CityClass
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Factor { get; set; }
        public CityClass(string code,string name,double factor)
            {
            Code = code;
            Name = name;
            Factor = factor;

            }
    }
}
