using System;
using NumberLib;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicFizzBuzz();
        }

        private static void ClassicFizzBuzz()
        {
            var wordValuePairGenerator = new BuzzDecorator(new FizzDecorator(new Numbers(1, 20000)));

            var wordValuePairs = wordValuePairGenerator.GetNumbers();

            foreach (var wordValue in wordValuePairs)
            {
                Console.WriteLine(wordValue.Word);
            }
        }
    }
}
