using CarLocation.Classes;
using System;
using System.Collections.Generic;

namespace CarLocation.Utilities.ControllerForm
{
    public class VehicleController
    {
        public DataManager dataManager;
        public VehicleController() { dataManager = DataManager.Instance; }
       
        public List<string> GetTypesFromVehicles(List<Vehicle> vehicles)
        {
            List<string> availableVehicles = new List<string>();
            foreach (Vehicle vehicle in vehicles)
            {
                string type = availableVehicles.Find(typeName => typeName.Contains(vehicle.type.name));
                if (type == null)
                    availableVehicles.Add(vehicle.type.name);
            }
            return availableVehicles;
        }

        public List<Vehicle> GetAvailableVehiclesBrands(List<Vehicle> vehicles, string type)
        {
            List<Vehicle> types = new List<Vehicle>();
            foreach (Vehicle v in vehicles)
                if (v.type.CheckType(type))
                    types.Add(v);

            return types;
        }

        public List<string> GetBrandsFromVehicles(List<Vehicle> vehicles)
        {
            List<string> availableVehicles = new List<string>();
            foreach (Vehicle vehicle in vehicles)
            {
                string brand = availableVehicles.Find(brandName => brandName.Contains(vehicle.brand.name));
                if (brand == null)
                    availableVehicles.Add(vehicle.brand.name);
            }
            return availableVehicles;
        }

        public List<Vehicle> GetAvailableVehiclesModels(List<Vehicle> vehicles, string brand)
        {
            List<Vehicle> brands = new List<Vehicle>();
            foreach (Vehicle v in vehicles)
                if (v.brand.CheckBrand(brand))
                    brands.Add(v);

            return brands;
        }

        public List<string> GetModelsFromVehicles(List<Vehicle> vehicles)
        {
            List<string> availableVehicles = new List<string>();
            foreach (Vehicle vehicle in vehicles)
            {
                string model = availableVehicles.Find(modelName => modelName.Contains(vehicle.model.name));
                if (model == null)
                    availableVehicles.Add(vehicle.model.name);
            }
            return availableVehicles;
        }

        public List<Vehicle> GetAvailableVehiclesEditions(List<Vehicle> vehicles, string model)
        {
            List<Vehicle> models = new List<Vehicle>();
            foreach (Vehicle v in vehicles)
                if (v.model.CheckModel(model))
                    models.Add(v);

            return models;
        }

        public List<string> GetEditionsFromVehicles(List<Vehicle> vehicles)
        {
            List<string> availableVehicles = new List<string>();
            foreach (Vehicle vehicle in vehicles)
            {
                string edition = availableVehicles.Find(editionName => editionName.Contains(vehicle.edition.name));
                if (edition == null)
                    availableVehicles.Add(vehicle.edition.name);
            }
            return availableVehicles;
        }

        public List<Vehicle> GetAvailableVehiclesYears(List<Vehicle> vehicles, string edition)
        {
            List<Vehicle> editions = new List<Vehicle>();
            foreach (Vehicle v in vehicles)
                if (v.edition.CheckEdition(edition))
                    editions.Add(v);

            return editions;
        }
        public List<string> GetYearsFromVehicles(List<Vehicle> vehicles)
        {
            List<int> availableVehicles = new List<int>();
            foreach (Vehicle vehicle in vehicles)
                if (availableVehicles.IndexOf(vehicle.year) == -1)
                    availableVehicles.Add(vehicle.year);

            return availableVehicles.ConvertAll(delegate (int i) { return i.ToString(); });
        }
        public string[] GetVehiclesReservation(Reservation reservation)
        {
            string[] vehiclesInformations = new String[5];

            vehiclesInformations[0] = reservation.vehicle.type.name.ToString();
            vehiclesInformations[1] = reservation.vehicle.brand.name.ToString();
            vehiclesInformations[2] = reservation.vehicle.model.name.ToString();
            vehiclesInformations[3] = reservation.vehicle.edition.name.ToString();
            vehiclesInformations[4] = reservation.vehicle.year.ToString();

            return vehiclesInformations;
        }
    }
}
