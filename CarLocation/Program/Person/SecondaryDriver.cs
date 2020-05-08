using System;

namespace CarLocation.Classes
{
    public class SecondaryDriver : Client
    {
        //Constructeurs
        public SecondaryDriver() { }
        public SecondaryDriver(string driver_licence, DateTime inscription_date, string lname, string fname) : base(driver_licence, inscription_date, lname, fname)
        { }
    }
}
