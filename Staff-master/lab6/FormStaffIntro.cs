using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;

namespace lab6
{
    public partial class FormStaffIntro : Form
    {
        List<Staff> stfList;
        List<CityClass> cityList;
        List<LanguageClass> languageList;
        List<EducationClass> educationList;
        List<FamilyClass> familyList;
        List<RoleClass> roleList;

        BindingSource bs = new BindingSource();
        string fileName;
        string fileExtension;
        const double baseSalary = 4500;
        FileReader fileReader = new FileReader();
        FileWriter fileWriter = new FileWriter();
        FileReader fileReaderForProgress;
        FileWriter fileWriterForProgress;
        public FormStaffIntro()
        {
            InitializeComponent();
            fileReaderForProgress = new FileReader(this);
            fileWriterForProgress = new FileWriter(this);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //To make Winforms full screen
            //this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            
            string[] cities = {"Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
              "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
              "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir",
              "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
              "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya",
              "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
              "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak",
              "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak",
              "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"};
            string[] experience = { "1","2", "3","4", "5","6", "7", "8","9", "10","11","12", "13","14", "15","16", "17","18", "19","20","20+" };
            cmbCity.Items.AddRange(cities);
            cmbExperience.Items.AddRange(experience);

            cityList = fileReader.ReadACityFile("citygroup.txt");


            languageList = fileReader.ReadALanguageFile("foreignlanguage.txt");
            
            foreach(LanguageClass language in languageList)
            {
                clbLanguage.Items.Add(language.ForeignLanguage);
            }

            educationList = fileReader.ReadAEducationFile("education.txt");

            foreach (EducationClass education in educationList)
            {
                cmbEducation.Items.Add(education.EducationDegree);
            }

            familyList = fileReader.ReadAFamilyFile("family.txt");

            foreach (FamilyClass family in familyList)
            {
                clbFamily.Items.Add(family.FamilyStatus);
            }


            roleList = fileReader.ReadARoleFile("role.txt");

            foreach (RoleClass role in roleList)
            {
                cmbRole.Items.Add(role.Role);
                
            }
           
            
            //dgvStaffList.DataSource = stfList;

          

            if (clbLanguage.GetItemChecked(2))
            {
                lblHowManyLanguage.Visible = true;
                txtHowManyLanguage.Visible = true;
            }
            else
            {
                lblHowManyLanguage.Visible = false;
                txtHowManyLanguage.Visible = false;

            }

        }

