using System.Collections.Generic;

namespace NumberLib
{
    public interface IComponent
    {
        IEnumerable<NumberItem> GetNumbers();
    }
}