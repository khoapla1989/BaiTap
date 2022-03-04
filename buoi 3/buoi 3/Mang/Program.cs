using System;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mang1 = { 2, 5, 3, 8, 38, 8, 3, 0, 5, 12 };
            //Truy xuat mang
            for (int i = 0; i < mang1.Length; i++)
            {
                Console.WriteLine(mang1[i]);
                if (mang1[i]==3)
                {
                    Console.WriteLine("vi tri cua 3: {0}",i);
                }
            }
            int tong = 0;
            for (int i = 0; i < mang1.Length; i++)
            {
                tong += mang1[i];
                //tong = tong + mang1[i];
            }
            Console.WriteLine("tong {0}", tong);


        }
    }
}
