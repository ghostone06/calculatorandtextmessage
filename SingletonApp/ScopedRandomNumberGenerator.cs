using SingletonApp.Interfaces;

namespace SingletonApp
{
    public class ScopedRandomNumberGenerator : IScopedRandomNumberGenerator
    {
        public int ScopedRandomNumber { get; }
        public ScopedRandomNumberGenerator()
        {
            Random rand = new Random();
            ScopedRandomNumber = rand.Next(500);
        }

    }
}
