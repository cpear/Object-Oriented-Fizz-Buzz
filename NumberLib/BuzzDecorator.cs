using System.Collections.Generic;

namespace NumberLib
{
    public class BuzzDecorator : Decorator
    {
        public BuzzDecorator(IComponent component)
        {
            _component = component;
        }

        public override IEnumerable<NumberWordPair> GetNumbers()
        {

            foreach (var number in _component.GetNumbers())
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