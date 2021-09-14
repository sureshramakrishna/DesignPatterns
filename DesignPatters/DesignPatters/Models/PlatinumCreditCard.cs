namespace DesignPatters.Models
{
    internal class PlatinumCreditCard : ICard
    {
        public int GetAnnualCharge() => 500;

        public string GetCardType() => "Platinum Credit Card";

        public int GetLimit() => 150000;
    }
}
