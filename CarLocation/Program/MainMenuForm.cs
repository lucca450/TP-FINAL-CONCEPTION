using CarLocation.Utilities.Database;
using System;
using System.Windows.Forms;

namespace CarLocation
{
    public partial class MainMenuForm : Form
    {
        StartController startController = new StartController();

        public MainMenuForm()
        {
            InitializeComponent();
            startController.GenerateObjects();
        }

        private void reserveVehiculeButton_Click(object sender, EventArgs e)
        {
            OpenForm(new VehiculeReservationForm());
        }

        private DialogResult OpenForm(Form f)
        {
            DialogResult dr = f.ShowDialog();
            return dr;
        }

        private void LendButton_Click(object sender, EventArgs e)
        {
            DialogResult clientHasRevervationDR = MessageBox.Show("Le client a t-il un numéro de confirmation ?", "Choix", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            OpenForm(new VehiculeLoanForm((clientHasRevervationDR == DialogResult.Yes)));
        }

        private void ClientManagementButton_Click(object sender, EventArgs e)
        {
            OpenForm(new ClientManagementForm());
        }
    }
}
