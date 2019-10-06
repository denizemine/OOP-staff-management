using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public string City { get; set; }//bmo
        public string Experience { get; set; }//bmo
        public string ForeignLanguage { get; set; }
        public int HowManyForeignLanguage { get; set; }
        public string Education { get; set; }
        public string FamilyStatus { get; set; }
        public string Role { get; set; }
        public string Picture { get; set; }
        public string Type { get; set; }
        public  Staff(int id,string name,string surname,string address,double salary,string city,string experience,string foreignLanguage,int howManyForeignLanguage,string education,string familystatus,string role,string picture,string type)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Address = address;
            Salary = salary;
            City = city;
            Experience = experience;
            ForeignLanguage = foreignLanguage;
            HowManyForeignLanguage = howManyForeignLanguage;
            Education = education;
            FamilyStatus = familystatus;
            Role = role;
            Picture = picture;
            Type = type;
        }
        public Staff()
        {

        }
 
    }
}
