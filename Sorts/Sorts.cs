using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public static class MergeSort
    {
        public static void Sort(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException("Object cannot be null");
            int[] sortArray = new int[array.Length];
            array.CopyTo(sortArray, 0);
            SortLogics(array, sortArray, 0, array.Length - 1);
        }
        public static void Sort(int[] array, int left, int right)
        {
            if (array == null)
                throw new ArgumentNullException("Object cannot be null");
            if (left < 0 || left > right || right > array.Length - 1)
                throw new ArgumentOutOfRangeException("Invalid Parametrs");
            int[] sortArray = new int[array.Length];
            array.CopyTo(sortArray, 0);
            SortLogics(array, sortArray, left, right);
        }
        private static void SortLogics(int[] array, int[] sortArray, int left, int right)
        {
            int middle = (left + right) / 2;
            if ((right - left) < 1) return;
            SortLogics(array, sortArray, left, middle);
            SortLogics(array, sortArray, middle + 1, right);

            int leftOne = left, leftTwo = middle + 1, index = left, lengthOne = middle - leftOne + 1, lengthTwo = right - leftTwo + 1;

            while (lengthOne != 0 && lengthTwo != 0)
            {
                if (array[leftOne] < array[leftTwo])
                {
                    sortArray[index++] = array[leftOne++];
                    lengthOne--;
                }
                else if (array[leftOne] > array[leftTwo])
                {
                    sortArray[index++] = array[leftTwo++];
                    lengthTwo--;
                }
                else
                {
                    sortArray[index++] = array[leftOne++];
                    sortArray[index++] = array[leftTwo++];
                    lengthOne--;
                    lengthTwo--;
                }
            }

            int leftBorder = leftTwo, generalLength = lengthTwo;
            if (lengthTwo == 0)
            {
                leftBorder = leftOne;
                generalLength = lengthOne;
            }
            while (generalLength != 0)
            {
                sortArray[index++] = array[leftBorder++];
                generalLength--;
            }

            for (int i = left; i <= right; i++)
                array[i] = sortArray[i];
        }
    }

    public static class QSort
    {
        public static void Sort(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException("Object cannot be null");
            QSortLogics(array, 0, array.Length - 1);
        }
        public static void Sort(int[] array, int left, int right)
        {
            if (array == null)
                throw new ArgumentNullException("Object cannot be null");
            if (left < 0 || left > right || right > array.Length - 1)
                throw new ArgumentOutOfRangeException("Invalid Parametrs");
            QSortLogics(array, left, right);
        }
        private static void QSortLogics(int[] array, int start, int end)
        {
            if ((end - start) > 0)
            {
                int[] borders = Division(array, start, end);
                QSortLogics(array, start, borders[1]);
                QSortLogics(array, borders[0], end);
            }
        }
        private static int[] Division(int[] array, int start, int end)
        {

            int left = start, right = end, middle = array[(left + right) / 2];
            while ((right - left) >= 0)
            {
                while (array[left] < middle) left++;
                while (array[right] > middle) right--;
                if ((left - right) <= 0)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left++;
                    right--;
                }
            }
            return new int[] { left, right };
        }
    }
}
