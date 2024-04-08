using DesignPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDemo
{
    public class FactoryDemo : DesignPatternDemo
    {
        public override void Demo()
        {
            Order order = new Order()
            {
                id = 10,
            };
            DeliveryAgency agency = DeliveryAgencyFactory.createAgency(Agency.GiaoHangTietKiem);
            ShippingOrder shippingOrder=  agency.createShippingOrder(order);
            agency.updateShippingStatus(shippingOrder.id, ShippingOrderStatus.shippig);
        }
    }

}
