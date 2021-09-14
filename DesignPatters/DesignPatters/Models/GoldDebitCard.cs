namespace DesignPatters.Models
{
    internal class GoldDebitCard : ICard
    {
        public int GetAnnualCharge() => 50;

        public string GetCardType() => "Gold Debit Card";

        public int GetLimit() => 100000;
    }
}
