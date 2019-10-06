using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class ExperienceClass
    {
        public static double GetExperienceFactor(string experience )
        {
            int exp;
            if (experience.Contains('+'))
                return 1.5;
            else
                exp = Convert.ToInt32(experience);
           if (exp >= 0 && exp < 2)
            {
                return 0;
            }

            else if (exp>=2 && exp<=4)
            {
                return 0.6;
            }
            else if(exp>=5 &&exp<=9)
            {
                return 1;
            }
            else if (exp >= 10 && exp <= 14)
            {
                return 1.2;
            }
            else if (exp >=15 && exp <= 20)
            {
                return 1.35;
            }
            else
            {
                return 1.5;
            }

        }




    }
}
