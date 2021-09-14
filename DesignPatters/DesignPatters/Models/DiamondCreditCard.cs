namespace DesignPatters.Models
{
    public class DiamondCreditCard : ICard
    {
        public string GetCardType() => "Diamond Credit Card";

        public int GetLimit() => 25000;

        public int GetAnnualCharge() => 1500;
    }
}
