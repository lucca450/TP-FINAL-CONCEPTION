namespace CarLocation.Classes
{
    public class VehicleCopy
    {
        public Vehicle vehicle { get; set; }
        public string state { get; set; }
        public bool crashed { get; set; }
        public string licensePlate { get; set; }
        public int kilometer { get; set; }

        public VehicleCopy() { }

        public VehicleCopy(Vehicle vehicle, string state, bool crashed, string licensePlate, int kilometer)
        {
            this.vehicle = vehicle;
            this.state = state;
            this.crashed = crashed;
            this.licensePlate = licensePlate;
            this.kilometer = kilometer;
        }

        public bool IsStateAvailable() { return state == "Disponible"; }

        public bool IsKilometerSmaller(int oldKilometer) { return kilometer > oldKilometer; }
    }
}
