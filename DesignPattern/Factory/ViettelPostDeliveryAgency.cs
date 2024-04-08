using DesignPattern.AbstractFactoryDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    public class ViettelPostDeliveryAgency : DeliveryAgency
    {
        public override void cancelShippingOrder(int orderId)
        {
            Console.WriteLine("ViettelPost cancelShippingOrder");
        }

        public override ShippingOrder createShippingOrder(Order order)
        {
            Console.WriteLine("ViettelPost createShippingOrder");
            return new ShippingOrder()
            {
                orderId = order.id,
            };
        }

        public override void updateShippingStatus(int orderId, ShippingOrderStatus status)
        {
            Console.WriteLine("ViettelPost updateShippingStatus");
        }
    }
}
