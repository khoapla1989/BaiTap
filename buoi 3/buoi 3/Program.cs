using System;

namespace buoi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Xin Chao");
            }
            #region Tinh 5 Giai Thua
            int GiaiThua = 1;
            for (int i = 1; i <= 5; i++)
            {
                GiaiThua = GiaiThua * i;
            }
            Console.WriteLine("5! = {0}", GiaiThua);
            #endregion

            #region Tinh N Giai Thua
            int GT = 1; 
            Console.WriteLine("goi n:");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                GT = GT * i;
            }
            Console.WriteLine("{1}! = {0}", GT, N);

            #endregion

        }
    }
}
