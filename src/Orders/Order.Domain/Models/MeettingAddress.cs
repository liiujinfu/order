using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain
{
    public class MeettingAddress
    {
        public string Name { get; private set; }
        public decimal CoordinateX { get; private set; }
        public decimal CoordinateY { get; private set; }

        public MeettingAddress(string name, decimal x, decimal y)
        {
            this.Name = name;
            this.CoordinateX = x;
            this.CoordinateY = y;
        }

    }
}
