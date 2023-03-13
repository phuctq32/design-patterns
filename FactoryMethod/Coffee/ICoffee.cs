using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Coffee
{
    public interface ICoffee
    {
        string GetName();
        void Prepare();
        void Make();
    }
}
