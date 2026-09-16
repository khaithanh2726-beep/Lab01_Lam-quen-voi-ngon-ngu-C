using System;

namespace Bai07
{
    class KiemTra
    {
        //Ktr so nguyen to
        public bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KiemTra kt = new KiemTra();
            int n = 7;
            Console.WriteLine($"{n} co phai la SNT? {kt.LaSoNguyenTo(n)}");
            Console.ReadKey();
        }
    }
}