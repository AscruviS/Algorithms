using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            int[] array = pr.GeneratorSortArray(1000, 1000);
            pr.PrintArray(array);
            Console.WriteLine(" ");
            Console.Write(pr.BinarySearch(array, 505));
            Console.ReadLine();
        }

        int BinarySearch(int[] array, int value)
        {
            int index = array.Length / 2;
            int start = 0;
            int final = array.Length - 1;
            while (array[index] != value) 
            {
                if (array[index] > value){final = index;}
                else if (array[index] < value) { start = index;}
                int oldIndex = index;
                index = (start + final) / 2;
                if (oldIndex == index) { Console.WriteLine("Not Found."); index = 404; Console.Write($"Error "); return index; ; }
            }
            Console.Write("Ansewer: ");
            return index;
        }
        int[] GeneratorSortArray(int lenght, int MaxValue)
        {
            int[] array = new int[lenght];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, MaxValue + 1);
            }
            Array.Sort(array);
            return array;
        }
        void PrintArray(int[] array) { foreach (int item in array) { Console.Write($"{item} "); } }
    }
}
