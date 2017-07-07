using System.Collections.Generic;

namespace NumberLib
{
    public class BuzzDecorator : Decorator
    {
        public BuzzDecorator(Decorator component)
        {
            Component = component;
        }

        public override IEnumerable<NumberWordPair> GetNumbers()
        {

            foreach (var number in Component.GetNumbers())
            {
                if (number.Value % 5 == 0)
                {
                    number.Word += " Buzz";
                }

                yield return number;
            }

        }
    }
}