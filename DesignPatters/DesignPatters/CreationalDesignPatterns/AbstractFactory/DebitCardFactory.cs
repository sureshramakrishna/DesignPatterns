using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatters.Models;

#pragma warning disable 8603

namespace DesignPatters.CreationalDesignPatterns.AbstractFactory
{
    internal class DebitCardFactory : AbstractCardFactory
    {
        public override ICard GetCard(string cardType)
        {
            return cardType switch
            {
                "Gold" => new GoldDebitCard(),
                "Silver" => new SilverDebitCard(),
                "Bronze" => new BronzeDebitCard(),
                _ => null
            };
        }
    }
}
