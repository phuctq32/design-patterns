using Decorator.Milktea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class EggPuddingDecorator : MilkTeaDecorator
    {
        public EggPuddingDecorator(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 7000;
        }
    }
}
