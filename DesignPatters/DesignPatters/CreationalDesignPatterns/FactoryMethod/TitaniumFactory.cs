using DesignPatters.CreationalDesignPatterns.Factory;
using DesignPatters.Models;

namespace DesignPatters.CreationalDesignPatterns.FactoryMethod
{
    internal class TitaniumFactory : AbstractCreditCardFactory
    {
        protected override ICard MakeCreditCard()
        {
            return new TitaniumCreditCard();
        }
    }
}
