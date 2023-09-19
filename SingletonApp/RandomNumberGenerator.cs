using SingletonApp.Interfaces;
using System;
using System.Collections.Generic;

namespace SingletonApp
{
    public class RandomNumberGenerator: IRandomNumberGenerator
    {
        public int SingletonRandomNumber { get; }
        public RandomNumberGenerator()
        {
            Random rand = new Random();
            SingletonRandomNumber = rand.Next(500);
        }

    }
}
