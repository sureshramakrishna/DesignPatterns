using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatters.Models;

#pragma warning disable 8603

namespace DesignPatters.CreationalDesignPatterns.AbstractFactory
{
    class CreditCardFactory : AbstractCardFactory
    {
        public override ICard GetCard(string cardType)
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
