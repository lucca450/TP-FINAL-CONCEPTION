namespace CarLocation.Classes
{
    public class Type
    {
        public string name { get; set; }

        public Type(string name) { this.name = name; }

        public bool CheckType(string type) { return name.Equals(type); }
    }
}
