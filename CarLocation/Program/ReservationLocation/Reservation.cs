using System;
using System.Collections.Generic;

namespace CarLocation.Classes
{
    public class Reservation
    {
        private static int instance_count = 0;
        public int id_reservation { get; set; }
        public Vehicle vehicle { get; set; }
        public Attendant attendant { get; set; }
        public Client client { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }

        public Reservation() { }

        public Reservation(Vehicle vehicle, Attendant attendant, Client client, DateTime start_date, DateTime end_date)
        {
            id_reservation = ++instance_count;
            this.vehicle = vehicle;
            this.attendant = attendant;
            this.client = client;
            this.start_date = start_date;
            this.end_date = end_date;
        }

        public bool CheckReservationVehicleDate(DateTime _start_date, DateTime _end_date) { return (end_date.Date >= _start_date.Date) && (start_date.Date <= _end_date.Date); }

        public bool ReservationVerification(string code, int _id_reservation) { return (client.code == code) && (id_reservation == _id_reservation); }

        public bool CheckID_Reservation(int _id_reservation) { return id_reservation == _id_reservation; }
    }
}
