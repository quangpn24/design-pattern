using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Email : OTP
    {
        protected override string GetMessage(string otp)
        {
            string mess = "Email: Ma xac thuc cua ban la " + otp;
            Console.WriteLine(mess);
            return mess;
        }

        protected override void SendOTP(string mess)
        {
            Console.WriteLine("Da gui OTP thanh cong den email cua ban");
        }
    }
}
