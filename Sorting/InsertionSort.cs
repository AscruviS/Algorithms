using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] array;
            array = program.GeneratorArray(10, 100);
            array = program.InsertionSort(array);
            Console.Read();
        }
        int[] InsertionSort(int[] array)
        {
            int key;
            int j;
            for (int i = 1; i < array.Length; i++)
            {
                key = array[i];
                j = i - 1;
                while(j > (-1) && array[j] > key)
                {
                    array[j+1] = array[j];
                    j--;
                }
                array[j+1] = key;
            }
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
