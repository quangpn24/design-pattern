using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDemo
{
    class DeliveringState : IOrderState
    {
        private Order order;

        public DeliveringState(Order order)
        {
            this.order = order;
        }
        public void cancel()
        {
            //Xử lý hủy đơn hàng
            Console.WriteLine("Hủy đơn hàng");
            this.order.changeState(new CancelledState());
        }

        public void confirmOrder()
        {
            //Xủ lý xác nhận đơn hàng
            Console.WriteLine("Đơn hàng đã được xác nhận rồi");
        }
        public void ship()
        {
            //Xử lý vận chuyển đơn
            Console.WriteLine("Đơn hàng đã được vận chuyển rồi");
        }

        public void deliver()
        {
            //Xử lý giao đơn hàng
            Console.WriteLine("Giao hàng cho khách");
            this.order.changeState(new CompletedState());
        }
    }
}
