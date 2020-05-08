using CarLocation.Classes;
using System.Windows.Forms;


namespace CarLocation.Utilities.ControllerForm
{
    public class ClientManagementController
    {
        public DataManager databaseManager;
        public ClientManagementController()
        {
            databaseManager = DataManager.Instance;
        }

        //Vérifie le code du client et affiche un message de confirmation/erreur
        public Client CodeVerification(string clientCode)
        {
            foreach (Client client in databaseManager.GetClientsList())
            {
                if (client.CodeVerification(clientCode))
                {
                    FormUtilities.SuccessMessageBox("Le client a bien été vérifié !");
                    return client;
                }
            }
            FormUtilities.NoItemFound("Impossible de trouver le client. Le code du client n'est pas valide.");
            return null;
        }

        //Modifie les informations d'un client et affiche un message de confirmation
        private void UpdateClient(Client _currentClient, string lname, string fname, string phone, string address, string card_number, string driver_licence)
        {
            if (_currentClient != null)
            {
                _currentClient.lname = lname.Trim();
                _currentClient.fname = fname.Trim();
                _currentClient.phone = phone.Trim();
                _currentClient.address = address.Trim();
                _currentClient.card_number = card_number.Trim();
                _currentClient.driver_licence = driver_licence.Trim();

                FormUtilities.SuccessMessageBox("Les informations du client ont bien été modifiées !");
            }
        }

        //Ajoute le client et affiche un message de confirmation/erreur
        private bool InsertIntoClient(Client _currentClient, string lname, string fname, string phone, string address, string card_number, string driver_licence)
        {
            _currentClient.lname = lname.Trim();
            _currentClient.fname = fname.Trim();
            _currentClient.phone = phone.Trim();
            _currentClient.address = address.Trim();
            _currentClient.inscription_date = System.DateTime.Now;

            if (_currentClient != null)
            {
                _currentClient.card_number = card_number.Trim();
                _currentClient.driver_licence = driver_licence.Trim();
                _currentClient.code = databaseManager.GenerateClientCode(_currentClient);

                if (_currentClient.code != null)
                {
                    databaseManager.AddClientsList(_currentClient);
                    FormUtilities.SuccessMessageBox("Le client a bien été enregistré. Son code est : " + _currentClient.code);
                    return true;
                }
                else
                {
                    FormUtilities.SomethingWentWrongMessageBox("Erreur", "Erreur lors de la création du client.");
                    return false;
                }
            }
            else
            {
                FormUtilities.SomethingWentWrongMessageBox("Erreur", "Erreur lors de la création du client.");
                return false;
            }
        }

        //Ajoute les conducteurs secondaires qui sont dans la ListView de la Form dans la liste de conducteurs secondaires de l'objet client
        private void UpdateSecondaryDriver(ListView secondaryDrivers, Client _currentclient)
        {
            _currentclient.driversList.Clear();
            SecondaryDriver secondaryDriver = null;
            foreach (ListViewItem itemRow in secondaryDrivers.Items)
            {
                string[] myArray = new string[3];
                for (int i = 0; i < itemRow.SubItems.Count; i++)
                {
                    string text = itemRow.SubItems[i].Text;
                    myArray[i] = itemRow.SubItems[i].Text;
                    if (i == 2 && !SecondaryDriverExist(_currentclient, itemRow.SubItems[i].Text))
                    {
                        secondaryDriver = new SecondaryDriver(myArray[2], System.DateTime.Now, myArray[0], myArray[1]);
                        _currentclient.driversList.Add(secondaryDriver);
                    }
                }
            }
        }

        //Vérification sur les conducteur secondaires d'un client
        private bool SecondaryDriverExist(Client _currentclient, string driverLicence)
        {
            foreach (SecondaryDriver client in _currentclient.driversList)
            {
                if (client.LicenceVerification(driverLicence))
                {
                    return true;
                }
            }
            return false;
        }

        //Vérifie si le client existe déjà dans la base de données
        private bool VerifyDriverExist(string driverLicence, string type, Client _currentClient)

        {
            if(type == "Modify")
            {
                if (_currentClient.LicenceVerification(driverLicence))
                {
                    return false;
                 }
            }
            foreach (Client client in databaseManager.GetClientsList())
            {
                if (client.LicenceVerification(driverLicence))
                {
                    FormUtilities.SomethingWentWrongMessageBox("Erreur", "Erreur - Le numéro de permis du conducteur appartient déja à un autre client.");
                    return true;
                }
            }
            return false;
        }

