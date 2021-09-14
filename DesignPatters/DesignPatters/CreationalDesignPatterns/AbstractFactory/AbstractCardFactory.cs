using DesignPatters.Models;

namespace DesignPatters.CreationalDesignPatterns.AbstractFactory
{
    abstract class AbstractCardFactory
    {
        public abstract ICard GetCard(string cardType);
        public static AbstractCardFactory CreateCardFactory(string factoryType)
        {
            if (factoryType.Equals("Debit"))
                return new DebitCardFactory();
            return new CreditCardFactory();
        }
    }
}
