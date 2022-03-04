using System;

namespace XacDinhSoNguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nhap a:");
            int a = int.Parse(Console.ReadLine());
            for (int i = 2; i <= a; i++)
            {
                if (a % i == 0)
                {
                    if (a == i)
                    {
                        Console.WriteLine("La SNT");
                    }
                    else
                    {
                        Console.WriteLine("Khong La SNT");
                    }
                    break;
                }

            }
        }
    }
}
