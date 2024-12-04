using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            int[] array = pr.GeneratorArray(100, 10000);
            array = pr.MergeSort(array, 0, array.Length - 1);
            Console.Read();
        }

        int[] MergeSort(int[] array, int p, int r)
        {
            int q = (p + r) / 2;
            if(p >= r) { return array; }
            array = MergeSort(array, p, q);
            array = MergeSort(array, q + 1, r);
            array = Merge(array, p, q, r);
            return array;
            
        }

        int[] Merge(int[] array, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;
            int i = 0;
            int j = 0;
            int[] B = new int[n1 + 1];
            int[] C = new int[n2 + 1];
            for (int k = p; k <= q; k++) { B[j] = array[k]; j++; }
            j = 0;
            for (int k = q + 1; k <= r; k++) { C[j] = array[k]; j++; }
            B[n1] = int.MaxValue;
            C[n2] = int.MaxValue;
            i = 0; j = 0;
            for (int k = p; k <= r; k++)
            {
                if (B[i] <= C[j]) { array[k] = B[i]; i++; }
                else { array[k] = C[j]; j++; }
            }
            return array;
        }

        int[] GeneratorArray(int length, int MaxValue)
        {
            Random rnd = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(1, MaxValue + 1);
            }
            return array;
        }
    }
}
