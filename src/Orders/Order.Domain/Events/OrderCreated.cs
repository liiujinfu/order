using ENode.Eventing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain
{
    [Serializable]
    public class OrderCreated : DomainEvent<Guid>
    {
        public OrderInfo Info { get; private set; }
        public IList<House> Houses { get; private set; }

        public OrderCreated() { }

        public OrderCreated(OrderInfo info, IList<House> houses)
        {
            this.Info = info;
            this.Houses = houses;
        }
    }
}
