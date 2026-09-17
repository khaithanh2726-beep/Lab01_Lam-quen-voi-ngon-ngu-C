using System;

namespace Bai17
{
    public class Program
    {
        public static void Input(int[,] arr) //Tao mang (YC1)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(10, 101);
                }
            }
        }
        pblic static void Output(int[,] arr) //In mang (YC2)
        {
            Console.WriteLine("Mảng vừa sinh là:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void GetEvenOdd(int[,] arr, out int[] even, out int[] odd) //In mang chan va mang le  (YC3)
        {
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < arr.GetLength(0); i++) //Ktr chan le
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }
            }
            even = new int[evenCount];
            odd = new int[oddCount];
            int evenIndex = 0;
            int oddIndex = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        even[evenIndex] = arr[i, j];
                        evenIndex++;
                    }
                    else
                    {
                        odd[oddIndex] = arr[i, j];
                        oddIndex++;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Nhap so dong n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] A = new int[n, m];
            Input(A);
            Output(A);
            GetEvenOdd(A, out int[] even, out int[] odd);
            Console.Write("\nMang so chan: ");
            for (int i = 0; i < even.Length; i++)
            {
                Console.Write(even[i] + " ");
            }
            Console.Write("\nMang so le: ");
            for (int i = 0; i < odd.Length; i++)
            {
                Console.Write(odd[i] + " ");
            }
        }
    }
}