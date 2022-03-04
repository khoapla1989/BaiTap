using System;

namespace SapXepMang
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] mang1 = { 2, 5, 3, 8, 38, 8, 3, 0, 5, 12 };
            int min;
            //duyet mang
            for (int i = 0; i < mang1.Length; i++)
            {
                min = i;
                //tim vi tri phan tu nho nhat
                for (int j = i; j < mang1.Length; j++)
                {
                    if (mang1[min] > mang1[j])
                    {
                        min = j;
                    }
                }
                //hoan doi vi tri
                int a = mang1[i];
                mang1[i] = mang1[min];
                mang1[min] = a;
            }
            //xuat mang
            for (int i = 0; i < mang1.Length; i++)
            {
                Console.WriteLine(mang1[i]);
            }
        }
    }
}
