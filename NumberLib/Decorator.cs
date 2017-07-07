using System.Collections.Generic;

namespace NumberLib
{
    public abstract class Decorator
    {
        protected Decorator Component;

        public abstract IEnumerable<NumberWordPair> GetNumbers();
    }
}