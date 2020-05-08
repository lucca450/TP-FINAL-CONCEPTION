using System;

namespace CarLocation.Classes
{
    public class Attendant : Person
    {
        public DateTime hiringDate { get; set; }

        //Constructeur
        public Attendant(DateTime hiringDate, string lastName, string firstName, string phone, string address) : base(lastName, firstName, phone, address)
        {
            this.hiringDate = hiringDate;
        }
    }
}