        private double calculateSalary(Staff foundStaff)
        {
            try
            {
                double staffTypeFactor=1.0;
                if(foundStaff.Type=="fulltime")
                {
                    staffTypeFactor = 1.0;
                   

                }
                else if(foundStaff.Type =="parttime")
                {
                    staffTypeFactor = 0.5;
                }
                double cityFactor;
                if ((cityList.Find(el => el.Name == foundStaff.City)) == null)
                {
                    cityFactor = 0;
                }
                else
                {
                    cityFactor = (cityList.Find(el => el.Name == foundStaff.City)).Factor;
                }
                double experienceFactor = ExperienceClass.GetExperienceFactor(foundStaff.Experience);
                double educationFactor = (educationList.Find(el => el.EducationDegree == foundStaff.Education)).Factor;

                double roleFactor = (roleList.Find(el => el.Role == foundStaff.Role)).Factor;

                double languageFactor = 0;
                string foreignLanguage = "";
                for (int i = 0; i < clbLanguage.CheckedIndices.Count; i++)
                {
                    string staffForeignLanguage = foundStaff.ForeignLanguage.ToString();

                    var languageValues = staffForeignLanguage.Split('-');

                    var foundLanguage = languageList.Find(el => el.ForeignLanguage == languageValues[i]);
                    if (foundLanguage.ForeignLanguage == clbLanguage.Items[2].ToString())
                        languageFactor += (foundLanguage).Factor * foundStaff.HowManyForeignLanguage;
                    else
                        languageFactor += (foundLanguage).Factor;
                }


                double familyFactor = 0;
                string family = "";
                for (int i = 0; i < clbFamily.CheckedIndices.Count; i++)
                {
                    string staffFamily = foundStaff.FamilyStatus.ToString();

                    var familyValues = staffFamily.Split('-');

                    var foundFamily = familyList.Find(el => el.FamilyStatus == familyValues[i]);
                    familyFactor += foundFamily.Factor;
                }

                double totalFactor = cityFactor + familyFactor + languageFactor + educationFactor + roleFactor + cityFactor + experienceFactor;

                return (baseSalary * (totalFactor + 1)* staffTypeFactor);
            }
            catch(Exception ex)
            {
                //Log this exception
                return 0;
            }
           
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                FormStaffDetails staffDetailsForm = new FormStaffDetails(stfList);
                staffDetailsForm.Show();


            }
            catch (Exception ex)
            {
            }
               
            }

        
        private void btnLoad_Click(object sender, EventArgs e)
        {
                OpenFileDialog ofdUserLoad = new OpenFileDialog();
                ofdUserLoad.InitialDirectory = @"`~:\";
                ofdUserLoad.Title = "Select Staff Info";
                ofdUserLoad.Filter = "csv files (*.csv)|*.csv| tsv files (*.tsv)|*.tsv| json files (*.json)|*.json";
                ofdUserLoad.CheckFileExists = true;
                ofdUserLoad.CheckPathExists = true;
                // ofdUserLoad.ShowDialog();

                if (ofdUserLoad.ShowDialog() == DialogResult.OK)
                {

                    fileName = ofdUserLoad.FileName;
                    fileExtension = Path.GetExtension(ofdUserLoad.SafeFileName);
                    if (fileExtension == ".csv")
                    {
                        stfList = fileReader.ReadACSVFile(fileName);
                    }
                    else if (fileExtension == ".tsv")
                    {
                        stfList = fileReader.ReadATSVFile(fileName);
                    }
                    else if (fileExtension == ".json")
                    {
                       // dgvStaffList.DataSource = null;

                         stfList = fileReader.ReadAJSONFile(fileName);
                        //var serializer = new JavaScriptSerializer();
                        //var serializedResult = serializer.Serialize(stfList);
                        //stfList= serializer.Deserialize<List<Staff>>(serializedResult);

                    }
                    else
                    {
                        MessageBox.Show("wrong file extension!!!");
                    }


                    dgvStaffList.DataSource = stfList;
                    //dgvStaffList.ClearSelection();
                    btnAdd.Enabled = true;
                    btnTsvExport.Enabled = true;
                    btnCsvExport.Enabled = true;
                    btnJsonExport.Enabled = true;
                }
          
        }

    

