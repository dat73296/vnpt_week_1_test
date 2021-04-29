using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktra2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            Console.WriteLine("Nhap vao cac so lieu");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0},{1},{2}", a, b, c);
            Console.ReadKey();
            int[,] mang1 = new int[a, b];
            int[,] mang2 = new int[a, c];
            int i, j;
            for (i = 0; i < mang1.GetLength(0); i++)
            {
                for (j = 0; j < mang1.GetLength(1); j++)
                {
                    Console.Write(" Moi ban nhap phan tu Mang 1 [{0}, {1}] = ", i, j);
                    mang1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < mang2.GetLength(0); i++)
            {
                for (j = 0; j < mang2.GetLength(1); j++)
                {
                    Console.Write(" Moi ban nhap phan tu Mang 2 [{0}, {1}] = ", i, j);
                    mang2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Mang 1 ban vua nhap la: ");
            for (i = 0; i < mang1.GetLength(0); i++)
            {
                for (j = 0; j < mang1.GetLength(1); j++)
                {
                    Console.Write(mang1[i, j] + " ");

                }
                Console.WriteLine();

            }
            Console.WriteLine("\n Mang 2 ban vua nhap la: ");
            for (i = 0; i < mang2.GetLength(0); i++)
            {
                for (j = 0; j < mang2.GetLength(1); j++)
                {
                    Console.Write(mang2[i, j] + " ");

                }
                Console.WriteLine();
            }
            for (i = 0; i < mang2.GetLength(0); i++)
            {
                for (j = 0; j < mang2.GetLength(1); j++)
                {
                    if (mang1[i, 0] != 1 && mang1[0,j]!=0)
                        Console.WriteLine("Ban nhap sai yeu cau bai toan");
                }
            }
            //        int x = 0, y = 0;
            ////
            //for (i = 0; i < mang1.GetLength(0); i++)
            //{
            //    for (j = 0; j < mang1.GetLength(1); j++)
            //    {
            //        if (mang1[i, j] == 0)
            //        {
            //            x = i;
            //            y = j;
            //            break;
            //        }
            //    }

            //}


            //int[,] mes = new int[a, x];

            //for (i = x; i < mang1.GetLength(0); i--)
            //{
            //    for (j = y; j < mang1.GetLength(1); j--)
            //    {
            //        mes[i, j] = mang1[i, j] + mang2[i, j];
            //    }
            //}
            //for (i = x; i < mang1.GetLength(0); i--)
            //{
            //    for (j = y; j < mang1.GetLength(1); j--)
            //    {
            //        Console.Write("{0}\t", mes[i, j]);
            //    }

            //    Console.WriteLine(x);
            //    Console.WriteLine(y);
                Console.ReadKey();
            }
        }
    }