using System;
using System.Collections.Generic;

namespace StrategyWithAbstractClass.Sort
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); // Implementar otro tipo de ordenamiento
        }
    }
}
