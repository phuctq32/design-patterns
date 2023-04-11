using Decorator.Milktea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class BlackSugarDecorator : MilkTeaDecorator
    {
        public BlackSugarDecorator(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 2000;
        }
    }
}
