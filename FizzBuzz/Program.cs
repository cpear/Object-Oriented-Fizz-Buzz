using System;
using NumberLib;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new BuzzDecorator(new FizzDecorator(new Numbers(1,20000)));

            var numberItems = numbers.GetNumbers();

            foreach (var numberItem in numberItems)
            {
                Console.WriteLine(numberItem.Display);
            }
        }
    }
}
