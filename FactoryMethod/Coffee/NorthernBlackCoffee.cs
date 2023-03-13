using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Coffee
{
    internal class NorthernBlackCoffee : ICoffee
    {
        public string GetName()
        {
            return "Ca phe den kieu Bac";
        }

        public void Prepare()
        {
            
        }

        public void Make()
        {
            
        }
    }
}
