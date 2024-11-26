using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            int lenght = 100;
            int MaxValue = 100;
            int[] array = pr.GeneratorArray(lenght, MaxValue);
            array = pr.SelectionSort(array);
            Console.Read();
        }

        int[] SelectionSort(int[] array)
        {
            int indexSmallest;
            for (int i = 0; i < array.Length - 1; i++)
            {
                indexSmallest = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[indexSmallest]) {indexSmallest = j;}
                }
                array = Exchange(array, i, indexSmallest);
            }
            return array;
        }

        int[] Exchange(int[] array, int indexInsert, int indexCopy)
        {
            int oldElement = array[indexInsert];
            array[indexInsert] = array[indexCopy];
            array[indexCopy] = oldElement;
            return array;
        }

        int[] GeneratorArray(int lenght, int MaxValue)
        {
            int[] array = new int[lenght];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, MaxValue + 1);
            }
            return array;
        }
    }
}
