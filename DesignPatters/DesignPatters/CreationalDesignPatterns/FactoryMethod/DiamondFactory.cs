using DesignPatters.CreationalDesignPatterns.Factory;
using DesignPatters.Models;

namespace DesignPatters.CreationalDesignPatterns.FactoryMethod
{
    internal class DiamondFactory : AbstractCreditCardFactory
    {
        protected override ICard MakeCreditCard()
        {
            return new DiamondCreditCard();
        }
    }
}
