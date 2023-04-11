using Decorator.Milktea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea milkTea;
        public IMilkTea MilkTea { get => milkTea; set => milkTea = value; }
        protected MilkTeaDecorator(IMilkTea milkTea) 
        {
            this.MilkTea = milkTea;
        }
        public virtual double GetCost()
        {
            return milkTea.GetCost();
        }
    }
}
