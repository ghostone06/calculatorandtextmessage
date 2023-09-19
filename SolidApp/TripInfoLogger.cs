namespace Cars
{
    public class TripInfoLogger
    {
        private readonly ILogger _logger;
        public TripInfoLogger(ILogger logger)
        {
            _logger = logger;
        }
        public void Log(string logInfo)
        {
            _logger.Log(logInfo);
        }
    }

    public interface ILogger
    {
        void Log(string logInfo);
    }

    public class LocalServerLogger: ILogger
    {
        public void Log(string logStr)
        {
            //Send the date to Germany
        }
    }

    public class GermannyLogger : ILogger
    {
        public void Log(string logStr)
        {
            //Send the date to Germany
        }
    }

    public class LocalStorageLogger : ILogger
    {
        public void Log(string logStr)
        {
            //Send the date to Germany
        }
    }
}