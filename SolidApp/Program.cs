using Cars;
using CustomExceptions;
using Driver;
using System.Net.Mail;
using System.Numerics;
using System.Xml.Linq;

partial class Program
{
    static void Main()
    {
        /*
        IAraba araba = new Mustang(2023,"Ford","Mustang");
        IAraba[] araba2 =  new Mustang[]
        {
            new Mustang(2023, "Ford", "Mustang"),
            new Mustang(2022, "Ford", "Mustang"),
        };

        IAraba[] araba4 = new Supra[]
        {
            new Supra(){Yil=2023, Marka="Toyota",Model="Supra"},
            new Supra(){Yil=2022, Marka="Toyota",Model="Supra"},

        };
        IAraba[] result = araba2.Concat(araba4).ToArray();
        foreach (var item in result)
        {
            Console.WriteLine(item.GetSpeedRoot());
        }*/

        
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

    /*
    public class Mustang : IAraba
    {
        public Mustang(int yil, string marka, string model)
        {
            Yil = yil;
            Marka = marka;
            Model = model;
        }
        public int Yil { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public int GetSpeedMustang()
        {
            return 150;
        }
    }

    public class Supra : IAraba
    {
        public int Yil { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }

        public int GetSpeedSupra()
        {
            return 150;
        }
    }

    public abstract class IAraba
    {
        public int GetSpeedRoot()
        {
            return 150;
        }
        public int Yil { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
    }*/
}