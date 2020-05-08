namespace CarLocation.Classes
{
    public class Payment
    {
        public Client client { get; set; }
        public double amount { get; set; }

        public Payment(Client client, double amount)
        {
            this.client = client;
            this.amount = amount;
        }
    }
}
