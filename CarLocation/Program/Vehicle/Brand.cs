namespace CarLocation.Classes
{
    public class Brand
    {
        public string name { get; set; }

        public Brand(string name) { this.name = name; }

        public bool CheckBrand(string brand) { return name.Equals(brand); }
    }
}
