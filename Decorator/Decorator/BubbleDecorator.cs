using Decorator.Milktea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class BubbleDecorator : MilkTeaDecorator
    {
        public BubbleDecorator(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 5000;
        }
    }
}
