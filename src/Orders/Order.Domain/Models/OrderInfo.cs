using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain
{
    public class OrderInfo
    {
        public MeettingAddress Address { get; private set; }
        public DateTime MeettingTime { get; private set; }
    }
}
