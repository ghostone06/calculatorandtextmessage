namespace CustomExceptions
{
    public class AirPressureException : Exception
    {
        public AirPressureException(String Message, Exception InnerException) : base(Message, InnerException)
        {

        }

        public AirPressureException(String Message) : base(Message)
        {

        }
    }
}
