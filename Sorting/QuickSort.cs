using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            int[] nums = pr.GeneratorArray(10, 100);
            nums = pr.QuickSort(nums, 0, nums.Length - 1);
            Console.Read();
        }

        int[] QuickSort(int[] nums, int p, int r)
        {
            if (p >= r) { return nums; }
            int q = Partitation(nums, p, r);
            nums = QuickSort(nums, p, q-1);
            nums = QuickSort(nums, q+1, r);
            return nums;
        }

        int Partitation(int[] array, int p, int r)
        {
            int q = p;
            for (int u = p; u <= r - 1; u++)
            {
                if (array[u] < array[r]) { Exchange(array, q, u); q++; }
            }
            Exchange(array, q, r);
            return q;
        }

        int[] Exchange(int[] numbers, int index1, int index2)
        {
            int oldValue = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = oldValue;
            return numbers;
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
