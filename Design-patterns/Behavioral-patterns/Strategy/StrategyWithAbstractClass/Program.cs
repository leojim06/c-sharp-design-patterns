using StrategyWithAbstractClass.Sort;
using System;

namespace StrategyWithAbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio de Patrón de comportamiento STRATEGY\n");

            SortedList students = new SortedList();

            students.Add("Zutano");
            students.Add("Fulano");
            students.Add("Mengano");

            students.SetSortStrategy(new QuickSort());
            students.ShowSortedList();

            students.SetSortStrategy(new MergeSort());
            students.ShowSortedList();

            students.SetSortStrategy(new ShellSort());
            students.ShowSortedList();

            Console.ReadKey();
        }
    }
}
