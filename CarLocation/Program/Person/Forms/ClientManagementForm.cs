using CarLocation.Classes;
using CarLocation.Utilities.ControllerForm;
using System;
using System.Windows.Forms;


namespace CarLocation
{
    public partial class ClientManagementForm : Form
    {
        Client _currentClient = new Client();
        ClientManagementController clientManagementController = new ClientManagementController();

        public ClientManagementForm()
        {
            InitializeComponent();

            ModifybtnSecondaryDrivers.Enabled = false;
            EditbtnSaveSecondaryDriver.Enabled = false;
            DelbtnSecondaryDrivers.Enabled = false;
            EditbtnDeleteSecondaryDriver.Enabled = false;
        }

        //Enregistre le client
        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool error;

            if (tabControl.SelectedTab == editPage || tabControl.SelectedTab == addPage)
            {
                error = FormUtilities.IsAnyClientControlEmpty(tabControl.SelectedTab.Controls);
                if (!error)
                {
                    if (tabControl.SelectedTab == editPage)
                    {
                       if (clientManagementController.UpdateClient(_currentClient, editFirstNameTextBox.Text, editNameTextBox.Text, editPhoneTextBox.Text, editAddressTextBox.Text, editBankCardTextBox.Text, 
                                                                 editDrivingLicenceTextBox.Text, EditLvSecondaryDrivers))
                        {
                            DialogResult = DialogResult.OK;
                        }
                        
                    }
                    else
                    {
                        if (clientManagementController.InsertClient(_currentClient, firstName.Text, name.Text, phone.Text, address.Text, cardNumber.Text,
                                                                drivingLicence.Text, lvSecondaryDrivers))
                        {
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                else
                    FormUtilities.NoFieldCanBeEmpty();
            }   
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormUtilities.ResetAllControls(addPage.Controls);
            FormUtilities.ResetAllControls(editPage.Controls);
            _currentClient = new Client();
            SaveButton.Text = "Enregistrer";
        }

        //Vérifie le code du client
        private void checkCodeButton_Click(object sender, EventArgs e)
        {
            Client hasClient = clientManagementController.CodeVerification(editClientCodeTextBox.Text);

            if (hasClient != null)
            {
                _currentClient = hasClient;
                RefreshLV(EditLvSecondaryDrivers, _currentClient);
                editAddressTextBox.Text = _currentClient.address;
                editFirstNameTextBox.Text = _currentClient.fname;
                editNameTextBox.Text = _currentClient.lname;
                editDrivingLicenceTextBox.Text = _currentClient.driver_licence.ToString();
                editBankCardTextBox.Text = _currentClient.card_number.ToString();
                editPhoneTextBox.Text = _currentClient.phone;

                FormUtilities.SetTextBoxStateEnabled(editPage.Controls);
                EditbtnAddSecondaryDriver.Enabled = true;
                EditbtnSaveSecondaryDriver.Enabled = false;
                EditbtnDeleteSecondaryDriver.Enabled = false;
                Edittxt_secondaryDriver_fname.Enabled = true;
                Edittxt_secondaryDriver_drivingLicence.Enabled = true;
                Edittxt_secondaryDriver_lname.Enabled = true;
            }
        }

        //Actualise les items d'une ListView
        private void RefreshLV(ListView myListview, Client _currentClient)
        {
            myListview.Items.Clear();

            for (int i = 0; i < _currentClient.driversList.Count; i++)
            {
                ListViewItem tmpItem = new ListViewItem();
                tmpItem.SubItems.Clear();
                tmpItem.Text = _currentClient.driversList[i].lname.ToString();
                tmpItem.SubItems.Add(_currentClient.driversList[i].fname.ToString());
                tmpItem.SubItems.Add(_currentClient.driversList[i].driver_licence.ToString());
                myListview.Items.Add(tmpItem);
            }
        }

        private void clientCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            FormUtilities.SetTextBoxStateDisabled(editPage.Controls);
            EditbtnAddSecondaryDriver.Enabled = false;
        }

        private void ClientManagementForm_Load(object sender, EventArgs e)
        {
            editNameTextBox.KeyPress += ValidateCaractersOnlyKeyPress;
            editFirstNameTextBox.KeyPress += ValidateCaractersOnlyKeyPress;
            name.KeyPress += ValidateCaractersOnlyKeyPress;
            firstName.KeyPress += ValidateCaractersOnlyKeyPress;
            lnameSecondaryDriver.KeyPress += ValidateCaractersOnlyKeyPress;
            fnameSecondaryDriver.KeyPress += ValidateCaractersOnlyKeyPress;
            Edittxt_secondaryDriver_lname.KeyPress += ValidateCaractersOnlyKeyPress;
            Edittxt_secondaryDriver_fname.KeyPress += ValidateCaractersOnlyKeyPress;

            phone.KeyPress += ValidateNumberOnlyKeyPress;
            cardNumber.KeyPress += ValidateNumberOnlyKeyPress;
            editPhoneTextBox.KeyPress += ValidateNumberOnlyKeyPress;
            editBankCardTextBox.KeyPress += ValidateNumberOnlyKeyPress;
        }

        //Valide les données entrées sur les champs du formulaire
        private void ValidateCaractersOnlyKeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (char.IsDigit(chr))
                e.Handled = true;
        }

