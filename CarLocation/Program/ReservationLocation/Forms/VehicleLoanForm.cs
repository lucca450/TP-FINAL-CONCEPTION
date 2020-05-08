using CarLocation.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CarLocation.Utilities.ControllerForm;
using CarLocation.Program.ReservationLocation.Controller;

namespace CarLocation
{
    public partial class VehiculeLoanForm : Form
    {
        private Client _currentClient;
        private Reservation reservation = new Reservation();
        private bool chargement = false;
        private bool _reservationVerified = false;
        private bool clientHasReservation;

        VehicleController vehicleController = new VehicleController();
        ReservationLocationController reservationLocationController = new ReservationLocationController();
        ClientManagementController clientManagementController = new ClientManagementController();

        private List<Vehicle> listAvailableVehicles = new List<Vehicle>();
        private List<Vehicle> listAvailableVehiclesTypes = new List<Vehicle>();
        private List<Vehicle> listAvailableVehiclesBrands = new List<Vehicle>();
        private List<Vehicle> listAvailableVehiclesModels = new List<Vehicle>();
        private List<Vehicle> listAvailableVehiclesEditions = new List<Vehicle>();
        private List<Vehicle> listAvailableVehiclesYears = new List<Vehicle>();

        public VehiculeLoanForm(bool clientHasReservation)
        {
            InitializeComponent();
            this.clientHasReservation = clientHasReservation;
            if (!clientHasReservation)
            {
                lbl_numero_reservation.Hide();
                numeroReservation.Hide();
                checkNumeroReservation.Hide();
                pn_section3.Location = new Point(12, 60);
            }

            beginning.MinDate = DateTime.Now;
            end.MinDate = DateTime.Now;
            chargement = true;
        }

        private void clientCode_TextChanged(object sender, EventArgs e)
        {
            _reservationVerified = false;
            _currentClient = null;

            if (clientHasReservation)
                numeroReservation.Clear();

            FormUtilities.SetTextBoxStateDisabled(Controls);
            typeComboBox.Items.Clear();
            brandComboBox.Items.Clear();
            modelComboBox.Items.Clear();
            editionComboBox.Items.Clear();
            yearComboBox.Items.Clear();
        }

        private void checkCodeButton_Click(object sender, EventArgs e)
        {
            _currentClient = clientManagementController.CodeVerification(clientCode.Text);

            if (_currentClient != null)
                ResetVehiclesControls();

            if (numeroReservation.Visible)
                FormUtilities.SetTextBoxStateEnabled(pn_section2.Controls);
            else
            {
                FormUtilities.SetTextBoxStateEnabled(pn_section3.Controls);
                beginning.Enabled = false;
                listAvailableVehicles = reservationLocationController.GetAvailableVehicles(beginning.Value, end.Value);
                List<string> types = vehicleController.GetTypesFromVehicles(listAvailableVehicles);
                FormUtilities.FillComboBox(typeComboBox, types);
            }
        }

