using System.Collections.Generic;

namespace CarLocation.Classes
{
    public class Vehicle
    {
        public Type type { get; set; }
        public Brand brand { get; set; }
        public Model model { get; set; }
        public Edition edition { get; set; }
        public int year { get; set; }
        public double location_price { get; set; }
        public List<VehicleCopy> vehiclesCopy = new List<VehicleCopy>();

        public Vehicle(Type type, Brand brand, Model model, Edition edition, int year, double montant_location)
        {
            this.type = type;
            this.brand = brand;
            this.model = model;
            this.edition = edition;
            this.year = year;
            location_price = montant_location;
        }

        public Vehicle(Type type, Brand brand, Model model, Edition edition, int year, double montant_location, List<VehicleCopy> vehiclesCopy)
        {
            this.type = type;
            this.brand = brand;
            this.model = model;
            this.edition = edition;
            this.year = year;
            location_price = montant_location;
            this.vehiclesCopy = vehiclesCopy;
        }

        public int CountAvailableVehicleCopy()
        {
            int nbrAvailableVehicles = 0;
            foreach (VehicleCopy v in vehiclesCopy)
                if (v.IsStateAvailable())
                    nbrAvailableVehicles++;

            return nbrAvailableVehicles;
        }
    }
}
