using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace UsingCallback
{
    delegate int Compare<T>(T a, T b);

    class Program
    {
        static int AscendCompare<T>(T a, T b) where T :IComparable<T>
        {
            return a.CompareTo(b);
        }
        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b)*-1;
        }
        static void BubleSort<T>(T[] DataSet, Compare<T> Comparer)
        { 
            int i =0, j = 0;
            T temp;
            for ( i = 0; i < DataSet.Length-1; i++)
            {
                for (j = 0; j < DataSet.Length-(i+1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j];
                        DataSet[j] = DataSet[j + 1];
                        DataSet[j + 1] = temp;
                    
                    }
                }

            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubleSort(array, new Compare<int>(AscendCompare));
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            int[] array2 = { 3, 7, 4, 2, 10 };
            Console.WriteLine("Sorting Descending...");
            BubleSort(array, new Compare<int>(DescendCompare));
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