        //Valide les données entrées sur les champs du formulaire
        private void ValidateNumberOnlyKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        //Ferme le formulaire
        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        //Gère les boutons/champs si la liste a un item de selectionné ou non 
        private void EditLvSecondaryDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditLvSecondaryDrivers.SelectedItems.Count > 0)
            {
                Edittxt_secondaryDriver_lname.Enabled = true;
                Edittxt_secondaryDriver_fname.Enabled = true;
                Edittxt_secondaryDriver_drivingLicence.Enabled = true;

                EditbtnAddSecondaryDriver.Enabled = false;
                EditbtnSaveSecondaryDriver.Enabled = true;
                EditbtnDeleteSecondaryDriver.Enabled = true;


                Edittxt_secondaryDriver_lname.Text = EditLvSecondaryDrivers.SelectedItems[0].SubItems[0].Text;
                Edittxt_secondaryDriver_fname.Text = EditLvSecondaryDrivers.SelectedItems[0].SubItems[1].Text;
                Edittxt_secondaryDriver_drivingLicence.Text = EditLvSecondaryDrivers.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                EditbtnAddSecondaryDriver.Enabled = true;
                EditbtnSaveSecondaryDriver.Enabled = false;
                EditbtnDeleteSecondaryDriver.Enabled = false;
                Edittxt_secondaryDriver_lname.Text = "";
                Edittxt_secondaryDriver_fname.Text = "";
                Edittxt_secondaryDriver_drivingLicence.Text = "";
            }
        }

        //Permet de modifier les informations des conducteurs secondaires
        private void EditbtnSaveSecondaryDriver_Click(object sender, EventArgs e)
        {
            bool error;
            if (EditLvSecondaryDrivers.SelectedItems.Count > 0)
            {
                if (tabControl.SelectedTab == editPage)
                    error = FormUtilities.IsAnyClientControlEmpty(pnEditSecondayDriver2.Controls);
                else
                    error = FormUtilities.IsAnyClientControlEmpty(pnSecondaryDriver.Controls);

                if (!error)
                {
                    if (clientManagementController.VerifyModifySecondaryDriver(Edittxt_secondaryDriver_fname.Text.Trim(), Edittxt_secondaryDriver_lname.Text.Trim(), Edittxt_secondaryDriver_drivingLicence.Text.Trim(), EditLvSecondaryDrivers))
                    {
                        EditLvSecondaryDrivers.SelectedItems[0].Text = Edittxt_secondaryDriver_lname.Text.Trim();
                        EditLvSecondaryDrivers.SelectedItems[0].SubItems[1].Text = Edittxt_secondaryDriver_fname.Text.Trim();
                        EditLvSecondaryDrivers.SelectedItems[0].SubItems[2].Text = Edittxt_secondaryDriver_drivingLicence.Text.Trim();
                        EditLvSecondaryDrivers.SelectedItems[0].Selected = false;
                        EditbtnSaveSecondaryDriver.Enabled = false;
                        EditbtnDeleteSecondaryDriver.Enabled = false;
                        Edittxt_secondaryDriver_lname.Text = "";
                        Edittxt_secondaryDriver_fname.Text = "";
                        Edittxt_secondaryDriver_drivingLicence.Text = "";
                    }
                }
            }
        }

        //Gère les boutons/champs si la liste a un item de selectionné ou non 
        private void lvSecondaryDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSecondaryDrivers.SelectedItems.Count > 0)
            {
                ModifybtnSecondaryDrivers.Enabled = true;
                DelbtnSecondaryDrivers.Enabled = true;
                addbtnSecondaryDrivers.Enabled = false;
                lnameSecondaryDriver.Text = lvSecondaryDrivers.SelectedItems[0].SubItems[0].Text;
                fnameSecondaryDriver.Text = lvSecondaryDrivers.SelectedItems[0].SubItems[1].Text;
                driverLicenceSecondaryDriver.Text = lvSecondaryDrivers.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                addbtnSecondaryDrivers.Enabled = true;
                ModifybtnSecondaryDrivers.Enabled = false;
                DelbtnSecondaryDrivers.Enabled = false;
                lnameSecondaryDriver.Text = "";
                fnameSecondaryDriver.Text = "";
                driverLicenceSecondaryDriver.Text = "";
            }
        }

        //Permet de modifier les informations des conducteurs secondaires dans la ListView
        private void ModifybtnSecondaryDrivers_Click(object sender, EventArgs e)
        {
            bool error;
            if (lvSecondaryDrivers.SelectedItems.Count > 0)
            {
                if (tabControl.SelectedTab == editPage)
                    error = FormUtilities.IsAnyClientControlEmpty(pnEditSecondayDriver2.Controls);
                else
                    error = FormUtilities.IsAnyClientControlEmpty(pnSecondaryDriver.Controls);

                if (!error)
                {
                    if (clientManagementController.VerifyModifySecondaryDriver(fnameSecondaryDriver.Text.Trim(), lnameSecondaryDriver.Text.Trim(), driverLicenceSecondaryDriver.Text.Trim(), lvSecondaryDrivers))
                    {
                        lvSecondaryDrivers.SelectedItems[0].Text = lnameSecondaryDriver.Text.Trim();
                        lvSecondaryDrivers.SelectedItems[0].SubItems[1].Text = fnameSecondaryDriver.Text.Trim();
                        lvSecondaryDrivers.SelectedItems[0].SubItems[2].Text = driverLicenceSecondaryDriver.Text.Trim();
                        lvSecondaryDrivers.SelectedItems[0].Selected = false;
                        ModifybtnSecondaryDrivers.Enabled = false;
                        DelbtnSecondaryDrivers.Enabled = false;
                        lnameSecondaryDriver.Text = "";
                        fnameSecondaryDriver.Text = "";
                        driverLicenceSecondaryDriver.Text = "";
                    }  
                }
            }
        }

        //Permet d'ajouter des conducteurs secondaires dans la ListView
        private void addbtnSecondaryDrivers_Click(object sender, EventArgs e)
        {
            bool error = FormUtilities.IsAnyClientControlEmpty(pnSecondaryDriver.Controls);
            if (!error)
            {
                if (!clientManagementController.VerifyAddSecondaryDriver(fnameSecondaryDriver.Text.Trim(), lnameSecondaryDriver.Text.Trim(), driverLicenceSecondaryDriver.Text.Trim(), lvSecondaryDrivers))
                    UpdateDataListView(lvSecondaryDrivers, driverLicenceSecondaryDriver, fnameSecondaryDriver, lnameSecondaryDriver);
            }
            else
                FormUtilities.NoFieldCanBeEmpty();
        }

        //Permet d'ajouter des conducteurs secondaires dans la ListView
        private void EditbtnAddSecondaryDriver_Click(object sender, EventArgs e)
        {
            bool error = FormUtilities.IsAnyClientControlEmpty(EditLvSecondaryDrivers.Controls);

            if (!error)
            {
                if (!clientManagementController.VerifyAddSecondaryDriver(Edittxt_secondaryDriver_fname.Text.Trim(), Edittxt_secondaryDriver_lname.Text.Trim(), Edittxt_secondaryDriver_drivingLicence.Text.Trim(), EditLvSecondaryDrivers))
                    UpdateDataListView(EditLvSecondaryDrivers, Edittxt_secondaryDriver_drivingLicence, Edittxt_secondaryDriver_fname, Edittxt_secondaryDriver_lname);
            }
            else
                FormUtilities.NoFieldCanBeEmpty();
        }

        //Permet d'ajouter item dans la ListView
        private void UpdateDataListView(ListView listview, TextBox txtDriverLicence, TextBox txtFname, TextBox txtLname)
        {
            ListViewItem myitem = new ListViewItem();

            myitem.Text = txtLname.Text.Trim();
            myitem.SubItems.Add(txtFname.Text.Trim());
            myitem.SubItems.Add(txtDriverLicence.Text.Trim());
            myitem.Tag = this;

            listview.Items.Add(myitem);

            txtFname.Clear();
            txtLname.Clear();
            txtDriverLicence.Text.Trim();

            EditbtnSaveSecondaryDriver.Enabled = false;
            EditbtnDeleteSecondaryDriver.Enabled = false;

            txtLname.Text = "";
            txtFname.Text = "";
            txtDriverLicence.Text = "";
        }

        //Permet de supprimer des conducteurs secondaires de la ListView
        private void EditbtnDeleteSecondaryDriver_Click(object sender, EventArgs e)
        {
            if (EditLvSecondaryDrivers.SelectedItems.Count > 0)
            {
                //Supprime l'item séléctionné de la ListView
                EditLvSecondaryDrivers.SelectedItems[0].Remove();
                EditbtnSaveSecondaryDriver.Enabled = false;
                EditbtnDeleteSecondaryDriver.Enabled = false;
                Edittxt_secondaryDriver_lname.Text = "";
                Edittxt_secondaryDriver_fname.Text = "";
                Edittxt_secondaryDriver_drivingLicence.Text = "";
            }
        }

        //Permet de supprimer des conducteurs secondaires de la ListView
        private void DelbtnSecondaryDrivers_Click(object sender, EventArgs e)
        {
            if (lvSecondaryDrivers.SelectedItems.Count > 0)
            {
                lvSecondaryDrivers.SelectedItems[0].Remove();
                ModifybtnSecondaryDrivers.Enabled = false;
                DelbtnSecondaryDrivers.Enabled = false;
                lnameSecondaryDriver.Text = "";
                fnameSecondaryDriver.Text = "";
                driverLicenceSecondaryDriver.Text = "";
            }
        }
    }
}
