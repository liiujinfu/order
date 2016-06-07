using ENode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain
{
    public class Order : AggregateRoot<Guid>
    {
        private OrderInfo _info;
        private IList<House> _houses;
        private OrderStatus _status;

        public Order(Guid id, OrderInfo info, IList<House> houses) : base(id)
        {
            ApplyEvent(new OrderCreated(info, houses));
        }

        #region event handle methods
        private void Handle(OrderCreated evnt)
        {
            this._id = evnt.AggregateRootId;
            this._info = evnt.Info;
            this._houses = evnt.Houses ?? new List<House>();
            this._status = OrderStatus.Appoint;
        } 
        #endregion
    }
}
