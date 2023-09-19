using SingletonApp.Interfaces;

namespace SingletonApp
{
    public class TransientRandomNumberGenerator : ITransientRandomNumberGenerator
    {
        public int TransientRandomNumber { get; }
        public TransientRandomNumberGenerator()
        {
            Random rand = new Random();
            TransientRandomNumber = rand.Next(500);
        }

    }
}
