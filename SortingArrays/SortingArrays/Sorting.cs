using System;
using System.Collections.Generic;
using System.Text;

namespace SortingArrays
{
    class Sorting
    {
        
        private int[] MyArray;

        public Sorting(int[] userArray)
        {

            MyArray = userArray;
        }

        public void ShowArray()
        {
            Console.WriteLine();
            foreach (var item in MyArray)
            {
                Console.WriteLine(item);
            }
        }

        public void GetArrayItems()
        {
            Console.WriteLine("Give four numbers to sort: ");
            for (int i = 0; i < MyArray.Length; i++)
            {
                string userValue = Console.ReadLine();
                int userInt;
                if (int.TryParse(userValue, out userInt))
                {
                    MyArray[i] = userInt;
                }
                
            }
            
        }

        public void SortArray()
        {
            Console.WriteLine("This is your array sorted ASC: ");
            Array.Sort(MyArray);
            ShowArray();
        }
        
    }

    
}
