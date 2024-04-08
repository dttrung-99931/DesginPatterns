using DesignPattern.AbstractFactoryDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    public class GiaoHangTietKiemDeliveryAgency : DeliveryAgency
    {
        public override void cancelShippingOrder(int orderId)
        {
            Console.WriteLine("GiaoHangTietKiem cancelShippingOrder");
        }

        public override ShippingOrder createShippingOrder(Order order)
        {
            Console.WriteLine("GiaoHangTietKiem createShippingOrder");
            return new ShippingOrder()
            {
                orderId = order.id,
            };
        }

        public override void updateShippingStatus(int orderId, ShippingOrderStatus status)
        {
            Console.WriteLine("GiaoHangTietKiem updateShippingStatus");
        }
    }
}
