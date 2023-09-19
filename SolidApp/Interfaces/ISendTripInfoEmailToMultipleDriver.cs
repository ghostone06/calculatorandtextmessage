using Driver;

namespace Interfaces
{
    public interface ISendTripInfoEmailToMultipleDriver
    {
        void SendTripInfoEmailToDrivers(List<DriverInfo> drivers);
    }
}
