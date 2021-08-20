using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList bmkFamilyRecord = new SortedList();

            bmkFamilyRecord.Add("Bakht munir");
            bmkFamilyRecord.Add("Afzal munir");
            bmkFamilyRecord.Add("Hunain");
            bmkFamilyRecord.Add("Husnain");
            bmkFamilyRecord.Add("Zernain");

            bmkFamilyRecord.SetSortStrategy(new QuickSort());
            bmkFamilyRecord.Sort();

            bmkFamilyRecord.SetSortStrategy(new ShellSort());
            bmkFamilyRecord.Sort();

            bmkFamilyRecord.SetSortStrategy(new MergeSort());
            bmkFamilyRecord.Sort();



        }
    }


    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }

    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("this is quick sort list");
        }
    }

    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("this is shell sort list");
        }
    }

    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("this is merge sort list");
        }
    }

    public class SortedList
    {
        private List<string> list = new List<string>();
        private SortStrategy sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void Sort()
        {
            sortStrategy.Sort(list);
            foreach (string name in list)
            {
                Console.WriteLine(" " + name);

            }
        }

        public void Add(string name)
        {
            list.Add(name);
        }
        
    }
}
