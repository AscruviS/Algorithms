using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] array= program.GeneratorArray(1000);
            int ansewer = program.RecursiveLinearSearch(array,8));
            Console.Read();
        }

        string RecursiveLinearSearch(int[] array, int x, int i = 1)
        {
            if (i > array.Length) { return "Not Found"; }
            else if (array[i] == x) { return $"{i}"; }
            else{return RecursiveLinearSearch(array, x, i+1); }
        }

        int[] GeneratorArray(int length)
        {
            Random rnd = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(1, 101);
            }
            return array;
        }
    }
}
