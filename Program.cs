using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;

            Console.Write("Choose number of rows: ");
            int z = int.Parse(Console.ReadLine());


            for (int i = 1; i <= z; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (y == 1)
                    {
                        Console.Write("0");
                        y = 0;
                    }
                    else if (y == 0)
                    {
                        Console.Write("1");
                        y = 1;
                    }
                }
                Console.Write("\n");
            }
            triangle(z);
            trianglerect(z);
            triangleSide(z);
            arrow(z);
        }
        public static void triangle(int z)
        {
            int y = 0;

            for (int i = z; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (y == 1)
                    {
                        Console.Write("0");
                        y = 0;
                    }
                    else if (y == 0)
                    {
                        Console.Write("1");
                        y = 1;
                    }
                }
                Console.Write("\n");
            }
        }
        public static void trianglerect(int z)
        {
            int y = 0;
            for (int i = 1; i <= z; i++)
            {
                for (int j = z - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int x = 1; x <= i; x++)
                {
                    if (y == 1)
                    {
                        Console.Write("0");
                        y = 0;
                    }
                    else if (y == 0)
                    {
                        Console.Write("1");
                        y = 1;
                    }
                }
                Console.Write("\n");
            }
        }
        public static void triangleSide(int z)
        {
            int y = 0;
            for (int i = z; i >= 1; i--)
            {
                for (int j = 0; j < z - i; j++)
                {
                    Console.Write(" ");
                }
                for (int x = 1; x <= i; x++)
                {
                    if (y == 1)
                    {
                        Console.Write("0");
                        y = 0;
                    }
                    else if (y == 0)
                    {
                        Console.Write("1");
                        y = 1;
                    }
                }
                Console.Write("\n");
            }
        }
        public static void arrow(int z)
        {
            int y = 0;
            for (int i = 1; i <= z; i++)
            {
                for (int j = z; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int x = 1; x <= i; x++)
                {
                    if (y == 1)
                    {
                        Console.Write("0");
                        y = 0;
                    }
                    else if (y == 0)
                    {
                        Console.Write("1");
                        y = 1;
                    }
                }
                for (int w = 1; w < i; w++)
                {
                    if (y == 1)
                    {
                        Console.Write("0");
                        y = 0;
                    }
                    else if (y == 0)
                    {
                        Console.Write("1");
                        y = 1;
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
