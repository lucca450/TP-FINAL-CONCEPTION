using CarLocation.Classes;
using System;
using System.Collections.Generic;

namespace CarLocation.Program.ReservationLocation.Controller
{
   public class ReservationLocationController
    {
        public DataManager dataManager;
        public ReservationLocationController() { dataManager = DataManager.Instance; }

        public List<Vehicle> GetAvailableVehicles(DateTime start_date, DateTime end_date)
        {
            List<Vehicle> tmpAvailableVehicles = new List<Vehicle>();
            foreach (Vehicle vehicle in dataManager.GetVehiclesCatalog().vehiclesAvailable)
            {
                int nbrReservation = 0;
                int nbrLocation = 0;
                int nbrVehicle = vehicle.CountAvailableVehicleCopy();

                if (nbrVehicle > 0)
                {
                    nbrReservation = CountVehicleReservation(vehicle, start_date, end_date); // Compte le nombre de réservatrions
                    nbrLocation = CountVehicleLocation(vehicle, start_date, end_date);
                }

                nbrVehicle = nbrVehicle - nbrReservation - nbrLocation;

                if (nbrVehicle > 0)
                    tmpAvailableVehicles.Add(vehicle);
            }

            return tmpAvailableVehicles;
        }


        private int CountVehicleReservation(Vehicle vehicle, DateTime start_date, DateTime end_date)
        {
            int nbrVehicle = 0;
            foreach (Reservation reservation in dataManager.GetReservationsList())
                if (reservation.vehicle.Equals(vehicle))
                    if (reservation.CheckReservationVehicleDate(start_date, end_date))
                        nbrVehicle++;

            return nbrVehicle;
        }

        private int CountVehicleLocation(Vehicle vehicle, DateTime start_date, DateTime end_date)
        {
            int nbrVehicle = 0;
            foreach (Location location in dataManager.GetLocationsList())
                if (location.vehicleCopy.vehicle.Equals(vehicle))
                    if (location.CheckLocationVehicleDate(start_date, end_date))
                        nbrVehicle++;

            return nbrVehicle;
        }

        private bool SaveReserv(Client _currentClient, List<Vehicle> vehicles, DateTime start_date, DateTime end_date)
        {
            Attendant attendant = dataManager.GetAttendantsList()[0];
            Reservation reservation = new Reservation(vehicles[0], attendant, _currentClient, start_date, end_date);

            if (reservation != null)
            {
                dataManager.AddReservationsList(reservation);
                FormUtilities.SuccessMessageBox("La réservation a bien été enregistrée. Le numéro de réservation est : " + reservation.id_reservation);
                return true;
            }
            else
            {
                FormUtilities.SomethingWentWrongMessageBox("Erreur", "Il y a eu une erreur lors de la réservation");
                return false;
            }
        }

        private bool SaveLocation(Client _currentClient, Vehicle vehicle, DateTime start_date, DateTime end_date)
        {
            VehicleCopy vehicleCopy = GetUniqueVehicleCopyOrderByKilometer(vehicle);
            Attendant attendant = dataManager.GetAttendantsList()[0];
            Location location = new Location(vehicleCopy, _currentClient, attendant, DateTime.Now, end_date, vehicle.location_price, vehicleCopy.kilometer);

            if (location !=  null)
            {
                dataManager.AddLocationsList(location);
                FormUtilities.SuccessMessageBox("La location a bien été enregistrée.");
                return true;
            }
            else
            {
                FormUtilities.SomethingWentWrongMessageBox("Erreur", "La location n'a pas pu être crée");
                return false;
            }
        }

        private bool PaymentReservation(Client _currentClient)
        {
            Payment payment = new Payment(_currentClient, 200);

            if (payment != null)
            {
                dataManager.AddPaymentsList(payment);
                FormUtilities.SuccessMessageBox("La paiement de la réservation pour 200$ a bien été enregistrée.");
                return true;
            }
            else
            {
                FormUtilities.SomethingWentWrongMessageBox("Erreur", "La réservation n'a pas pu être supprimée");
                return false;
            }
        }

        public Reservation VerifyReservation(string code, int id_reservation)
        {
            foreach (Reservation r in dataManager.GetReservationsList())
                if (r.ReservationVerification(code, id_reservation))
                    return r;

            return null;
        }

        private bool DeleteReservation(int id_reservation)
        {
            bool delete = false;
            foreach (Reservation reservation in dataManager.GetReservationsList())
            {
                if (reservation.CheckID_Reservation(id_reservation))
                {
                    dataManager.RemoveReservationList(reservation);
                    delete = true;
                    break;
                }
            }
            if (delete)
            {
                FormUtilities.SuccessMessageBox("La réservation a également été supprimée");
                return true;
            }
            else
            {
                FormUtilities.SomethingWentWrongMessageBox("Erreur", "La réservation n'a pas pu être supprimée");
                return false;
            }
        }

        public bool StartDateVerification(DateTime startingDate, int message)
        {
            try
            {
                if (startingDate.Date == DateTime.Now.Date)
                    return true;
                else
                {
                    if (message == 1)
                        FormUtilities.SomethingWentWrongMessageBox("Erreur", "La réservation n'est pas pour aujourd'hui, mais pour " + startingDate.Date);
                    else if (message == 2)
                        FormUtilities.SomethingWentWrongMessageBox("Erreur", "La date de début de la location doit être avant ou égal à la date de fin.");

                    return false;
                }
            }
            catch (Exception e)
            {
                FormUtilities.SomethingWentWrongMessageBox("Erreur", e.Message);
                return false;
            }
        }

        private VehicleCopy GetUniqueVehicleCopyOrderByKilometer(Vehicle vehicle)
        {
            VehicleCopy tmpVehicleCopy = new VehicleCopy();
            tmpVehicleCopy.kilometer = -1;

            foreach (VehicleCopy v in vehicle.vehiclesCopy)
                if (v.IsKilometerSmaller(tmpVehicleCopy.kilometer))
                    tmpVehicleCopy = v;

            return tmpVehicleCopy;
        }

        public bool SaveLocation(Client _currentClient, Vehicle vehicle, DateTime start_date, DateTime end_date, bool clientHasReservation, Reservation reservation)
        {
            bool successSavingLocation;
            bool successDeletingReservation;

            if (StartDateVerification(start_date, 2))
            {
                successSavingLocation = SaveLocation(_currentClient, vehicle, start_date, end_date);
                if (successSavingLocation)
                {
                    if (clientHasReservation)
                    {
                        successDeletingReservation = DeleteReservation(reservation.id_reservation);
                        if (successDeletingReservation)
                            return true;
                        else
                            return false;
                    }
                    else
                        return true;
                }
                else
                    return false;
            }
            return false;
        }

        public bool SaveReservation(Client _currentClient, List<Vehicle> listAvailableVehiclesYears, DateTime start_date, DateTime end_date)
        {
            if (SaveReserv(_currentClient, listAvailableVehiclesYears, start_date, end_date))
            {
                if (PaymentReservation(_currentClient))
                    return true;
                else
                    return false;
            }else
                return false;
        }
    }
}
