using CarLocation.Classes;

namespace CarLocation.Utilities.Database
{
    public class StartController
    {
        public DataManager dataManager;

        public StartController() { dataManager = DataManager.Instance; }

        //Permet d'avoir des items dans la "BASE DE DONNÉES" principallement pour sauver du temps lors des tests.
        public void GenerateObjects()
        {
            Type type1 = new Type("VUS");
            Type type2 = new Type("Berline");

            Brand brand1 = new Brand("Subaru");
            Brand brand2 = new Brand("Honda");

            Model model1 = new Model("Wrx");
            Model model2 = new Model("Crostreck");
            Model model3 = new Model("Cr-v");
            Model model4 = new Model("Civic");

            Edition edition1 = new Edition("Base");
            Edition edition2 = new Edition("Sti");
            Edition edition3 = new Edition("Turbo");

            Vehicle vehicle1 = new Vehicle(type2, brand1, model1, edition2, 2020, 200);
            Vehicle vehicle2 = new Vehicle(type2, brand2, model4, edition3, 2019, 150);
            Vehicle vehicle3 = new Vehicle(type2, brand1, model2, edition1, 2018, 120);
            Vehicle vehicle4 = new Vehicle(type1, brand2, model3, edition1, 2020, 350);

            dataManager.GetVehiclesCatalog().vehiclesAvailable.Add(vehicle1);
            dataManager.GetVehiclesCatalog().vehiclesAvailable.Add(vehicle2);
            dataManager.GetVehiclesCatalog().vehiclesAvailable.Add(vehicle3);
            dataManager.GetVehiclesCatalog().vehiclesAvailable.Add(vehicle4);

            VehicleCopy vehicleCopy1 = new VehicleCopy(vehicle1, "Disponible", true, "OHOHOH", 20);
            VehicleCopy vehicleCopy2 = new VehicleCopy(vehicle1, "Indisponible", true, "E3E2E6", 2000);
            VehicleCopy vehicleCopy3 = new VehicleCopy(vehicle2, "Disponible", true, "H69LPP", 100);
            VehicleCopy vehicleCopy4 = new VehicleCopy(vehicle2, "Perdu", true, "L77LUC", 200);
            VehicleCopy vehicleCopy5 = new VehicleCopy(vehicle1, "Disponible", true, "OHOHOH", 120);

            vehicle1.vehiclesCopy.Add(vehicleCopy1);
            vehicle1.vehiclesCopy.Add(vehicleCopy2);
            vehicle2.vehiclesCopy.Add(vehicleCopy3);
            vehicle2.vehiclesCopy.Add(vehicleCopy4);
            vehicle1.vehiclesCopy.Add(vehicleCopy5);

            Client client1 = new Client("43534423423", "432423432", System.DateTime.Now, "dubp1", "Dubois-Nadeau", "Pierre-Olivier", "8196932091", "1200 de corbeille");
            dataManager.AddClientsList(client1);

            SecondaryDriver secDriver1 = new SecondaryDriver("432534534", System.DateTime.Now, "Plante", "Georges");
            client1.driversList.Add(secDriver1);

            Attendant attendant1 = new Attendant(System.DateTime.Now, "Possa Silva", "Lucca", "8196937843", "1300 de la corbeille");
            dataManager.AddAttendantsList(attendant1);

            Reservation r = new Reservation(vehicle1, attendant1, client1, System.DateTime.Now, System.DateTime.Now.AddDays(2));
            dataManager.AddReservationsList(r);
        }
    }
}
