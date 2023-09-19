using Driver;
using Models;
using Services;
using System.Net.Mail;

namespace Cars
{
    public abstract class BaseCar
    {
        public int TripKM { get; set; } = 5;
        public abstract double GetCostPerKM();
    }

}