using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDemo
{
     class ConfirmedState : IOrderState
    {
        private Order order;

        public ConfirmedState(Order order)
        {
            this.order = order;
        }
        public void cancel()
        {
            //Xử lý hủy đơn hàng
            Console.WriteLine("Huy don hang thanh cong");
            this.order.changeState(new CancelledState());
            
        }

        public void confirmOrder()
        {
            //Xủ lý xác nhận đơn hàng
            Console.WriteLine("Don hang da duoc xac nhan roi");
        }
        public void ship()
        {
            //Xử lý vận chuyển đơn
            Console.WriteLine("Tien hanh van chuyrn don hang");
            this.order.changeState(new DeliveringState(this.order));
        }

        public void deliver()
        {
            //Xử lý giao đơn hàng
            Console.WriteLine("Khong the giao khi chua van chuyen");
        }
    }
}
