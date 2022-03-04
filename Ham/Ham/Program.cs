using System;

namespace Ham
{
    class Program
    {
        static void Main(string[] args)
        {
            //XinChao();
            //XinChao("Ng Van A");
            //XinChao("Ng Van A", 18);
            //string hoten = NhapTen();
            //XinChao(hoten);
            //Console.WriteLine("Nhap so nguyen:");
            //int a = NhapSoNguyen("Nhap so nguyen a:");
            //int b = NhapSoNguyen("Nhap so nguyen b:");
            Menu();
        }

        private static void Menu()
        {
            //Console.Clear();
            Console.WriteLine("====== Menu ======");
            Console.WriteLine("1. Giai PTB1");
            Console.WriteLine("2. Giai PTB2");
            Console.WriteLine("3. Tim UCLN"); ;
            Console.WriteLine("4. Tinh N!");
            Console.WriteLine("exit. Thoat");
            Console.WriteLine("Chon : ");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    GiaiPTB1();
                    break;
                case "2":
                    GiaiPTB2();
                    break;
                case "3":
                    UCLN();
                    break;
                case "4":
                    NGiaiThua();
                    break;
                case "exit":
                    return;
            }
            Menu();
        }

        private static void NGiaiThua()
        {
            int GT = 1;
            Console.WriteLine("goi n:");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                GT = GT * i;
            }
            Console.WriteLine("{1}! = {0}", GT, N);

        }

        private static void UCLN()
        {
            try
            {
                int a = NhapSoNguyen("Nhap So Nguyen Duong a:", true);
                int b = NhapSoNguyen("Nhap So Nguyen Duong b:", true);

                while (a * b > 0)
                {
                    if (a > b)
                    {
                        a = a % b;
                    }
                    else
                    {
                        b = b % a;
                    }
                }
                Console.WriteLine("UCLN la : {0}", a + b);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int NhapSoNguyen(string title = "", bool laNguyenDuong = false)
        {
            try
            {
                if (title != "")
                {
                    Console.WriteLine(title);
                }
                int a = int.Parse(Console.ReadLine());
                if (laNguyenDuong == true)
                    if (a <= 0)
                    {
                        throw new Exception("So Am");
                    }
                return a;
            }
            catch (Exception ex)
            {
                return NhapSoNguyen(title,laNguyenDuong);
            }
        }

        private static void GiaiPTB2()
        {
            try
            {
                double a = NhapSo("Nhap So a:");
                double b = NhapSo("Nhap So b:");
                double c = NhapSo("Nhap So c:");
                if (a == 0)
                {
                    //Console.WriteLine("PTB1");
                    //return;
                    //throw new Exception("PTB1");
                    PhuongTrinhBac1(b, c);
                    return;
                }
                double detal = Math.Pow(b, 2) - 4 * a * c;
                if (detal < 0)
                {
                    throw new Exception("PT VN");
                }
                double x1 = (-b + Math.Sqrt(detal)) / (2 * a);
                double x2 = (-b - Math.Sqrt(detal)) / (2 * a);
                Console.WriteLine("Nghiem 1 {0}", x1);
                Console.WriteLine("Nghiem 2 {0}", x2);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void GiaiPTB1()
        {
            try
            {
                double a = NhapSo("Nhap So a:");
                double b = NhapSo("Nhap So b:");
                PhuongTrinhBac1(a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void PhuongTrinhBac1(double a, double b)
        {
            if (a == 0)
                if (b == 0)
                    throw new Exception("PTVSN");
                else
                    throw new Exception("PTVN");
            Console.WriteLine("Nghiem cua PT la {0:F2}", -b / a);
        }

        private static double NhapSo(string title)
        {
            try
            {
                if (title != "")
                {
                    Console.WriteLine(title);
                }
                int a = int.Parse(Console.ReadLine());
                return a;
            }
            catch (Exception)
            {
                return NhapSo(title);
            }
        }

        private static int NhapSoNguyen(string title = "")
        {
            try
            {
                if (title != "")
                {
                    Console.WriteLine(title);
                }
                int a = int.Parse(Console.ReadLine());
                return a;
            }
            catch (Exception)
            {
                return NhapSoNguyen(title);
            }
        }

        private static string NhapTen()
        {
            Console.WriteLine("Nhap Ten:");
            return Console.ReadLine();
        }

        private static void XinChao(string ten, int tuoi)
        {
            Console.WriteLine("Xin Chao {0}, {1}", ten, tuoi);
        }

        private static void XinChao(string v)
        {
            Console.WriteLine("Xin Chao {0}", v);
        }

        private static void XinChao()
        {
            Console.WriteLine("Xin Chao");

        }
    }
}
