using DesignPatters.CreationalDesignPatterns.Factory;
using DesignPatters.Models;

namespace DesignPatters.CreationalDesignPatterns.FactoryMethod
{
    internal class PlatinumFactory : AbstractCreditCardFactory
    {
        protected override ICard MakeCreditCard()
        {
            return new PlatinumCreditCard();
        }
    }
}
