namespace CarLocation.Classes
{
    public class Edition
    {
        public string name { get; set; }

        public Edition(string name) { this.name = name; }

        public bool CheckEdition(string edition) { return name.Equals(edition); }
    }
}
