using Cars;

partial class Program
{
    public class FuelCostCalculator
    {
        public double Calculate(BaseCar car) => car.TripKM * car.GetCostPerKM();
    }
}