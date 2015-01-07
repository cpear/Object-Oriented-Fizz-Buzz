using System.Collections.Generic;

namespace NumberLib
{
    public abstract class Decorator : IComponent
    {
        protected IComponent _component;

        public abstract IEnumerable<NumberItem> GetNumbers();
    }
}