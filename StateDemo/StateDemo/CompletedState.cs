using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDemo
{
    class CompletedState :IOrderState
    {

        public void cancel()
        {
            //Xử lý hủy đơn hàng
            Console.WriteLine("Khong the huy don hang da thanh cong");
        }

        public void confirmOrder()
        {
            //Xủ lý xác nhận đơn hàng
            Console.WriteLine("Don hang da duoc giao roi");
        }
        public void ship()
        {
            //Xử lý vận chuyển đơn
            Console.WriteLine("Don hang da duoc giao roi");
        }

        public void deliver()
        {
            //Xử lý giao đơn hàng
            Console.WriteLine("Don hang da duoc giao roi");
        }
    }
}