        private void beginning_ValueChanged(object sender, EventArgs e)
        {
            if ((!_reservationVerified))
            {
                ResetVehiclesControls();

                if (chargement)
                {
                    listAvailableVehicles = reservationLocationController.GetAvailableVehicles(beginning.Value, end.Value);
                    List<string> types = vehicleController.GetTypesFromVehicles(listAvailableVehicles);

                    FormUtilities.FillComboBox(typeComboBox, types);
                }
            }
        }
        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_reservationVerified)
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
        }
        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_reservationVerified)
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
        }
        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_reservationVerified)
            {
                yearComboBox.Items.Clear();
                editionComboBox.Items.Clear();

                yearComboBox.Text = "";
                editionComboBox.Text = "";

                listAvailableVehiclesModels = vehicleController.GetAvailableVehiclesEditions(listAvailableVehiclesBrands, modelComboBox.SelectedItem.ToString());
                List<string> editions = vehicleController.GetEditionsFromVehicles(listAvailableVehiclesModels);
                FormUtilities.FillComboBox(editionComboBox, editions);
            }
        }
        private void editionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_reservationVerified)
            {
                yearComboBox.Items.Clear();
                yearComboBox.Text = "";

                listAvailableVehiclesEditions = vehicleController.GetAvailableVehiclesYears(listAvailableVehiclesModels, editionComboBox.SelectedItem.ToString());
                List<string> years = vehicleController.GetYearsFromVehicles(listAvailableVehiclesEditions);
                FormUtilities.FillComboBox(yearComboBox, years);
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool verif = !FormUtilities.IsAnyLocationControlEmpty(Controls, clientHasReservation);
            if (verif)
            {
                Vehicle vehicle;

                if (!_reservationVerified)
                    vehicle = listAvailableVehiclesEditions[0];
                else
                    vehicle = reservation.vehicle;

                if (reservationLocationController.SaveLocation(_currentClient, vehicle, beginning.Value, end.Value, clientHasReservation, reservation))
                    DialogResult = DialogResult.OK;
            }
            else
                FormUtilities.SomethingWentWrongMessageBox("Erreur", "Tous les champs doivent être remplis");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void end_ValueChanged(object sender, EventArgs e)
        {
            if (!_reservationVerified)
            {
                ResetVehiclesControls();

                if (chargement)
                {
                    List<Vehicle> ListAvailableVehicles = reservationLocationController.GetAvailableVehicles(beginning.Value, end.Value);
                    List<string> types = vehicleController.GetTypesFromVehicles(ListAvailableVehicles);
                    FormUtilities.FillComboBox(typeComboBox, types);
                }
            }
        }

        private void numeroReservation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void numeroReservation_TextChanged(object sender, EventArgs e)
        {
            if (_reservationVerified)
            {
                FormUtilities.SetTextBoxStateDisabled(pn_section3.Controls);
                typeComboBox.Items.Clear();
                brandComboBox.Items.Clear();
                modelComboBox.Items.Clear();
                editionComboBox.Items.Clear();
                yearComboBox.Items.Clear();
                _reservationVerified = false;
            }
        }

        private void checkNumeroReservation_Click(object sender, EventArgs e)
        {
            if (!numeroReservation.Text.Trim().Equals(""))
            {
                reservation = reservationLocationController.VerifyReservation(_currentClient.code, Convert.ToInt32(numeroReservation.Text));

                if (reservation != null)
                {
                    if (reservationLocationController.StartDateVerification(reservation.start_date, 1))
                    {
                        string[] vehiclesInformations = vehiclesInformations = vehicleController.GetVehiclesReservation(reservation);
                        FillAllCombobox(vehiclesInformations);
                        _reservationVerified = true;
                        FormUtilities.SuccessMessageBox("Le réservation du client a bien été vérifié");
                    }
                }
                else
                {
                    FormUtilities.NoItemFound("La réservation du client n'existe pas");
                    numeroReservation.Text = "";
                    _reservationVerified = false;
                }
            }
            else
                FormUtilities.ReservationCodeCantBeEmpty();
        }

        private void FillAllCombobox(string[] vehicleData)
        {
            for (int i = 0; i < vehicleData.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        FormUtilities.SetComboBox(typeComboBox, vehicleData[i].ToString());
                        break;
                    case 1:
                        FormUtilities.SetComboBox(brandComboBox, vehicleData[i].ToString());
                        break;
                    case 2:
                        FormUtilities.SetComboBox(modelComboBox, vehicleData[i].ToString());
                        break;
                    case 3:
                        FormUtilities.SetComboBox(editionComboBox, vehicleData[i].ToString());
                        break;
                    case 4:
                        FormUtilities.SetComboBox(yearComboBox, vehicleData[i].ToString());
                        break;
                    case 5:
                        try
                        {
                            end.Value = DateTime.Parse(vehicleData[i]);
                        }
                        catch (Exception)
                        {
                            FormUtilities.SomethingWentWrongMessageBox("Erreur", vehicleData[i] + "n'est pas une date.");
                        }
                        break;
                }
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
