namespace lab6
{
    partial class FormStaffIntro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cmbEducation = new System.Windows.Forms.ComboBox();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pbStaffPicture = new System.Windows.Forms.PictureBox();
            this.lblResim = new System.Windows.Forms.Label();
            this.clbLanguage = new System.Windows.Forms.CheckedListBox();
            this.dgvStaffList = new System.Windows.Forms.DataGridView();
            this.clbFamily = new System.Windows.Forms.CheckedListBox();
            this.txtHowManyLanguage = new System.Windows.Forms.TextBox();
            this.lblHowManyLanguage = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbExperience = new System.Windows.Forms.ComboBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.gbStaffType = new System.Windows.Forms.GroupBox();
            this.rbPartTime = new System.Windows.Forms.RadioButton();
            this.rbFullTime = new System.Windows.Forms.RadioButton();
            this.btnJsonExport = new System.Windows.Forms.Button();
            this.btnTsvExport = new System.Windows.Forms.Button();
            this.btnCsvExport = new System.Windows.Forms.Button();
            this.rbAscending = new System.Windows.Forms.RadioButton();
            this.rbDescending = new System.Windows.Forms.RadioButton();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.pbImportExport = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbStaffType.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(142, 920);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 62);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLanguage.Location = new System.Drawing.Point(12, 384);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(119, 24);
            this.lblLanguage.TabIndex = 21;
            this.lblLanguage.Text = "LANGUAGE:";
            // 
            // cmbEducation
            // 
            this.cmbEducation.FormattingEnabled = true;
            this.cmbEducation.Location = new System.Drawing.Point(150, 529);
            this.cmbEducation.Name = "cmbEducation";
            this.cmbEducation.Size = new System.Drawing.Size(279, 24);
            this.cmbEducation.TabIndex = 22;
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEducation.Location = new System.Drawing.Point(12, 529);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(112, 20);
            this.lblEducation.TabIndex = 23;
            this.lblEducation.Text = "EDUCATİON:";
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFamily.Location = new System.Drawing.Point(10, 569);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(82, 24);
            this.lblFamily.TabIndex = 24;
            this.lblFamily.Text = "FAMILY:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRole.Location = new System.Drawing.Point(15, 704);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(66, 24);
            this.lblRole.TabIndex = 26;
            this.lblRole.Text = "ROLE:";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(150, 707);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(279, 24);
            this.cmbRole.TabIndex = 27;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(32, 920);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 55);
            this.btnLoad.TabIndex = 28;
            this.btnLoad.Text = "Load ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbStaffPicture
            // 
            this.pbStaffPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStaffPicture.Location = new System.Drawing.Point(150, 737);
            this.pbStaffPicture.Name = "pbStaffPicture";
            this.pbStaffPicture.Size = new System.Drawing.Size(183, 132);
            this.pbStaffPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStaffPicture.TabIndex = 29;
            this.pbStaffPicture.TabStop = false;
            // 
            // lblResim
            // 
            this.lblResim.AutoSize = true;
            this.lblResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResim.Location = new System.Drawing.Point(12, 758);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(95, 24);
            this.lblResim.TabIndex = 30;
            this.lblResim.Text = "PICTURE:";
            // 
            // clbLanguage
            // 
            this.clbLanguage.FormattingEnabled = true;
            this.clbLanguage.Location = new System.Drawing.Point(150, 379);
            this.clbLanguage.Name = "clbLanguage";
            this.clbLanguage.Size = new System.Drawing.Size(271, 72);
            this.clbLanguage.TabIndex = 32;
            this.clbLanguage.Click += new System.EventHandler(this.clbLanguage_Click);
            // 
            // dgvStaffList
            // 
            this.dgvStaffList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffList.Location = new System.Drawing.Point(507, 4);
            this.dgvStaffList.Name = "dgvStaffList";
            this.dgvStaffList.ReadOnly = true;
            this.dgvStaffList.RowTemplate.Height = 24;
            this.dgvStaffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffList.Size = new System.Drawing.Size(1421, 515);
            this.dgvStaffList.TabIndex = 33;
            this.dgvStaffList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffList_CellContentClick);
            this.dgvStaffList.SelectionChanged += new System.EventHandler(this.dgvStaffList_SelectionChanged);
            this.dgvStaffList.DoubleClick += new System.EventHandler(this.dgvStaffList_DoubleClick);
            // 
            // clbFamily
            // 
            this.clbFamily.FormattingEnabled = true;
            this.clbFamily.Location = new System.Drawing.Point(150, 569);
            this.clbFamily.Name = "clbFamily";
            this.clbFamily.Size = new System.Drawing.Size(278, 106);
            this.clbFamily.TabIndex = 34;
            // 
            // txtHowManyLanguage
            // 
            this.txtHowManyLanguage.Location = new System.Drawing.Point(268, 486);
            this.txtHowManyLanguage.Name = "txtHowManyLanguage";
            this.txtHowManyLanguage.Size = new System.Drawing.Size(153, 22);
            this.txtHowManyLanguage.TabIndex = 35;
            // 
            // lblHowManyLanguage
            // 
            this.lblHowManyLanguage.AutoSize = true;
            this.lblHowManyLanguage.Location = new System.Drawing.Point(13, 486);
            this.lblHowManyLanguage.Name = "lblHowManyLanguage";
            this.lblHowManyLanguage.Size = new System.Drawing.Size(233, 17);
            this.lblHowManyLanguage.TabIndex = 36;
            this.lblHowManyLanguage.Text = "Foreign Languages Without English";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExperience.Location = new System.Drawing.Point(12, 326);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(54, 24);
            this.lblExperience.TabIndex = 19;
            this.lblExperience.Text = "EXP:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Location = new System.Drawing.Point(10, 282);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 24);
            this.lblCity.TabIndex = 18;
            this.lblCity.Text = "CİTY:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalary.Location = new System.Drawing.Point(10, 240);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(88, 24);
            this.lblSalary.TabIndex = 17;
            this.lblSalary.Text = "SALARY:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Location = new System.Drawing.Point(10, 123);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(104, 24);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "ADDRESS:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(10, 74);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(109, 24);
            this.lblSurname.TabIndex = 15;
            this.lblSurname.Text = "SURNAME:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(10, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "NAME:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Enabled = false;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(10, 4);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 24);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "ID:";
            // 
            // cmbExperience
            // 
            this.cmbExperience.FormattingEnabled = true;
            this.cmbExperience.Location = new System.Drawing.Point(150, 328);
            this.cmbExperience.Name = "cmbExperience";
            this.cmbExperience.Size = new System.Drawing.Size(271, 24);
            this.cmbExperience.TabIndex = 12;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(150, 242);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(271, 22);
            this.txtSalary.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(150, 123);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(271, 105);
            this.txtAddress.TabIndex = 7;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(150, 73);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(271, 22);
            this.txtSurname.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(150, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(271, 22);
            this.txtId.TabIndex = 4;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(150, 284);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(271, 24);
            this.cmbCity.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.gbStaffType);
            this.panel1.Controls.Add(this.cmbCity);
            this.panel1.Controls.Add(this.clbFamily);
            this.panel1.Controls.Add(this.pbStaffPicture);
            this.panel1.Controls.Add(this.lblResim);
            this.panel1.Controls.Add(this.txtHowManyLanguage);
            this.panel1.Controls.Add(this.lblHowManyLanguage);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.cmbRole);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.clbLanguage);
            this.panel1.Controls.Add(this.lblFamily);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.lblEducation);
            this.panel1.Controls.Add(this.cmbExperience);
            this.panel1.Controls.Add(this.cmbEducation);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblSalary);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.lblExperience);
            this.panel1.Controls.Add(this.lblLanguage);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 912);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblType.Location = new System.Drawing.Point(345, 756);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(63, 25);
            this.lblType.TabIndex = 40;
            this.lblType.Text = "Type:";
            // 
            // gbStaffType
            // 
            this.gbStaffType.Controls.Add(this.rbPartTime);
            this.gbStaffType.Controls.Add(this.rbFullTime);
            this.gbStaffType.Location = new System.Drawing.Point(350, 791);
            this.gbStaffType.Name = "gbStaffType";
            this.gbStaffType.Size = new System.Drawing.Size(126, 78);
            this.gbStaffType.TabIndex = 39;
            this.gbStaffType.TabStop = false;
            this.gbStaffType.Text = "Staff Type";
            // 
            // rbPartTime
            // 
            this.rbPartTime.AutoSize = true;
            this.rbPartTime.Location = new System.Drawing.Point(10, 21);
            this.rbPartTime.Name = "rbPartTime";
            this.rbPartTime.Size = new System.Drawing.Size(86, 21);
            this.rbPartTime.TabIndex = 37;
            this.rbPartTime.TabStop = true;
            this.rbPartTime.Text = "PartTime";
            this.rbPartTime.UseVisualStyleBackColor = true;
            // 
            // rbFullTime
            // 
            this.rbFullTime.AutoSize = true;
            this.rbFullTime.Location = new System.Drawing.Point(10, 48);
            this.rbFullTime.Name = "rbFullTime";
            this.rbFullTime.Size = new System.Drawing.Size(82, 21);
            this.rbFullTime.TabIndex = 38;
            this.rbFullTime.TabStop = true;
            this.rbFullTime.Text = "FullTime";
            this.rbFullTime.UseVisualStyleBackColor = true;
            // 
            // btnJsonExport
            // 
            this.btnJsonExport.Enabled = false;
            this.btnJsonExport.Location = new System.Drawing.Point(547, 558);
            this.btnJsonExport.Name = "btnJsonExport";
            this.btnJsonExport.Size = new System.Drawing.Size(170, 57);
            this.btnJsonExport.TabIndex = 38;
            this.btnJsonExport.Text = "Json Export";
            this.btnJsonExport.UseVisualStyleBackColor = true;
            this.btnJsonExport.Click += new System.EventHandler(this.btnJsonExport_Click);
            // 
            // btnTsvExport
            // 
            this.btnTsvExport.Enabled = false;
            this.btnTsvExport.Location = new System.Drawing.Point(733, 558);
            this.btnTsvExport.Name = "btnTsvExport";
            this.btnTsvExport.Size = new System.Drawing.Size(170, 57);
            this.btnTsvExport.TabIndex = 39;
            this.btnTsvExport.Text = "Tsv Export";
            this.btnTsvExport.UseVisualStyleBackColor = true;
            this.btnTsvExport.Click += new System.EventHandler(this.btnTsvExport_Click);
            // 
            // btnCsvExport
            // 
            this.btnCsvExport.Enabled = false;
            this.btnCsvExport.Location = new System.Drawing.Point(922, 558);
            this.btnCsvExport.Name = "btnCsvExport";
            this.btnCsvExport.Size = new System.Drawing.Size(170, 57);
            this.btnCsvExport.TabIndex = 40;
            this.btnCsvExport.Text = "Csv Export";
            this.btnCsvExport.UseVisualStyleBackColor = true;
            this.btnCsvExport.Click += new System.EventHandler(this.btnCsvExport_Click);
            // 
            // rbAscending
            // 
            this.rbAscending.AutoSize = true;
            this.rbAscending.Location = new System.Drawing.Point(27, 21);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(95, 21);
            this.rbAscending.TabIndex = 41;
            this.rbAscending.TabStop = true;
            this.rbAscending.Text = "Ascending";
            this.rbAscending.UseVisualStyleBackColor = true;
            this.rbAscending.CheckedChanged += new System.EventHandler(this.rbAscending_CheckedChanged);
            // 
            // rbDescending
            // 
            this.rbDescending.AutoSize = true;
            this.rbDescending.Location = new System.Drawing.Point(27, 48);
            this.rbDescending.Name = "rbDescending";
            this.rbDescending.Size = new System.Drawing.Size(104, 21);
            this.rbDescending.TabIndex = 42;
            this.rbDescending.TabStop = true;
            this.rbDescending.Text = "Descending";
            this.rbDescending.UseVisualStyleBackColor = true;
            this.rbDescending.CheckedChanged += new System.EventHandler(this.rbDescending_CheckedChanged_1);
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.rbAscending);
            this.gbSort.Controls.Add(this.rbDescending);
            this.gbSort.Location = new System.Drawing.Point(547, 669);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(178, 83);
            this.gbSort.TabIndex = 43;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "SORT";
            // 
            // pbImportExport
            // 
            this.pbImportExport.Location = new System.Drawing.Point(733, 669);
            this.pbImportExport.Name = "pbImportExport";
            this.pbImportExport.Size = new System.Drawing.Size(221, 51);
            this.pbImportExport.TabIndex = 44;
            // 
            // FormStaffIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1710, 844);
            this.Controls.Add(this.pbImportExport);
            this.Controls.Add(this.gbSort);
            this.Controls.Add(this.btnCsvExport);
            this.Controls.Add(this.btnTsvExport);
            this.Controls.Add(this.btnJsonExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStaffList);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormStaffIntro";
            this.Text = "Staff Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbStaffType.ResumeLayout(false);
            this.gbStaffType.PerformLayout();
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cmbEducation;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pbStaffPicture;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.CheckedListBox clbLanguage;
        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.CheckedListBox clbFamily;
        private System.Windows.Forms.TextBox txtHowManyLanguage;
        private System.Windows.Forms.Label lblHowManyLanguage;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbExperience;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJsonExport;
        private System.Windows.Forms.Button btnTsvExport;
        private System.Windows.Forms.Button btnCsvExport;
        private System.Windows.Forms.RadioButton rbAscending;
        private System.Windows.Forms.RadioButton rbDescending;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.ProgressBar pbImportExport;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox gbStaffType;
        private System.Windows.Forms.RadioButton rbPartTime;
        private System.Windows.Forms.RadioButton rbFullTime;
    }
}

