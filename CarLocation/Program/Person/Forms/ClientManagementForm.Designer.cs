namespace CarLocation
{
    partial class ClientManagementForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.editPage = new System.Windows.Forms.TabPage();
            this.pnEditSecondayDriver2 = new System.Windows.Forms.Panel();
            this.Edittxt_secondaryDriver_lname = new System.Windows.Forms.TextBox();
            this.EditbtnAddSecondaryDriver = new System.Windows.Forms.Button();
            this.EditbtnSaveSecondaryDriver = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Edittxt_secondaryDriver_drivingLicence = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Edittxt_secondaryDriver_fname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EditLvSecondaryDrivers = new System.Windows.Forms.ListView();
            this.lname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driver_licence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editPhoneTextBox = new System.Windows.Forms.TextBox();
            this.editClientCodeTextBox = new System.Windows.Forms.TextBox();
            this.editBankCardTextBox = new System.Windows.Forms.TextBox();
            this.editDrivingLicenceTextBox = new System.Windows.Forms.TextBox();
            this.editAddressTextBox = new System.Windows.Forms.TextBox();
            this.editFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.editNameTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.editCheckCodeButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addPage = new System.Windows.Forms.TabPage();
            this.pnSecondaryDriver = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.ModifybtnSecondaryDrivers = new System.Windows.Forms.Button();
            this.lnameSecondaryDriver = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.fnameSecondaryDriver = new System.Windows.Forms.TextBox();
            this.addbtnSecondaryDrivers = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.driverLicenceSecondaryDriver = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lvSecondaryDrivers = new System.Windows.Forms.ListView();
            this.lvLname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLicence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = new System.Windows.Forms.TextBox();
            this.cardNumber = new System.Windows.Forms.TextBox();
            this.drivingLicence = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.DelbtnSecondaryDrivers = new System.Windows.Forms.Button();
            this.EditbtnDeleteSecondaryDriver = new System.Windows.Forms.Button();
            this.editPage.SuspendLayout();
            this.pnEditSecondayDriver2.SuspendLayout();
            this.addPage.SuspendLayout();
            this.pnSecondaryDriver.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(9, 494);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 35);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(269, 494);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 35);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Enregistrer";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // editPage
            // 
            this.editPage.Controls.Add(this.pnEditSecondayDriver2);
            this.editPage.Controls.Add(this.label12);
            this.editPage.Controls.Add(this.EditLvSecondaryDrivers);
            this.editPage.Controls.Add(this.editPhoneTextBox);
            this.editPage.Controls.Add(this.editClientCodeTextBox);
            this.editPage.Controls.Add(this.editBankCardTextBox);
            this.editPage.Controls.Add(this.editDrivingLicenceTextBox);
            this.editPage.Controls.Add(this.editAddressTextBox);
            this.editPage.Controls.Add(this.editFirstNameTextBox);
            this.editPage.Controls.Add(this.editNameTextBox);
            this.editPage.Controls.Add(this.label18);
            this.editPage.Controls.Add(this.editCheckCodeButton);
            this.editPage.Controls.Add(this.label11);
            this.editPage.Controls.Add(this.label6);
            this.editPage.Controls.Add(this.label7);
            this.editPage.Controls.Add(this.label8);
            this.editPage.Controls.Add(this.label9);
            this.editPage.Controls.Add(this.label10);
            this.editPage.Location = new System.Drawing.Point(4, 22);
            this.editPage.Name = "editPage";
            this.editPage.Padding = new System.Windows.Forms.Padding(3);
            this.editPage.Size = new System.Drawing.Size(370, 460);
            this.editPage.TabIndex = 1;
            this.editPage.Text = "Modifier";
            this.editPage.UseVisualStyleBackColor = true;
            // 
            // pnEditSecondayDriver2
            // 
            this.pnEditSecondayDriver2.Controls.Add(this.EditbtnDeleteSecondaryDriver);
            this.pnEditSecondayDriver2.Controls.Add(this.Edittxt_secondaryDriver_lname);
            this.pnEditSecondayDriver2.Controls.Add(this.EditbtnAddSecondaryDriver);
            this.pnEditSecondayDriver2.Controls.Add(this.EditbtnSaveSecondaryDriver);
            this.pnEditSecondayDriver2.Controls.Add(this.label15);
            this.pnEditSecondayDriver2.Controls.Add(this.label14);
            this.pnEditSecondayDriver2.Controls.Add(this.Edittxt_secondaryDriver_drivingLicence);
            this.pnEditSecondayDriver2.Controls.Add(this.label13);
            this.pnEditSecondayDriver2.Controls.Add(this.Edittxt_secondaryDriver_fname);
            this.pnEditSecondayDriver2.Location = new System.Drawing.Point(0, 350);
            this.pnEditSecondayDriver2.Name = "pnEditSecondayDriver2";
            this.pnEditSecondayDriver2.Size = new System.Drawing.Size(365, 110);
            this.pnEditSecondayDriver2.TabIndex = 19;
            // 
            // Edittxt_secondaryDriver_lname
            // 
            this.Edittxt_secondaryDriver_lname.Enabled = false;
            this.Edittxt_secondaryDriver_lname.Location = new System.Drawing.Point(157, 3);
            this.Edittxt_secondaryDriver_lname.MaxLength = 30;
            this.Edittxt_secondaryDriver_lname.Name = "Edittxt_secondaryDriver_lname";
            this.Edittxt_secondaryDriver_lname.Size = new System.Drawing.Size(206, 20);
            this.Edittxt_secondaryDriver_lname.TabIndex = 53;
            // 
            // EditbtnAddSecondaryDriver
            // 
            this.EditbtnAddSecondaryDriver.Enabled = false;
            this.EditbtnAddSecondaryDriver.Location = new System.Drawing.Point(127, 81);
            this.EditbtnAddSecondaryDriver.Name = "EditbtnAddSecondaryDriver";
            this.EditbtnAddSecondaryDriver.Size = new System.Drawing.Size(75, 23);
            this.EditbtnAddSecondaryDriver.TabIndex = 59;
            this.EditbtnAddSecondaryDriver.Text = "Ajouter";
            this.EditbtnAddSecondaryDriver.UseVisualStyleBackColor = true;
            this.EditbtnAddSecondaryDriver.Click += new System.EventHandler(this.EditbtnAddSecondaryDriver_Click);
            // 
            // EditbtnSaveSecondaryDriver
            // 
            this.EditbtnSaveSecondaryDriver.Location = new System.Drawing.Point(208, 81);
            this.EditbtnSaveSecondaryDriver.Name = "EditbtnSaveSecondaryDriver";
            this.EditbtnSaveSecondaryDriver.Size = new System.Drawing.Size(75, 23);
            this.EditbtnSaveSecondaryDriver.TabIndex = 58;
            this.EditbtnSaveSecondaryDriver.Text = "Modifier";
            this.EditbtnSaveSecondaryDriver.UseVisualStyleBackColor = true;
            this.EditbtnSaveSecondaryDriver.Click += new System.EventHandler(this.EditbtnSaveSecondaryDriver_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Nom : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Prénom :";
            // 
            // Edittxt_secondaryDriver_drivingLicence
            // 
            this.Edittxt_secondaryDriver_drivingLicence.Enabled = false;
            this.Edittxt_secondaryDriver_drivingLicence.Location = new System.Drawing.Point(157, 55);
            this.Edittxt_secondaryDriver_drivingLicence.MaxLength = 30;
            this.Edittxt_secondaryDriver_drivingLicence.Name = "Edittxt_secondaryDriver_drivingLicence";
            this.Edittxt_secondaryDriver_drivingLicence.Size = new System.Drawing.Size(206, 20);
            this.Edittxt_secondaryDriver_drivingLicence.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "No Permis Conduire:";
            // 
            // Edittxt_secondaryDriver_fname
            // 
            this.Edittxt_secondaryDriver_fname.Enabled = false;
            this.Edittxt_secondaryDriver_fname.Location = new System.Drawing.Point(157, 29);
            this.Edittxt_secondaryDriver_fname.MaxLength = 30;
            this.Edittxt_secondaryDriver_fname.Name = "Edittxt_secondaryDriver_fname";
            this.Edittxt_secondaryDriver_fname.Size = new System.Drawing.Size(206, 20);
            this.Edittxt_secondaryDriver_fname.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Conducteur(s) secondaires :";
            // 
            // EditLvSecondaryDrivers
            // 
            this.EditLvSecondaryDrivers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lname,
            this.fname,
            this.driver_licence});
            this.EditLvSecondaryDrivers.FullRowSelect = true;
            this.EditLvSecondaryDrivers.HideSelection = false;
            this.EditLvSecondaryDrivers.Location = new System.Drawing.Point(8, 239);
            this.EditLvSecondaryDrivers.MultiSelect = false;
            this.EditLvSecondaryDrivers.Name = "EditLvSecondaryDrivers";
            this.EditLvSecondaryDrivers.Size = new System.Drawing.Size(353, 105);
            this.EditLvSecondaryDrivers.TabIndex = 50;
            this.EditLvSecondaryDrivers.UseCompatibleStateImageBehavior = false;
            this.EditLvSecondaryDrivers.View = System.Windows.Forms.View.Details;
            this.EditLvSecondaryDrivers.SelectedIndexChanged += new System.EventHandler(this.EditLvSecondaryDrivers_SelectedIndexChanged);
            // 
            // lname
            // 
            this.lname.Text = "Nom";
            this.lname.Width = 100;
            // 
            // fname
            // 
            this.fname.Text = "Prénom";
            this.fname.Width = 100;
            // 
            // driver_licence
            // 
            this.driver_licence.Text = "No Permis Conduire";
            this.driver_licence.Width = 120;
            // 
            // editPhoneTextBox
            // 
            this.editPhoneTextBox.Enabled = false;
            this.editPhoneTextBox.Location = new System.Drawing.Point(157, 172);
            this.editPhoneTextBox.MaxLength = 10;
            this.editPhoneTextBox.Name = "editPhoneTextBox";
            this.editPhoneTextBox.Size = new System.Drawing.Size(206, 20);
            this.editPhoneTextBox.TabIndex = 49;
            // 
            // editClientCodeTextBox
            // 
            this.editClientCodeTextBox.Location = new System.Drawing.Point(157, 9);
            this.editClientCodeTextBox.MaxLength = 10;
            this.editClientCodeTextBox.Name = "editClientCodeTextBox";
            this.editClientCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.editClientCodeTextBox.TabIndex = 46;
            this.editClientCodeTextBox.TextChanged += new System.EventHandler(this.clientCodeTextBox_TextChanged);
            // 
            // editBankCardTextBox
            // 
            this.editBankCardTextBox.Enabled = false;
            this.editBankCardTextBox.Location = new System.Drawing.Point(157, 146);
            this.editBankCardTextBox.MaxLength = 19;
            this.editBankCardTextBox.Name = "editBankCardTextBox";
            this.editBankCardTextBox.Size = new System.Drawing.Size(206, 20);
            this.editBankCardTextBox.TabIndex = 40;
            // 
            // editDrivingLicenceTextBox
            // 
            this.editDrivingLicenceTextBox.Enabled = false;
            this.editDrivingLicenceTextBox.Location = new System.Drawing.Point(157, 120);
            this.editDrivingLicenceTextBox.MaxLength = 16;
            this.editDrivingLicenceTextBox.Name = "editDrivingLicenceTextBox";
            this.editDrivingLicenceTextBox.Size = new System.Drawing.Size(206, 20);
            this.editDrivingLicenceTextBox.TabIndex = 39;
            // 
            // editAddressTextBox
            // 
            this.editAddressTextBox.Enabled = false;
            this.editAddressTextBox.Location = new System.Drawing.Point(157, 94);
            this.editAddressTextBox.MaxLength = 70;
            this.editAddressTextBox.Name = "editAddressTextBox";
            this.editAddressTextBox.Size = new System.Drawing.Size(206, 20);
            this.editAddressTextBox.TabIndex = 38;
            // 
            // editFirstNameTextBox
            // 
            this.editFirstNameTextBox.Enabled = false;
            this.editFirstNameTextBox.Location = new System.Drawing.Point(157, 68);
            this.editFirstNameTextBox.MaxLength = 30;
            this.editFirstNameTextBox.Name = "editFirstNameTextBox";
            this.editFirstNameTextBox.Size = new System.Drawing.Size(206, 20);
            this.editFirstNameTextBox.TabIndex = 37;
            // 
            // editNameTextBox
            // 
            this.editNameTextBox.Enabled = false;
            this.editNameTextBox.Location = new System.Drawing.Point(157, 42);
            this.editNameTextBox.MaxLength = 30;
            this.editNameTextBox.Name = "editNameTextBox";
            this.editNameTextBox.Size = new System.Drawing.Size(206, 20);
            this.editNameTextBox.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 175);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "Téléphone : ";
            // 
            // editCheckCodeButton
            // 
            this.editCheckCodeButton.Location = new System.Drawing.Point(270, 6);
            this.editCheckCodeButton.Name = "editCheckCodeButton";
            this.editCheckCodeButton.Size = new System.Drawing.Size(93, 24);
            this.editCheckCodeButton.TabIndex = 47;
            this.editCheckCodeButton.Text = "Vérifier code";
            this.editCheckCodeButton.UseVisualStyleBackColor = true;
            this.editCheckCodeButton.Click += new System.EventHandler(this.checkCodeButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Code du client : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "No Carte Bancaire : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "No Permis Conduire :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Adresse :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Prénom :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Nom : ";
            // 
            // addPage
            // 
            this.addPage.Controls.Add(this.pnSecondaryDriver);
            this.addPage.Controls.Add(this.label21);
            this.addPage.Controls.Add(this.lvSecondaryDrivers);
            this.addPage.Controls.Add(this.phone);
            this.addPage.Controls.Add(this.cardNumber);
            this.addPage.Controls.Add(this.drivingLicence);
            this.addPage.Controls.Add(this.address);
            this.addPage.Controls.Add(this.firstName);
            this.addPage.Controls.Add(this.name);
            this.addPage.Controls.Add(this.label19);
            this.addPage.Controls.Add(this.label4);
            this.addPage.Controls.Add(this.label3);
            this.addPage.Controls.Add(this.label2);
            this.addPage.Controls.Add(this.label1);
            this.addPage.Controls.Add(this.label5);
            this.addPage.Location = new System.Drawing.Point(4, 22);
            this.addPage.Name = "addPage";
            this.addPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPage.Size = new System.Drawing.Size(370, 460);
            this.addPage.TabIndex = 0;
            this.addPage.Text = "Ajouter";
            this.addPage.UseVisualStyleBackColor = true;
            // 
            // pnSecondaryDriver
            // 
            this.pnSecondaryDriver.Controls.Add(this.DelbtnSecondaryDrivers);
            this.pnSecondaryDriver.Controls.Add(this.label20);
            this.pnSecondaryDriver.Controls.Add(this.ModifybtnSecondaryDrivers);
            this.pnSecondaryDriver.Controls.Add(this.lnameSecondaryDriver);
            this.pnSecondaryDriver.Controls.Add(this.label17);
            this.pnSecondaryDriver.Controls.Add(this.fnameSecondaryDriver);
            this.pnSecondaryDriver.Controls.Add(this.addbtnSecondaryDrivers);
            this.pnSecondaryDriver.Controls.Add(this.label16);
            this.pnSecondaryDriver.Controls.Add(this.driverLicenceSecondaryDriver);
            this.pnSecondaryDriver.Location = new System.Drawing.Point(0, 302);
            this.pnSecondaryDriver.Name = "pnSecondaryDriver";
            this.pnSecondaryDriver.Size = new System.Drawing.Size(370, 133);
            this.pnSecondaryDriver.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 61;
            this.label20.Text = "Nom : ";
            // 
            // ModifybtnSecondaryDrivers
            // 
            this.ModifybtnSecondaryDrivers.Enabled = false;
            this.ModifybtnSecondaryDrivers.Location = new System.Drawing.Point(208, 90);
            this.ModifybtnSecondaryDrivers.Name = "ModifybtnSecondaryDrivers";
            this.ModifybtnSecondaryDrivers.Size = new System.Drawing.Size(75, 23);
            this.ModifybtnSecondaryDrivers.TabIndex = 68;
            this.ModifybtnSecondaryDrivers.Text = "Modifier";
            this.ModifybtnSecondaryDrivers.UseVisualStyleBackColor = true;
            this.ModifybtnSecondaryDrivers.Click += new System.EventHandler(this.ModifybtnSecondaryDrivers_Click);
            // 
            // lnameSecondaryDriver
            // 
            this.lnameSecondaryDriver.Location = new System.Drawing.Point(157, 12);
            this.lnameSecondaryDriver.MaxLength = 30;
            this.lnameSecondaryDriver.Name = "lnameSecondaryDriver";
            this.lnameSecondaryDriver.Size = new System.Drawing.Size(206, 20);
            this.lnameSecondaryDriver.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 65;
            this.label17.Text = "Prénom :";
            // 
            // fnameSecondaryDriver
            // 
            this.fnameSecondaryDriver.Location = new System.Drawing.Point(157, 38);
            this.fnameSecondaryDriver.MaxLength = 30;
            this.fnameSecondaryDriver.Name = "fnameSecondaryDriver";
            this.fnameSecondaryDriver.Size = new System.Drawing.Size(206, 20);
            this.fnameSecondaryDriver.TabIndex = 63;
            // 
            // addbtnSecondaryDrivers
            // 
            this.addbtnSecondaryDrivers.Location = new System.Drawing.Point(128, 90);
            this.addbtnSecondaryDrivers.Name = "addbtnSecondaryDrivers";
            this.addbtnSecondaryDrivers.Size = new System.Drawing.Size(75, 23);
            this.addbtnSecondaryDrivers.TabIndex = 67;
            this.addbtnSecondaryDrivers.Text = "Ajouter";
            this.addbtnSecondaryDrivers.UseVisualStyleBackColor = true;
            this.addbtnSecondaryDrivers.Click += new System.EventHandler(this.addbtnSecondaryDrivers_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 66;
            this.label16.Text = "No Permis Conduire:";
            // 
            // driverLicenceSecondaryDriver
            // 
            this.driverLicenceSecondaryDriver.Location = new System.Drawing.Point(157, 64);
            this.driverLicenceSecondaryDriver.MaxLength = 30;
            this.driverLicenceSecondaryDriver.Name = "driverLicenceSecondaryDriver";
            this.driverLicenceSecondaryDriver.Size = new System.Drawing.Size(206, 20);
            this.driverLicenceSecondaryDriver.TabIndex = 64;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 175);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 13);
            this.label21.TabIndex = 60;
            this.label21.Text = "Conducteur(s) secondaires :";
            // 
            // lvSecondaryDrivers
            // 
            this.lvSecondaryDrivers.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvSecondaryDrivers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvLname,
            this.lvFname,
            this.lvLicence});
            this.lvSecondaryDrivers.FullRowSelect = true;
            this.lvSecondaryDrivers.HideSelection = false;
            this.lvSecondaryDrivers.Location = new System.Drawing.Point(7, 191);
            this.lvSecondaryDrivers.MultiSelect = false;
            this.lvSecondaryDrivers.Name = "lvSecondaryDrivers";
            this.lvSecondaryDrivers.Size = new System.Drawing.Size(353, 105);
            this.lvSecondaryDrivers.TabIndex = 59;
            this.lvSecondaryDrivers.UseCompatibleStateImageBehavior = false;
            this.lvSecondaryDrivers.View = System.Windows.Forms.View.Details;
            this.lvSecondaryDrivers.SelectedIndexChanged += new System.EventHandler(this.lvSecondaryDrivers_SelectedIndexChanged);
            // 
            // lvLname
            // 
            this.lvLname.Tag = "";
            this.lvLname.Text = "Nom";
            this.lvLname.Width = 100;
            // 
            // lvFname
            // 
            this.lvFname.Text = "Prénom";
            this.lvFname.Width = 100;
            // 
            // lvLicence
            // 
            this.lvLicence.Text = "No Permis Conduire";
            this.lvLicence.Width = 120;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(157, 139);
            this.phone.MaxLength = 15;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(206, 20);
            this.phone.TabIndex = 51;
            // 
            // cardNumber
            // 
            this.cardNumber.Location = new System.Drawing.Point(158, 113);
            this.cardNumber.MaxLength = 20;
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(206, 20);
            this.cardNumber.TabIndex = 30;
            // 
            // drivingLicence
            // 
            this.drivingLicence.Location = new System.Drawing.Point(158, 87);
            this.drivingLicence.MaxLength = 30;
            this.drivingLicence.Name = "drivingLicence";
            this.drivingLicence.Size = new System.Drawing.Size(206, 20);
            this.drivingLicence.TabIndex = 29;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(158, 61);
            this.address.MaxLength = 70;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(206, 20);
            this.address.TabIndex = 28;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(158, 35);
            this.firstName.MaxLength = 30;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(206, 20);
            this.firstName.TabIndex = 27;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(158, 9);
            this.name.MaxLength = 30;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(206, 20);
            this.name.TabIndex = 26;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Téléphone : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "No Carte Bancaire : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "No Permis Conduire :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Adresse :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Prenom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nom : ";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.addPage);
            this.tabControl.Controls.Add(this.editPage);
            this.tabControl.Location = new System.Drawing.Point(1, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(378, 486);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // DelbtnSecondaryDrivers
            // 
            this.DelbtnSecondaryDrivers.Location = new System.Drawing.Point(289, 90);
            this.DelbtnSecondaryDrivers.Name = "DelbtnSecondaryDrivers";
            this.DelbtnSecondaryDrivers.Size = new System.Drawing.Size(75, 23);
            this.DelbtnSecondaryDrivers.TabIndex = 70;
            this.DelbtnSecondaryDrivers.Text = "Supprimer";
            this.DelbtnSecondaryDrivers.UseVisualStyleBackColor = true;
            this.DelbtnSecondaryDrivers.Click += new System.EventHandler(this.DelbtnSecondaryDrivers_Click);
            // 
            // EditbtnDeleteSecondaryDriver
            // 
            this.EditbtnDeleteSecondaryDriver.Location = new System.Drawing.Point(289, 81);
            this.EditbtnDeleteSecondaryDriver.Name = "EditbtnDeleteSecondaryDriver";
            this.EditbtnDeleteSecondaryDriver.Size = new System.Drawing.Size(75, 23);
            this.EditbtnDeleteSecondaryDriver.TabIndex = 61;
            this.EditbtnDeleteSecondaryDriver.Text = "Supprimer";
            this.EditbtnDeleteSecondaryDriver.UseVisualStyleBackColor = true;
            this.EditbtnDeleteSecondaryDriver.Click += new System.EventHandler(this.EditbtnDeleteSecondaryDriver_Click);
            // 
            // ClientManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 541);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 580);
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "ClientManagementForm";
            this.Text = "Gestion des clients";
            this.Load += new System.EventHandler(this.ClientManagementForm_Load);
            this.editPage.ResumeLayout(false);
            this.editPage.PerformLayout();
            this.pnEditSecondayDriver2.ResumeLayout(false);
            this.pnEditSecondayDriver2.PerformLayout();
            this.addPage.ResumeLayout(false);
            this.addPage.PerformLayout();
            this.pnSecondaryDriver.ResumeLayout(false);
            this.pnSecondaryDriver.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TabPage editPage;
        private System.Windows.Forms.TextBox editPhoneTextBox;
        private System.Windows.Forms.TextBox editClientCodeTextBox;
        private System.Windows.Forms.TextBox editBankCardTextBox;
        private System.Windows.Forms.TextBox editDrivingLicenceTextBox;
        private System.Windows.Forms.TextBox editAddressTextBox;
        private System.Windows.Forms.TextBox editFirstNameTextBox;
        private System.Windows.Forms.TextBox editNameTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button editCheckCodeButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage addPage;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox cardNumber;
        private System.Windows.Forms.TextBox drivingLicence;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ListView EditLvSecondaryDrivers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader lname;
        private System.Windows.Forms.ColumnHeader fname;
        private System.Windows.Forms.ColumnHeader driver_licence;
        private System.Windows.Forms.TextBox Edittxt_secondaryDriver_drivingLicence;
        private System.Windows.Forms.TextBox Edittxt_secondaryDriver_fname;
        private System.Windows.Forms.TextBox Edittxt_secondaryDriver_lname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button EditbtnSaveSecondaryDriver;
        private System.Windows.Forms.Button addbtnSecondaryDrivers;
        private System.Windows.Forms.TextBox driverLicenceSecondaryDriver;
        private System.Windows.Forms.TextBox fnameSecondaryDriver;
        private System.Windows.Forms.TextBox lnameSecondaryDriver;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListView lvSecondaryDrivers;
        private System.Windows.Forms.ColumnHeader lvLname;
        private System.Windows.Forms.Button ModifybtnSecondaryDrivers;
        private System.Windows.Forms.Panel pnEditSecondayDriver2;
        private System.Windows.Forms.ColumnHeader lvFname;
        private System.Windows.Forms.ColumnHeader lvLicence;
        private System.Windows.Forms.Panel pnSecondaryDriver;
        private System.Windows.Forms.Button EditbtnAddSecondaryDriver;
        private System.Windows.Forms.Button DelbtnSecondaryDrivers;
        private System.Windows.Forms.Button EditbtnDeleteSecondaryDriver;
    }
}