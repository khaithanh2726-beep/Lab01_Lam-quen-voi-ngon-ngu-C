using System;

namespace Bai08
{
    class XuLy
    {
        //Hoan vi 
        public void HoanVi(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            XuLy xl = new XuLy();
            double x = 1.5, y = 4.8;
            xl.HoanVi(ref x, ref y);
            Console.WriteLine($"Sau khi hoan vi: x = {x}, y = {y}");
            Console.ReadKey();
        }
    }
}