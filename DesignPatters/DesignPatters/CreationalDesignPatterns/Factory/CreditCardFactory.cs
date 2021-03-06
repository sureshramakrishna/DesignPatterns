using DesignPatters.Models;

#pragma warning disable 8603
namespace DesignPatters.CreationalDesignPatterns.Factory
{
    internal class CreditCardFactory
    {
        public static ICard GetCreditCard(string cardType)
        {
            return cardType switch
            {
                "Diamond" => new DiamondCreditCard(),
                "Titanium" => new TitaniumCreditCard(),
                "Platinum" => new PlatinumCreditCard(),
                _ => null
            };
        }
    }
}
