using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    public class DeliveryAgencyFactory
    {
        public static DeliveryAgency createAgency(Agency agency)
        {
            switch (agency)
            {
                case Agency.ViettelPost:
                    return new ViettelPostDeliveryAgency();
                case Agency.GiaoHangTietKiem:
                    return new GiaoHangTietKiemDeliveryAgency();
            }
            throw new Exception($"Invalid  {agency}");
        }
    }


    public abstract class DeliveryAgency
    {
        public abstract ShippingOrder createShippingOrder(Order order);
        public abstract void updateShippingStatus(int orderId, ShippingOrderStatus status);
        public abstract void cancelShippingOrder(int orderId);
    }

    public enum Agency { ViettelPost, GiaoHangTietKiem }
    public enum ShippingOrderStatus
    {
        created, shippig, complete,
    }
    public class Order
    {
        public int id { get; set; }
    }
    public class ShippingOrder
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public DateTime date { get; set; } = DateTime.UtcNow;
    }

}