        //Vérifie si le conducteur secondaire existe déjà
        private bool VerifySecondaryDriverExist(string driverLicence, string lname, string fname, string mode)
        {
            int driverFound = 0;
            
            if(mode == "add")
            {
                driverFound = 1;
            }
            foreach (Client client in databaseManager.GetClientsList())
            {
                foreach (SecondaryDriver driver in client.driversList)
                {
                    if (driver.DriverExists(driverLicence, fname, lname))
                    {
                        return false;
                    }

                    else if (driver.LicenceVerification (driverLicence))
                    {
                        ++driverFound;
                        if(driverFound == 2)
                        {
                            SecondaryDriver tmpDriver = new SecondaryDriver();
                            tmpDriver.code = "-1";
                            FormUtilities.SomethingWentWrongMessageBox("Erreur", "Erreur - Le numéro de permis du conducteur secondaire appartient déja à un autre client. Veuillez vérifier que vous avez bien saisi les informations du client.");
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //Vérifie si le conducteur secondaire existe déjà dans la ListView
        private bool VerifyDriverExistIntoList(string driverLicence, ListView listDriver, string message)
        {
            for (int i = 0; i < listDriver.Items.Count; i++)
            {
                if (listDriver.Items[i].SubItems[2].Text.Equals(driverLicence))
                {
                    FormUtilities.SomethingWentWrongMessageBox("Erreur", message);
                    return true;
                }
            }
            return false;
        }

        // Modifie le informations liées au client.
        public bool UpdateClient(Client _currentClient, string firstName, string lastName, string phone, string address, string bankCard,string drivingLicence, ListView lvSecondaryDrivers)
        {
            if (!VerifyDriverExist(drivingLicence, "Modify", _currentClient))
            {
                if (!VerifyDriverExistIntoList(drivingLicence, lvSecondaryDrivers, "Le numéro de licence du client ne peut-être le même qu'un de vos conducteurs secondaires."))
                {
                    UpdateSecondaryDriver(lvSecondaryDrivers, _currentClient);

                    UpdateClient(_currentClient, lastName, firstName, phone, address, bankCard, drivingLicence);

                    return true;
                }
            }
            return false;
        }

        // Ajoute le client 
        public bool InsertClient(Client _currentClient, string firstName, string lastName, string phone, string address, string bankCard, string drivingLicence, ListView lvSecondaryDrivers)
        {
            if (!VerifyDriverExist(drivingLicence, "Add", _currentClient))
            {
                if (!VerifyDriverExistIntoList(drivingLicence, lvSecondaryDrivers, "Le numéro de licence du client ne peut-être le même qu'un de vos conducteurs secondaires."))
                {
                    UpdateSecondaryDriver(lvSecondaryDrivers, _currentClient);
                    
                    if(InsertIntoClient(_currentClient, lastName, firstName, phone, address, bankCard, drivingLicence))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Vérification si on peut modifier le driver secondaire
        public bool VerifyModifySecondaryDriver(string firstName, string lastName, string drivingLicence, ListView lvSecondaryDrivers)
        {
            bool driverExist;

            if (drivingLicence != lvSecondaryDrivers.SelectedItems[0].SubItems[2].Text)
                driverExist = VerifyDriverExistIntoList(drivingLicence, lvSecondaryDrivers, "Ce client a déja été ajouté à votre liste de conducteur secondaire.");
            else
                driverExist = false;

            if (!driverExist)
                driverExist = VerifySecondaryDriverExist(drivingLicence, lastName, firstName,"modify");

            return driverExist;
        }

        //Vérification si on peut ajouter le driver secondaire
        public bool VerifyAddSecondaryDriver(string firstName, string lastName, string drivingLicence, ListView lvSecondaryDrivers)
        { 
            bool driverExist = VerifyDriverExistIntoList(drivingLicence, lvSecondaryDrivers, "Ce client a déja été ajouté à votre liste de conducteur secondaire.");

            if (!driverExist)
                driverExist = VerifySecondaryDriverExist(drivingLicence, lastName, firstName,"add");

            return driverExist;
        }
    }
}

