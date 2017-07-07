using System.Collections.Generic;

namespace NumberLib
{
    public class FizzDecorator : Decorator
    {
        public FizzDecorator(Decorator component)
        {
            Component = component;
        }

        public override IEnumerable<NumberWordPair> GetNumbers()
        {

            foreach (var number in Component.GetNumbers())
            {
                if (number.Value % 3 == 0)
                {
                    number.Word += " Fizz";
                }

                yield return number;
            }
          
        }
    }
}