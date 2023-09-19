using Cars;
using CustomExceptions;
using Driver;
using System.Net.Mail;
using System.Xml.Linq;

partial class Program
{
    static void Main()
    {
        CalculateTripCost();
        var car1 = new MercedesBenz();
        var car2 = new BMW();
        var driverInfos = new DriverInfo()
        {
            EmailAdress = "test@tes.com",
            Name = "Berk",
            PhoneNumber = 05555555555,
            Surname = "Hasan"
        };
        var driverInfosList = new List<DriverInfo>() {
           new DriverInfo()
            {
            EmailAdress = "test@tes.com",
            Name = "Berk",
            PhoneNumber = 05555555555,
            Surname = "Hasan"
        },
        new DriverInfo()
        {
            EmailAdress = "test@tes.com",
            Name = "Berk",
            PhoneNumber = 05555555555,
            Surname = "Hasan"
        }
        };
        car1.SendTripInfoEmailToDriver(driverInfos);
        car2.SendTripInfoEmailToDrivers(driverInfosList);
    }

    public static void CalculateTripCost()
    {
        var calculator = new FuelCostCalculator();
        var cost = calculator.Calculate(new Toyota());

        Console.WriteLine($"Total cost for this car is {cost} TL");
    }

    public void RunCars()
    {
        try
        {
            var driverInfos = new DriverInfo()
            {
                EmailAdress = "test@tes.com",
                Name = "Berk",
                PhoneNumber = 05555555555,
                Surname = "Hasan"
            };

            var mercedes = new MercedesBenz();
            mercedes.Go();
            mercedes.Stop();

            mercedes.SendTripInfoEmailToDriver(driverInfos);
        }
        catch (EngineStartException ex)
        {
            new GermannyLogger().Log(ex.Message);
        }

        catch (AirPressureException ex)
        {
            new LocalStorageLogger().Log(ex.Message);
        }
        catch (Exception ex)
        {
            new LocalServerLogger().Log(ex.Message);
        }
    }
}