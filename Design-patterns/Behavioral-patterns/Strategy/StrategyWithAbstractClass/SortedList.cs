using StrategyWithAbstractClass.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyWithAbstractClass
{
    public class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortStrategy = null;

        public void SetSortStrategy(SortStrategy strategy)
        {
            _sortStrategy = strategy;
        }
        
        public void Add(string item)
        {
            _list.Add(item);
        }

        public void ShowSortedList()
        {
            if(_sortStrategy == null)
                throw new Exception("Set a stategy before start to sort the list");

            _sortStrategy.Sort(_list);
            Console.WriteLine(_sortStrategy.ToString());
            foreach (var item in _list)
            {
                Console.WriteLine(" " + item);
            }
            Console.WriteLine();
        }
    }
}
