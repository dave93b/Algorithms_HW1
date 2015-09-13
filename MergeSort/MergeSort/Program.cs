using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = {4,0,6,2,1};
            int[] arrayB = {9,5,8,7,3};

            int arrayALength = arrayA.Length;
            int arrayBLength = arrayB.Length;

            BubbleSortForSubArrays(ref arrayA);
            BubbleSortForSubArrays(ref arrayB);

            int[] resultArray = new int[10];
            int i = 0, j = 0, k = 0;

            while (i < arrayALength && j < arrayBLength)
            {
                if (arrayA[i] < arrayB[j])
                {
                    resultArray[k] = arrayA[i];
                    i++;
                    k++;
                }
                else
                {
                    resultArray[k] = arrayB[j];
                    j++;
                    k++;
                }
            }

            for (int l = i; l < arrayALength; l++)
            {
                resultArray[k++] = arrayA[l];
            }

            for (int l = j; l < arrayBLength; l++)
            {
                resultArray[k++] = arrayB[l];
            }

            foreach (var num in resultArray)
            {
                Console.WriteLine(num);
            }
            
            Console.ReadLine();
        }

        static void BubbleSortForSubArrays(ref int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length-1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
