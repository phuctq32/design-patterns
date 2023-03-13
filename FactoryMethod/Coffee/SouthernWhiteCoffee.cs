using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Coffee
{
    internal class SouthernWhiteCoffee : ICoffee
    {
        public string GetName()
        {
            return "Ca phe sua kieu Nam";
        }

        public void Prepare()
        {

        }

        public void Make()
        {

        }
    }
}
