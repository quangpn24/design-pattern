using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDemo
{
    class WaitingConfirmState : IOrderState
    {
        private Order order;

        public WaitingConfirmState(Order order)
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
            Console.WriteLine("Xac nhan don hang thanh cong");
            this.order.changeState(new ConfirmedState(this.order));
        }
        public void ship()
        {
            //Xử lý vận chuyển đơn
            Console.WriteLine("Khong the van chuyen khi chua xac nhan");
        }

        public void deliver()
        {
            //Xử lý giao đơn hàng
            Console.WriteLine("Khong the giao khi chua van chuyen");
        }

       
    }
}
