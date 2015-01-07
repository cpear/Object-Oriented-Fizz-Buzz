using System.Collections.Generic;

namespace NumberLib
{
    public class FizzDecorator : Decorator
    {
        public FizzDecorator(IComponent component)
        {
            _component = component;
        }

        public override IEnumerable<NumberItem> GetNumbers()
        {

            foreach (var number in _component.GetNumbers())
            {
                if (number.OriginalValue % 3 == 0)
                {
                    number.Display += " Fizz";
                }

                yield return number;
            }
          
        }
    }
}