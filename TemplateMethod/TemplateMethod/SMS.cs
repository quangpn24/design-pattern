using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class SMS :OTP
    {
        protected override string GetMessage(string otp)
        {
            string mess = "SMS: Ma xac thuc cua ban la " + otp;
            Console.WriteLine(mess);
            return mess;
        }

        protected override void SendOTP(string mess)
        {
            //hande send otp
            Console.WriteLine("Da gui OTP thanh cong den dien thoai cua ban.");
        }
    }
}
