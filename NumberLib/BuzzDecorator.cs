using System.Collections.Generic;

namespace NumberLib
{
    public class BuzzDecorator : Decorator
    {
        public BuzzDecorator(IComponent component)
        {
            _component = component;
        }

        public override IEnumerable<NumberItem> GetNumbers()
        {

            foreach (var number in _component.GetNumbers())
            {
                if (number.OriginalValue % 5 == 0)
                {
                    number.Display += " Buzz";
                }

                yield return number;
            }

        }
    }
}