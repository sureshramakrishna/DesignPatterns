using DesignPatters.CreationalDesignPatterns.Factory;
using DesignPatters.Models;

namespace DesignPatters.CreationalDesignPatterns.FactoryMethod
{
    internal abstract class AbstractCreditCardFactory
    {
        protected abstract ICard MakeCreditCard();
        public ICard GetCreditCard() => MakeCreditCard();
    }
}
