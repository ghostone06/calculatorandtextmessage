using Driver;
using Interfaces;
using Models;
using Services;
using System.Net.Mail;

namespace Cars
{
    public class BMW : BaseCar, ISendTripInfoEmailToDriver, ISendTripInfoEmailToMultipleDriver
    {
        public override double GetCostPerKM() => 1.5;
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

        public void SendTripInfoEmailToDrivers(List<DriverInfo> drivers)
        {
            foreach (var driver in drivers)
            {
                SendTripInfoEmailToDriver(driver);
            }
        }
    }

}