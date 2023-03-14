using AbstractFactory.Chair;
using AbstractFactory.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal interface IFurnitureFactory
    {
        IChair CreateChair();
        ITable CreateTable();
    }
}
