using AbstractFactory.Chair;
using AbstractFactory.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class PlasticFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            // create logic here
            return new PlasticChair();
        }

        public ITable CreateTable()
        {
            return new PlasticTable();
        }
    }
}
