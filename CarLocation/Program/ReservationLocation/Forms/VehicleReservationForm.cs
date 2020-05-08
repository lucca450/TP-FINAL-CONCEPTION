using CarLocation.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarLocation.Utilities.ControllerForm;
using CarLocation.Program.ReservationLocation.Controller;

namespace CarLocation
{
    public partial class VehiculeReservationForm : Form
    {
        private Client _currentClient;
        public DataManager databaseManager;

        private List<Vehicle> listAvailableVehicles = new List<Vehicle>();
        private List<Vehicle> listAvailableVehiclesTypes = new List<Vehicle>();
        private List<Vehicle> listAvailableVehiclesBrands = new List<Vehicle>();
        private List<Vehicle> listAvailableVehiclesModels = new List<Vehicle>();
        private List<Vehicle> listAvailableVehiclesEditions = new List<Vehicle>();
        private List<Vehicle> listAvailableVehiclesYears = new List<Vehicle>();

        VehicleController vehicleController = new VehicleController();
        ClientManagementController clientManagementController = new ClientManagementController();
        ReservationLocationController reservationLocationController = new ReservationLocationController();

        bool loading = false;

        public VehiculeReservationForm()
        {
            databaseManager = DataManager.Instance;
            loading = false;
            InitializeComponent();
            beginning.MinDate = DateTime.Now.AddDays(1);
            end.MinDate = DateTime.Now.AddDays(1);
            loading = true;
        }

        public DialogResult Display()
        {
            Show();
            return DialogResult.Cancel;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!FormUtilities.IsAnyControlEmpty(this.Controls))
            {
                if (FormUtilities.DateVerification(beginning.Value, end.Value))
                {
                    if (reservationLocationController.SaveReservation(_currentClient, listAvailableVehiclesYears, beginning.Value, end.Value))
                        DialogResult = DialogResult.OK;
                }
                else
                    FormUtilities.SomethingWentWrongMessageBox("Erreur", "La date de début doit être avant la date de fin");
            }
            else
                FormUtilities.SomethingWentWrongMessageBox("Erreur", "Tous les champs doivent être remplis");
        }

        private void checkCodeButton_Click(object sender, EventArgs e)
        {
            _currentClient = clientManagementController.CodeVerification(clientCode.Text);

            if (_currentClient != null)
            {
                FormUtilities.SetTextBoxStateEnabled(Controls);
                ResetVehiclesControls();

                listAvailableVehicles = reservationLocationController.GetAvailableVehicles(beginning.Value, end.Value);
                List<string> types = vehicleController.GetTypesFromVehicles(listAvailableVehicles);
                FormUtilities.FillComboBox(typeComboBox, types);
            }
        }

        private void ClientCode_TextChanged(object sender, EventArgs e)
        {
            FormUtilities.SetTextBoxStateDisabled(Controls);
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            brandComboBox.Items.Clear();
            modelComboBox.Items.Clear();
            yearComboBox.Items.Clear();
            editionComboBox.Items.Clear();

            brandComboBox.Text = "";
            modelComboBox.Text = "";
            yearComboBox.Text = "";
            editionComboBox.Text = "";

            listAvailableVehiclesTypes = vehicleController.GetAvailableVehiclesBrands(listAvailableVehicles, typeComboBox.SelectedItem.ToString());
            List<string> brands = vehicleController.GetBrandsFromVehicles(listAvailableVehiclesTypes);

            FormUtilities.FillComboBox(brandComboBox, brands);
        }

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelComboBox.Items.Clear();
            yearComboBox.Items.Clear();
            editionComboBox.Items.Clear();

            modelComboBox.Text = "";
            yearComboBox.Text = "";
            editionComboBox.Text = "";

            listAvailableVehiclesBrands = vehicleController.GetAvailableVehiclesModels(listAvailableVehiclesTypes, brandComboBox.SelectedItem.ToString());
            List<string> models = vehicleController.GetModelsFromVehicles(listAvailableVehiclesBrands);

            FormUtilities.FillComboBox(modelComboBox, models);
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearComboBox.Items.Clear();
            editionComboBox.Items.Clear();

            yearComboBox.Text = "";
            editionComboBox.Text = "";

            listAvailableVehiclesModels = vehicleController.GetAvailableVehiclesEditions(listAvailableVehiclesBrands, modelComboBox.SelectedItem.ToString());
            List<string> editions = vehicleController.GetEditionsFromVehicles(listAvailableVehiclesModels);

            FormUtilities.FillComboBox(editionComboBox, editions);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
            {
                ResetVehiclesControls();

                listAvailableVehicles = reservationLocationController.GetAvailableVehicles(beginning.Value, end.Value);
                List<string> types = vehicleController.GetTypesFromVehicles(listAvailableVehicles);
                FormUtilities.FillComboBox(typeComboBox, types);
            }
        }

        private void editionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearComboBox.Items.Clear();
            yearComboBox.Text = "";

            listAvailableVehiclesEditions = vehicleController.GetAvailableVehiclesYears(listAvailableVehiclesModels, editionComboBox.SelectedItem.ToString());
            List<string> years = vehicleController.GetYearsFromVehicles(listAvailableVehiclesEditions);

            FormUtilities.FillComboBox(yearComboBox, years);
        }

        private void beginning_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
            {
                ResetVehiclesControls();

                listAvailableVehicles = reservationLocationController.GetAvailableVehicles(beginning.Value, end.Value);
                List<string> types = vehicleController.GetTypesFromVehicles(listAvailableVehicles);
                FormUtilities.FillComboBox(typeComboBox, types);
            }
        }

        private void ResetVehiclesControls()
        {
            typeComboBox.Items.Clear();
            brandComboBox.Items.Clear();
            modelComboBox.Items.Clear();
            yearComboBox.Items.Clear();
            editionComboBox.Items.Clear();

            typeComboBox.Text = "";
            brandComboBox.Text = "";
            modelComboBox.Text = "";
            yearComboBox.Text = "";
            editionComboBox.Text = "";
        }
    }
}