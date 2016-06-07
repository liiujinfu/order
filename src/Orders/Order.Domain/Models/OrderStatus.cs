using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain
{
    public enum OrderStatus
    {
        Appoint = 0,
        Confirmed = 1,
        Looked = 2,
        Finish = 3
    }
}
