using System.Collections.Generic;
using CarLocation.Classes;

namespace CarLocation
{
    public sealed class DataManager
    {
        //Listes qui agissent comme base de données
        private List<Client> clientsList = new List<Client>();
        private List<Attendant> attendantsList = new List<Attendant>();
        private List<Reservation> reservationsList = new List<Reservation>();
        private List<Location> locationsList = new List<Location>();
        private List<Payment> paymentsList = new List<Payment>();
        private VehicleCatalog vehiclesCatalog = new VehicleCatalog();

        private static DataManager instance = null;

        public static DataManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataManager();
                return instance;
            }
        }


        private DataManager() {}

        //Permet de générer le code du client
        public string GenerateClientCode(Client c)
        {
            if (c.lname.Trim().Length < 3 || c.lname.Trim().Length < 1)
                return "xxxx" + (clientsList.Count + 1);
            else
                return c.lname.Substring(0, 3) + c.fname.Substring(0, 1) + (clientsList.Count + 1);    
        }

        //Retourne la liste du client
        public List<Client> GetClientsList() { return clientsList; }

        //Ajoute dans la liste du client
        public void AddClientsList(Client client) { clientsList.Add(client); }

        //Retourne liste des préposés
        public List<Attendant> GetAttendantsList() { return attendantsList; }

        //Ajoute dans la liste des préposés
        public void AddAttendantsList(Attendant attendant) { attendantsList.Add(attendant); }

        //Retourne liste des réservations
        public List<Reservation> GetReservationsList() { return reservationsList; }

        //Ajoute dans la liste des reservations
        public void AddReservationsList(Reservation reservation) { reservationsList.Add(reservation); }

        //Retourne liste des locations
        public List<Location> GetLocationsList() { return locationsList; }

        //Ajoute dans la liste des locations
        public void AddLocationsList(Location location) { locationsList.Add(location); }

        //Retourne le catalog de véhicules
        public VehicleCatalog GetVehiclesCatalog() { return vehiclesCatalog; }

        //Retourne liste des paiements
        public List<Payment> GetPayments() { return paymentsList; }

        //Ajoute dans la liste des paiements
        public void AddPaymentsList(Payment payment) { paymentsList.Add(payment); }

        //Supprimer dans la liste des réservations
        public void RemoveReservationList(Reservation reservation) { reservationsList.Remove(reservation); }
    }
}
