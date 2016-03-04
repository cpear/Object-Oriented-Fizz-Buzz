using System.Collections.Generic;

namespace NumberLib
{
    public class FizzDecorator : Decorator
    {
        public FizzDecorator(IComponent component)
        {
            _component = component;
        }

        public override IEnumerable<NumberWordPair> GetNumbers()
        {

            foreach (var number in _component.GetNumbers())
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