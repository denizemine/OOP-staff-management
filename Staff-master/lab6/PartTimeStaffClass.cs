using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class PartTimeStaffClass:Staff
    {
        double factor=0.5;

        public PartTimeStaffClass(int id, string name, string surname, string address, double salary, string city, string experience, string foreignLanguage, int howManyForeignLanguage, string education, string familystatus, string role, string picture, string type):base(id,  name,  surname,  address,  salary,  city,  experience,  foreignLanguage,  howManyForeignLanguage,  education,  familystatus,  role,  picture,  type)
        {

        }

    }
}
