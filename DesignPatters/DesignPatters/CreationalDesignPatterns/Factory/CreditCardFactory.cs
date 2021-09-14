using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.CreationalDesignPatterns.Factory
{
    class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            switch (cardType)
            {
                case "Diamond":
                    return new Diamond();
                case "Titanium":
                    return new Titanium();
                case "Platinum":
                    return new Platinum();
                default: 
                    return null;
            }
        }
    }
}
