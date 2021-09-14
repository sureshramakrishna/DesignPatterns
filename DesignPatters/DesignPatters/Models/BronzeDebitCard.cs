namespace DesignPatters.Models
{
    internal class BronzeDebitCard : ICard
    {
        public int GetAnnualCharge() => 10;

        public string GetCardType() => "Bronze Debit Card";

        public int GetLimit() => 50000;
    }
}
