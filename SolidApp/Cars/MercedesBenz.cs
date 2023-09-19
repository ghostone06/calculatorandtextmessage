using Driver;
using Interfaces;
using Models;
using Services;
using System.Net.Mail;

namespace Cars
{
    public class MercedesBenz : BaseCar, ISendTripInfoSmsToDriver, ISendTripInfoEmailToDriver
    {
        public override double GetCostPerKM() => 2;
        public void Go()
        {
            Console.WriteLine("Car has started to move...");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped...");
        }

        public void SendTripInfoSmsToDriver(DriverInfo driver)
        {
            if (!string.IsNullOrEmpty(driver.PhoneNumber.ToString()))
            {
                var sms = new SmsSender();
                sms.SendSms(new SmsModel()
                {
                    Message = "Todays trip",
                    PhoneNumber = driver.PhoneNumber,
                    SendTime = DateTime.Now,
                });
            }
        }

        public void SendTripInfoEmailToDriver(DriverInfo driver)
        {
            if (!string.IsNullOrEmpty(driver.EmailAdress))
            {
                var mailMessage = new MailMessage();
                mailMessage.To.Add(driver.EmailAdress);

                var client = new SmtpClient("mail.mercedes.com", 587);
                client.Send(mailMessage);
            }
        }
    }
}