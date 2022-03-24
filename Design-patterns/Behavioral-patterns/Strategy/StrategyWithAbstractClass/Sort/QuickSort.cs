using System;
using System.Collections.Generic;

namespace StrategyWithAbstractClass.Sort
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
        }
    }
}
