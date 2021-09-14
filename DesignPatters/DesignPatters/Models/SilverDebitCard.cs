namespace DesignPatters.Models
{
    internal class SilverDebitCard : ICard
    {
        public int GetAnnualCharge() => 35;

        public string GetCardType() => "Silver Debit Card";

        public int GetLimit() => 75000;
    }
}
