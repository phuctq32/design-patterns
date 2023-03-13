using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Coffee
{
    internal class NorthernWhiteCoffee : ICoffee
    {
        public string GetName()
        {
            return "Ca phe sua kieu Bac";
        }

        public void Prepare()
        {

        }

        public void Make()
        {

        }
    }
}
