using Models;

namespace Services
{
    public class SmsSender
    {
        public SmsSender() { }

        public void SendSms(SmsModel smsModel)
        {
            var message = (smsModel.PhoneNumber.HasValue || smsModel.SendTime.HasValue || smsModel.Message.Length > 0) ? "Sms sent..!" : "Sms service fail";
            Console.WriteLine($"Sms Message: {message}");
        }
    }
}