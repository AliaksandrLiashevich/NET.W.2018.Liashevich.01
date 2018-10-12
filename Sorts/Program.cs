using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorts;

namespace Sorts.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестирование MergeSort");
            int[] arrayOne = new int[] { 5, -10, 15, 20, 50, 1, 0, 0, -3, -20, 100 };
            MergeSort.Sort(arrayOne);
            if (Check(arrayOne, 0, arrayOne.Length - 1)) 
                Console.WriteLine("Полная сортировка\n");
            Print(arrayOne);
            
            int[] arrayTwo = new int[] { 80, -20 , 25, 5};
            MergeSort.Sort(arrayTwo, 0, 1);
            if (Check(arrayOne, 0, 1))
                Console.WriteLine("Частичная сортировка\n");
            Print(arrayTwo);

            int[] arrayThree = { 50 };
            MergeSort.Sort(arrayThree);
            Console.WriteLine("Обработка массива из одного элемента\n");
            Print(arrayThree);

            Console.WriteLine("Тестирование QSort");
            int[] arrayFour = new int[] { 15, -100, 15, 12, 25, 1, -3, 0, -8, -20, 63 };
            QSort.Sort(arrayFour);
            if (Check(arrayFour, 0, arrayFour.Length - 1))
                Console.WriteLine("Полная сортировка\n");
            Print(arrayFour);

            int[] arrayFive = new int[] { 0, -1, 15, 19 };
            QSort.Sort(arrayFive, 0, 1);
            if (Check(arrayFive, 0, 1))
                Console.WriteLine("Частичная сортировка\n");
            Print(arrayFive);

            int[] arraySix = { 10 };
            QSort.Sort(arraySix);
            Console.WriteLine("Обработка массива из одного элемента\n");
            Print(arraySix);
            Console.ReadKey();
        }
        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + "  ");
            Console.Write("\n\n");
        }
        static bool Check(int[] array, int left, int right)
        {
            for (int i = left; i < (right - 1) ; i++)
                if (array[i] > array[i + 1])
                    return false;
            return true;
        }
    }
}