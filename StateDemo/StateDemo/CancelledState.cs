using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDemo
{
     class CancelledState :IOrderState
    {
        public void cancel()
        {
            //Xử lý hủy đơn hàng
            Console.WriteLine("Don hang da bi huy");
        }

        public void confirmOrder()
        {
            //Xủ lý xác nhận đơn hàng
            Console.WriteLine("Don hang da bi huy");
        }
        public void ship()
        {
            //Xử lý vận chuyển đơn
            Console.WriteLine("Don hang da bi huy");
        }

        public void deliver()
        {
            //Xử lý giao đơn hàng
            Console.WriteLine("Don hang da bi huy");
        }
    }
}
