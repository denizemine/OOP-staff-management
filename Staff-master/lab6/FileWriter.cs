using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
namespace lab6
{
   class FileWriter
    {
        string text="";
        long length;
        int writeCursorValue = 0;
        static FormStaffIntro myform;
        public FileWriter(FormStaffIntro formf)
        {
            myform = formf;
        }
        public FileWriter()
        {

        }
        private void UpdateProgressBar()
        {

            writeCursorValue += (int)Math.Round((100.0 / length)+0.4);
            myform.progressBarValueAccessor(writeCursorValue>100 ? 100 : writeCursorValue);
        }

        public void WriteACSVFile(string fileName,List<Staff> staffList)
        {
            length = staffList.Count;
            writeCursorValue = 0;
            myform.progressBarMinimumAccessor(0);
            myform.progressBarMaximumAccessor(100);
            myform.progressBarValueAccessor(0);

            using (StreamWriter writeText = new StreamWriter(fileName))
            {
                foreach(var staff in staffList)
                {
                    text = staff.Id.ToString()+','+staff.Name+','+staff.Surname+','+staff.Address+','+staff.Salary.ToString()+','+staff.City+','+staff.Experience.ToString()+','+staff.ForeignLanguage+',' + staff.HowManyForeignLanguage+','+staff.Education+','+staff.FamilyStatus+','+staff.Role+','+staff.Picture+','+staff.Type;
                    writeText.WriteLine(text);
                    UpdateProgressBar();
                }
            }
        }
        public  void WriteATSVFile(string fileName, List<Staff> staffList)
        {
            length = staffList.Count;
            writeCursorValue = 0;
            myform.progressBarMinimumAccessor(0);
            myform.progressBarMaximumAccessor(100);
            myform.progressBarValueAccessor(0);

            using (StreamWriter writeText = new StreamWriter(fileName))
            {
                foreach (var staff in staffList)
                {
                    text = staff.Id.ToString() + '\t' + staff.Name + '\t' + staff.Surname + '\t' + staff.Address + '\t' + staff.Salary.ToString() + '\t' + staff.City + '\t' + staff.Experience.ToString() + '\t' + staff.ForeignLanguage+ '\t'+staff.HowManyForeignLanguage+ '\t' + staff.Education + '\t' + staff.FamilyStatus + '\t' + staff.Role + '\t'+staff.Picture+'\t'+staff.Type;
                    writeText.WriteLine(text);
                    UpdateProgressBar();
                }
            }
        }
        public void WriteAJSONFile(string fileName, List<Staff> staffList)
        {
            length = staffList.Count;
            writeCursorValue = 0;
            myform.progressBarMinimumAccessor(0);
            myform.progressBarMaximumAccessor(100);
            myform.progressBarValueAccessor(0);

            using (StreamWriter writeText = new StreamWriter(fileName))
            {
                var serializer = new JavaScriptSerializer();
                var serializedResult = serializer.Serialize(staffList);
                writeText.WriteLine(serializedResult);
                //foreach (var staff in staffList)
                //{
                //    UpdateProgressBar();
                //}
            }
        }
    }

}
