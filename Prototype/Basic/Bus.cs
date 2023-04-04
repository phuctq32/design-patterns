using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Basic
{
    public class Bus : Vehicle
    {
        private int numOfSeats;
        public int NumOfSeats { get => numOfSeats; set => numOfSeats = value; }
        public Bus() { }
        public Bus(Bus bus) 
            : base(bus as Vehicle) 
        {
            this.NumOfSeats = bus.NumOfSeats;
        }

        public override Vehicle Clone()
        {
            return new Bus(this);
        }

        public override string ToString()
        {
            return base.ToString() + " | " + "Number of seats: " + this.NumOfSeats;
        }

        
    }
}
