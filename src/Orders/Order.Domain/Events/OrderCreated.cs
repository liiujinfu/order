using ENode.Eventing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain
{
    public class OrderCreated : DomainEvent<Guid>
    {
        public OrderInfo Info { get; private set; }

        public OrderCreated(OrderInfo info)
        {
            this.Info = info;
        }
    }
}
