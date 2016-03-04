using System.Collections.Generic;

namespace NumberLib
{
    public class Numbers : IComponent
    {
        private readonly int _start;
        private readonly int _end;

        public Numbers(int start, int end)
        {
            _start = start;
            _end = end;
        }

        public IEnumerable<NumberWordPair> GetNumbers()
        {
            for (var i = _start; i <= _end; i++)
            {
                yield return new NumberWordPair() { 
                    Value = i, 
                    Word = i.ToString() 
                };
            }

        }
    }
}