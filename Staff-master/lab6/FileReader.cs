using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
namespace lab6
{
  class FileReader//there should be no need to create a new class instance to read a file.
    {
        private  long currentPosition = 0;
       static string line;
        static long length;
        static FormStaffIntro myform;
       
        public FileReader(FormStaffIntro formf)
        {
            myform = formf;
        }
        public FileReader()
        {

        }
        private void UpdateProgressBar()
        {

            currentPosition += line.Length+4; // or plus 4 if you need to take into account carriage return
            int value = (int)Math.Round((((decimal) currentPosition / (decimal)length) * (decimal)100),0);
            myform.progressBarValueAccessor(value>100? 100:value) ;
          //  myform.lblProgressBarAccessor(value);
        }


        public List<Staff> ReadACSVFile(string fileLocation)
        {
           
            FileInfo fileInfo = new FileInfo(fileLocation);
            length = fileInfo.Length;
            myform.progressBarMinimumAccessor(0);
            myform.progressBarMaximumAccessor(100);
            currentPosition = 0;
            myform.progressBarValueAccessor(0);
            using (var reader = new StreamReader(fileLocation)) //var is implicitly type
            {
                List<Staff> staffList = new List<Staff>();
                while (!reader.EndOfStream)
                {
                    // var line = reader.ReadLine();
                    line = reader.ReadLine();
                    var values = line.Split(',');

                    Staff staff = new Staff(Convert.ToInt32(values[0]), values[1], values[2], values[3], Convert.ToDouble(values[4]), values[5], values[6], values[7],Convert.ToInt32( values[8]), values[9], values[10], values[11],values[12],values[13]);
                    Console.WriteLine(values[12]);
                    staffList.Add(staff);
                    UpdateProgressBar();

                }

                return staffList;
            }
          
        }

        
      
        public List<Staff> ReadATSVFile(string fileLocation)
        {
            
            FileInfo fileInfo = new FileInfo(fileLocation);
            length = fileInfo.Length;
            myform.progressBarMinimumAccessor(0);
            myform.progressBarMaximumAccessor(100);
            currentPosition = 0;
            myform.progressBarValueAccessor(0);
            using (var reader = new StreamReader(fileLocation)) //var is implicitly type
            {
                List<Staff> staffList = new List<Staff>();
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    var values = line.Split('\t');

                    Staff staff = new Staff(Convert.ToInt32(values[0]), values[1], values[2], values[3], Convert.ToDouble(values[4]), values[5], values[6], values[7], Convert.ToInt32( values[8]), values[9], values[10], values[11], values[12],values[13]);

                    staffList.Add(staff);
                    UpdateProgressBar();

                }

                return staffList;
            }

        }
        public List<Staff> ReadAJSONFile(string fileLocation)
        {
         
            FileInfo fileInfo = new FileInfo(fileLocation);
            length = fileInfo.Length;
            myform.progressBarMinimumAccessor(0);
            myform.progressBarMaximumAccessor(100);
            currentPosition = 0;
            myform.progressBarValueAccessor(0);
            using (var reader = new StreamReader(fileLocation)) //var is implicitly type
            {
                List<Staff> staffList = new List<Staff>();
                while (!reader.EndOfStream)
                {
                     line = reader.ReadToEnd();
                    var serializer = new JavaScriptSerializer();
                    //var serializedResult = serializer.Serialize(line);
                  //var deserializedResult = serializer.Serialize(serializedResult);
                    staffList = serializer.Deserialize<List<Staff>>(line);
                    UpdateProgressBar();

                }

                return staffList;
            }

        }
        public  List<CityClass> ReadACityFile(string fileLocation)
        {

            using (var reader = new StreamReader(fileLocation)) //var is implicitly type
            {
                List<CityClass> cityList = new List<CityClass>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(' ');

                   CityClass city = new CityClass(values[0], values[1],Convert.ToDouble(values[2]));

                    cityList.Add(city);

                }

                return cityList;
            }
        }

        public  List<LanguageClass> ReadALanguageFile(string fileLocation)
        {

            using (var reader = new StreamReader(fileLocation)) //var is implicitly type
            {
                List<LanguageClass> languageList = new List<LanguageClass>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('.');

                    LanguageClass language = new LanguageClass(values[0], values[1], Convert.ToDouble(values[2]));

                    languageList.Add(language);

                }

                return languageList;
            }
        }

        public  List<EducationClass> ReadAEducationFile(string fileLocation)
        {

            using (var reader = new StreamReader(fileLocation)) //var is implicitly type
            {
                List<EducationClass> educationList = new List<EducationClass>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('.');

                    EducationClass education = new EducationClass(values[0], values[1], Convert.ToDouble(values[2]));

                    educationList.Add(education);

                }

                return educationList;
            }
        }

        public  List<FamilyClass> ReadAFamilyFile(string fileLocation)
        {

            using (var reader = new StreamReader(fileLocation)) //var is implicitly type
            {
                List<FamilyClass> familyList = new List<FamilyClass>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('.');

                    FamilyClass family = new FamilyClass(values[0], values[1], Convert.ToDouble(values[2]));

                    familyList.Add(family);

                }

                return familyList;
            }
        }

        public  List<RoleClass> ReadARoleFile(string fileLocation)
        {

            using (var reader = new StreamReader(fileLocation)) //var is implicitly type
            {
                List<RoleClass> roleList = new List<RoleClass>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('.');

                    RoleClass role = new RoleClass(values[0], values[1], Convert.ToDouble(values[2]));

                    roleList.Add(role);

                }

                return roleList;
            }
        }

    }

}
