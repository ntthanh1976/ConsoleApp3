using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        struct DIEM
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            DIEM A, B;
            Console.WriteLine("Nhap diem a:");
            NhapToaDo(out A);

            Console.WriteLine("Nhap diem b:");
            NhapToaDo(out B);

            double kq = Math.Sqrt((B.x - A.x) * (B.x - A.x) + (B.y - A.y) * (B.y - A.y));

            Console.WriteLine("Khoang cach 2 diem A({0},{1}) - B({2},{3})  = {4}",
                A.x, A.y, B.x, B.y, kq);

            Console.ReadLine();

            int x = 5;
            int y = 10;
                  

        }

        static void NhapToaDo(out DIEM p)
        {
            Console.Write("Nhap toa do x:");
            p.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap toa do y:");
            p.y = Convert.ToInt32(Console.ReadLine());
        }

    }
}
