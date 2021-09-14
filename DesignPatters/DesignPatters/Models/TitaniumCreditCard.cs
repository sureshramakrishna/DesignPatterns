namespace DesignPatters.Models
{
    public class TitaniumCreditCard : ICard
    {
        public string GetCardType() => "Titanium Credit Card";

        public int GetLimit() => 25000;

        public int GetAnnualCharge() => 1500;
    }
}
