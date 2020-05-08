namespace CarLocation.Classes
{
    public class Model
    {
        public string name { get; set; }

        public Model(string name) { this.name = name; }

        public bool CheckModel(string model) { return name.Equals(model); }
    }
}
