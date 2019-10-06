using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
   
    public partial class FormStaffDetails : Form
    {
        string fileName;
        FileWriter fileWriter = new FileWriter();
        List<Staff> stfList;
        Staff foundStaff;

        List<CityClass> cityList;
        List<LanguageClass> languageList;
        List<EducationClass> educationList;
        List<FamilyClass> familyList;
        List<RoleClass> roleList;
        FileReader fileReader = new FileReader();
        double minSalary;
        public FormStaffDetails(List<Staff>stfList, Staff foundStaff,double minSalary)
        {
            this.stfList = stfList;
            this.foundStaff = foundStaff;
            this.minSalary = minSalary;
            InitializeComponent();
        }
        public FormStaffDetails(List<Staff>stfList)
        {
            this.stfList = stfList;
            InitializeComponent();
        }

        private void FormStaffDetails_Load(object sender, EventArgs e)
        {
            if(foundStaff==null)
            {
                txtSalary.Visible = false;
                lblSalary.Visible = false;
            }
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            lblMinSalary.Text = minSalary.ToString();
            
            stfList = fileReader.ReadACSVFile("stafflist.csv");
            string[] cities = {"Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
              "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
              "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir",
              "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
              "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya",
              "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
              "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak",
              "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak",
              "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"};
            string[] experience = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "20+" };
            cmbCity.Items.AddRange(cities);
            cmbExperience.Items.AddRange(experience);

            cityList = fileReader.ReadACityFile("citygroup.txt");

            languageList = fileReader.ReadALanguageFile("foreignlanguage.txt");

            foreach (LanguageClass language in languageList)
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
            if (foundStaff != null)
            {

                txtId.Text = foundStaff.Id.ToString();
                txtName.Text = foundStaff.Name;
                txtSurname.Text = foundStaff.Surname;
                txtAddress.Text = foundStaff.Address;
                txtSalary.Text = foundStaff.Salary.ToString();
                cmbCity.Text = foundStaff.City;
                cmbExperience.Text = foundStaff.Experience;
                if (foundStaff.Type == "fulltime")
                {
                    rbFullTime.Checked = true;
                }
                else if (foundStaff.Type == "parttime")
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

                cmbEducation.Text = foundStaff.Education.ToString();


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


                cmbRole.Text = foundStaff.Role.ToString();
                pbStaffPicture.ImageLocation = foundStaff.Picture.ToString();
            }

        }
        private void AddUpdateDeleteCommonOps()
        {
            try
            {

               
              /*  dgvStaffList.DataSource = null;
                dgvStaffList.DataSource = stfList;*/
                fileWriter.WriteACSVFile("stafflist.csv", stfList);
                fileWriter.WriteATSVFile("stafflist.tsv", stfList);
                fileWriter.WriteAJSONFile("stafflist.json", stfList);

            }
            catch (Exception ex)
            {
                //Log this exception
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                    int staffID = foundStaff.Id;//Convert.ToInt32(dgvStaffList.SelectedCells[0].Value);
                    Staff item = stfList.Find(el => el.Id == staffID);
                    //  var item = stfList.First(el => el.Id == Convert.ToInt32(((Staff)lbStaffLists.SelectedItem).Id));
                    item.Name = txtName.Text;
                    item.Surname = txtSurname.Text;
                    item.Address = txtAddress.Text;
                    item.Salary = Convert.ToDouble(txtSalary.Text);
                    item.City = cmbCity.Text;
                    item.Experience = cmbExperience.Text;

                    string foreignLanguage = "";
                    for (int i = 0; i < clbLanguage.CheckedIndices.Count; i++)
                    {
                        if (i == clbLanguage.CheckedIndices.Count - 1)
                            foreignLanguage += clbLanguage.CheckedItems[i];
                        else
                            foreignLanguage += clbLanguage.CheckedItems[i] + "-";
                    }
                    string family = "";
                    for (int i = 0; i < clbFamily.CheckedIndices.Count; i++)
                    {
                        if (i == clbFamily.CheckedIndices.Count - 1)
                            family += clbFamily.CheckedItems[i];
                        else
                            family += clbFamily.CheckedItems[i] + "-";
                    }

                    item.ForeignLanguage = foreignLanguage;
                    if (txtHowManyLanguage.Text == "")
                    {
                        item.HowManyForeignLanguage = 0;
                    }
                    else
                    {
                        item.HowManyForeignLanguage = Convert.ToInt32(txtHowManyLanguage.Text);

                    }
                    if (rbFullTime.Checked)
                    {
                        item.Type = "fulltime";
                    }
                    else if (rbPartTime.Checked)
                    {
                        item.Type = "parttime";
                    }
                    item.Education = cmbEducation.Text;
                    item.FamilyStatus = family;
                    item.Role = cmbRole.Text;
                    item.Picture = pbStaffPicture.ImageLocation;
                    AddUpdateDeleteCommonOps();
                
            }
            catch (Exception ex)
            {
                //TODO Log this exception.

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
              
                int staffID = foundStaff.Id;
                Staff item = stfList.Find(el => el.Id == staffID);
                stfList.Remove(item);
                AddUpdateDeleteCommonOps();
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
                MessageBox.Show("this person is deleted.");


            }
            catch (Exception ex)
            {
                //TODO Log this exception.
            }
        }
       

        private int randomID()
        {
            Random rand = new Random();
            int randomID = rand.Next(1, 10000);
            while ((stfList.Find(el => el.Id == randomID)) != null)
            {
                randomID = rand.Next(1, 10000);
            }
            return randomID;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
                int id = randomID();
                int element = stfList.FindIndex(el => el.Id == id);
                if (element != -1)
                {
                    MessageBox.Show("bu id kayitlidir.");
                    return;
                }
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string address = txtAddress.Text;
                double salary = Convert.ToDouble(txtSalary.Text);
                string city = cmbCity.Text;
                string experience = cmbExperience.Text;
                string foreignLanguage = "";
                int howManyForeignLanguage;
                if (txtHowManyLanguage.Text =="")
                {
                    howManyForeignLanguage = 0;
                }
                else
                {
                    howManyForeignLanguage = Convert.ToInt32(txtHowManyLanguage.Text);
                }

                for (int i = 0; i < clbLanguage.CheckedIndices.Count; i++)
                {
                    if (i == clbLanguage.CheckedIndices.Count - 1)
                        foreignLanguage += clbLanguage.CheckedItems[i];
                    else
                        foreignLanguage += clbLanguage.CheckedItems[i] + "-";
                }
                string family = "";
                for (int i = 0; i < clbFamily.CheckedIndices.Count; i++)
                {
                    if (i == clbFamily.CheckedIndices.Count - 1)
                        family += clbFamily.CheckedItems[i];
                    else
                        family += clbFamily.CheckedItems[i] + "-";
                }

                string education = cmbEducation.Text;
                string type = " ";
                if (rbFullTime.Checked)
                {
                    type = "fulltime";
                }
                else if (rbPartTime.Checked)
                {
                    type = "parttime";
                }

                string role = cmbRole.Text;
                string picture = pbStaffPicture.ImageLocation;
                PartTimeStaffClass newStaff = new PartTimeStaffClass(id, name, surname, address, salary, city, experience, foreignLanguage, howManyForeignLanguage, education, family, role, picture, type);
                stfList.Add(newStaff);

                AddUpdateDeleteCommonOps();


            
  
        }

        private void btnPictureLoad_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog ofdUserLoad = new OpenFileDialog();
                ofdUserLoad.InitialDirectory = @"`~:\";
                ofdUserLoad.Title = "Select Picture Info";
                ofdUserLoad.Filter = "jpg files (*.jpg)|*.jpg| jpeg files (*.jpeg)|*.jpeg| png files (*.png)|*.png";
                ofdUserLoad.CheckFileExists = true;
                ofdUserLoad.CheckPathExists = true;
                // ofdUserLoad.ShowDialog();

                if (ofdUserLoad.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofdUserLoad.FileName;
                    pbStaffPicture.ImageLocation = fileName;
                    //pbStaffPicture.ImageLocation = "picture\\" + ofdUserLoad.SafeFileName;
                    //MessageBox.Show(ofdUserLoad.InitialDirectory+ofdUserLoad.SafeFileName);

                }
            }
            catch (Exception ex)
            {
                //TODO Log this exception.
            }
        }

        private void txtSalary_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
