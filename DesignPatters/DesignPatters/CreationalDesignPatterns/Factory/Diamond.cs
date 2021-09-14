using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.CreationalDesignPatterns.Factory
{
    public class Diamond : ICreditCard
    {
        public string GetCardType()
        {
            return "Diamond Credit Card";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}
