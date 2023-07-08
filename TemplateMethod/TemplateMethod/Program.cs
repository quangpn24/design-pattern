// See https://aka.ms/new-console-template for more information
using TemplateMethod;
Console.WriteLine("***Qua trinh gui OTP den dien thoai***");
OTP sms = new SMS();
sms.GenerateAndSendOTP();

Console.WriteLine("\n\n***Qua trinh gui OTP den email***");
OTP email = new Email();
email.GenerateAndSendOTP();
