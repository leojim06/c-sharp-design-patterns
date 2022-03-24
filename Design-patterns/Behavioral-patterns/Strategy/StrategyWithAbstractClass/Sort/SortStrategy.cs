using System.Collections.Generic;

namespace StrategyWithAbstractClass.Sort
{
    public abstract class SortStrategy
    {
        public override string ToString()
        {
            return this.GetType().Name;
        }
        public abstract void Sort(List<string> list);
    }
}
