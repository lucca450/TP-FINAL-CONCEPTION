using System;
using System.Collections.Generic;

namespace CarLocation.Classes
{
    public class Location
    {
        public VehicleCopy vehicleCopy { get; set; }
        public Client client { get; set; }
        public Attendant attendant { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int kilometer { get; set; }
        public double location_price { get; set; }

    public Location(VehicleCopy vehicleCopy, Client client, Attendant attendant, DateTime start_date, DateTime end_date, double location_price, int kilometer)
        {
            this.vehicleCopy = vehicleCopy;
            this.client = client;
            this.attendant = attendant;
            this.start_date = start_date;
            this.end_date = end_date;
            this.location_price = location_price;
            this.kilometer = kilometer;
        }

        public bool CheckLocationVehicleDate(DateTime start_date, DateTime end_date)
        {
            return (this.end_date.Date >= start_date.Date) && (this.start_date.Date <= end_date.Date);
        }
    }
}
