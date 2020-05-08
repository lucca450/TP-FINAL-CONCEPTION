using System;
using System.Collections.Generic;
using System.Linq;

namespace CarLocation.Classes
{
    public class Client : Person
    {
        public string card_number { get; set; }
        public string driver_licence { get; set; }
        public DateTime inscription_date { get; set; }
        public string code { get; set; }

        public List<SecondaryDriver> driversList = new List<SecondaryDriver>();

        public Client() { }

        //Utilisé pour client
        public Client(string card_number, string driver_licence, DateTime inscription_date, string code, string lname, string fname, string phone, string address) : base(lname, fname, phone, address)
        {
            this.card_number = card_number;
            this.driver_licence = driver_licence;
            this.inscription_date = inscription_date;
            this.code = code;
        }

        //Utilisé pour les conducteurs secondaires
        public Client(string driver_licence, DateTime inscription_date, string lname, string fname) : base(lname, fname)
        {
            this.driver_licence = driver_licence;
            this.inscription_date = inscription_date;
        }

        //Vérifie le code
        public bool CodeVerification(string clientCode) { return code == clientCode; }

        //Vérifie le permis de conduire
        public bool LicenceVerification(string _driver_licence) { return driver_licence == _driver_licence; }

        //Permet de verifier l'existance du conducteur
        public bool DriverExists(string _driverLicence, string _fname, string _lname)
        {
            return (driver_licence == _driverLicence) && (fname == _fname) && (lname == _lname);
        }
    }
}