        private void dgvStaffList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvStaffList.SelectedCells.Count != 0)
                {
                    int staffID = Convert.ToInt32(dgvStaffList.SelectedCells[0].Value);
                    Staff foundStaff = stfList.Find(el => el.Id == staffID);
                    txtId.Text = foundStaff.Id.ToString();
                    txtName.Text = foundStaff.Name;
                    txtSurname.Text = foundStaff.Surname;
                    txtAddress.Text = foundStaff.Address;
                    txtSalary.Text = foundStaff.Salary.ToString();
                    cmbCity.Text = foundStaff.City;
                    cmbExperience.Text = foundStaff.Experience;
                    txtHowManyLanguage.Text = foundStaff.HowManyForeignLanguage.ToString();

                    if(foundStaff.Type=="fulltime")
                    {
                        rbFullTime.Checked = true;
                    }
                    else if(foundStaff.Type=="parttime")
                    {
                        rbPartTime.Checked = true;
                    }
                    string staffForeignLanguage = foundStaff.ForeignLanguage.ToString();

                    var languageValues = staffForeignLanguage.Split('-');

                    for (int i = 0; i < clbLanguage.Items.Count; i++)
                    {
                        clbLanguage.SetItemChecked(i, false);
                    }

                    for (int i = 0; i < languageValues.Length; i++)
                    {
                        int index = clbLanguage.Items.IndexOf(languageValues[i]);
                        if (index != -1)
                            clbLanguage.SetItemChecked(index, true);
                    }
                    string staffFamily = foundStaff.FamilyStatus.ToString();
                    var familyValues = staffFamily.Split('-');

                    for (int i = 0; i < clbFamily.Items.Count; i++)
                    {
                        clbFamily.SetItemChecked(i, false);
                    }

                    for (int i = 0; i < familyValues.Length; i++)
                    {
                        int index = clbFamily.Items.IndexOf(familyValues[i]);
                        if (index != -1)
                            clbFamily.SetItemChecked(index, true);
                    }

                    cmbEducation.Text = foundStaff.Education.ToString();

                    cmbRole.Text = foundStaff.Role.ToString();
                    pbStaffPicture.ImageLocation = foundStaff.Picture;
               
                    if (clbLanguage.GetItemChecked(2))
                    {
                        lblHowManyLanguage.Visible = true;
                        txtHowManyLanguage.Visible = true;
                    }
                    else
                    {
                        lblHowManyLanguage.Visible = false;
                        txtHowManyLanguage.Visible = false;
                    }
                   
                }
                else
                {
                    txtId.Clear();
                    txtName.Clear();
                    txtSurname.Clear();
                    txtAddress.Clear();
                    txtSalary.Clear();
                    cmbCity.Text = " ";
                    cmbExperience.Text = " ";
                    for (int i = 0; i < clbLanguage.Items.Count; i++)
                    {
                        clbLanguage.SetItemChecked(i, false);
                    }
                    for (int i = 0; i < clbFamily.Items.Count; i++)
                    {
                        clbFamily.SetItemChecked(i, false);
                    }
                    cmbEducation.Text = " ";
                    txtHowManyLanguage.Text = " ";
                    cmbRole.Text = " ";
                    pbStaffPicture.ImageLocation = " ";

                }
            }
            catch (Exception ex)
            {
                //TODO Log this exception.
            }
        }

        private void dgvStaffList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvStaffList.SelectedCells.Count != 0)
                {
                    int staffID = Convert.ToInt32(dgvStaffList.SelectedCells[0].Value);
                    Staff foundStaff = stfList.Find(el => el.Id == staffID);

                    double minSalary = calculateSalary(foundStaff);

                    FormStaffDetails staffDetailsForm = new FormStaffDetails(stfList, foundStaff, minSalary);
                    staffDetailsForm.Show();

                }
            }
            catch (Exception ex)
            {
                //TODO Log this exception.
            }

        }

        private void clbLanguage_Click(object sender, EventArgs e)
        {
        }

        private void dgvStaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvStaffList.ReadOnly = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnJsonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdUserExport = new SaveFileDialog();
            sfdUserExport.InitialDirectory = @"`~:\";
            sfdUserExport.Title = "Select Staff Info";
            sfdUserExport.Filter = " json files (*.json)|*.json";
            if (sfdUserExport.ShowDialog() == DialogResult.OK)
            {
                fileWriter.WriteAJSONFile(sfdUserExport.FileName, stfList);
            }
           

        }

        private void btnTsvExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdUserExport = new SaveFileDialog();
            sfdUserExport.InitialDirectory = @"`~:\";
            sfdUserExport.Title = "Select Staff Info";
            sfdUserExport.Filter = " tsv files (*.tsv)|*.tsv";
           if( sfdUserExport.ShowDialog()==DialogResult.OK)
            {
                fileWriter.WriteATSVFile(sfdUserExport.FileName, stfList);
            }
           
           
        }

        private void btnCsvExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdUserExport = new SaveFileDialog();
            sfdUserExport.InitialDirectory = @"`~:\";
            sfdUserExport.Title = "Select Staff Info";
            sfdUserExport.Filter = " csv files (*.csv)|*.csv";
            if (sfdUserExport.ShowDialog() == DialogResult.OK)
            {
                fileWriter.WriteACSVFile(sfdUserExport.FileName, stfList);
            }
        }

        private void rbAscending_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAscending.Checked)
            {
                stfList = MergeSortClass.Sort(stfList, "ascending");

                dgvStaffList.DataSource = null;
                dgvStaffList.DataSource = stfList;
            }

        }

   
        private void rbDescending_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbDescending.Checked)
            {
                stfList = MergeSortClass.Sort(stfList, "descending");
                dgvStaffList.DataSource = null;
                dgvStaffList.DataSource = stfList;

            }
        }
        public void progressBarValueAccessor(int v)
        {
            if(InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate { progressBarValueAccessor(v); });
                return;
            }
            
            pbImportExport.Value = v;
        }
        public void progressBarMinimumAccessor(int v)
        {
            pbImportExport.Minimum = v;
          
        }
        public void progressBarMaximumAccessor(int v)
        {
            pbImportExport.Maximum =v;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Really want to exit?";
            const string caption = "EXIT";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /*  public void lblProgressBarAccessor(int v)
 {
     lblProgressBar.Text = v.ToString();
 }*/
    }
}
