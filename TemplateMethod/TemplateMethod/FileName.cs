using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
     class SMS1
    {
        public void GenAndSendOTP()
        {
            //create otp
            string otp = "ABCDEF";
            Console.WriteLine("OTP da duoc tao:" + otp);
            //save otp
            Console.WriteLine("Da luu vao OTP cache");
            //get mess
            string mess = "SMS: Ma xac thuc cua ban la " + otp;
            Console.WriteLine(mess);
            //send otp
            Console.WriteLine("Da gui OTP thanh cong den dien thoai cua ban");
        }
      }
    }
}
