using System;

namespace Atcoder0108_D
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNK = Console.ReadLine().Split(' ');
            string[] inputNumbers = Console.ReadLine().Split(' ');

            int N = int.Parse(inputNK[0]);  //最大値
            int K = int.Parse(inputNK[1]);　//Kth

            for (int i = K; i <= N; i++)
            {
                Console.WriteLine(checkNth(inputNumbers, i, K));
            }

        }
        static int checkNth(string[] numbers, int max, int K)
        {
            int[] newArray = new int[max];
            for (int i = 0; i < max; i++) newArray[i] = int.Parse(numbers[i]);

            Array.Sort(newArray);
            Array.Reverse(newArray);

            return newArray[K - 1];

        }
    }
}
