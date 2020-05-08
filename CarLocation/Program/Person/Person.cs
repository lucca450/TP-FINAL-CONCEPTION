namespace CarLocation.Classes
{
    public abstract class Person
    {
        public string lname { get; set; }
        public string fname { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        public Person() { }

        //Constructeur pour les Attendants(Preposés) et Clients
        public Person(string lname, string fname, string phone, string address)
        {
            this.lname = lname;
            this.fname = fname;
            this.phone = phone;
            this.address = address;
        }

        //Constructeur pour les SecondaryDriver(conducteurs secondaires)
        public Person(string lname, string fname)
        {
            this.lname = lname;
            this.fname = fname;
        }
    }
}
