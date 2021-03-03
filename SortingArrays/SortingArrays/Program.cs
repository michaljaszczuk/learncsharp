using System;

namespace SortingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Sorting sorter = new Sorting(new int[4]);
            sorter.GetArrayItems();
            sorter.ShowArray();
            sorter.SortArray();

        }
    }
}
