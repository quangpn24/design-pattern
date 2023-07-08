using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class OTP
    {
        public void GenerateAndSendOTP()
        {
            string otp = CreateOTP();
            SaveOTP(otp);
            string message = GetMessage(otp);
            SendOTP(message);
        }
        protected string CreateOTP()
        {
            string otp = "ABCDEF";
            Console.WriteLine("OTP da duoc tao:" + otp);
            return otp;
        }
        protected void SaveOTP(string otp)
        {
            Console.WriteLine("Da luu vao OTP cache");
        }
        protected abstract string GetMessage(string otp);
        protected abstract void SendOTP(string mess);
    }
}
