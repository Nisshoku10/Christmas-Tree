using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 16; i++) 
            {
                for (int j = 0; j < 17; j++) 
                {
                    // Upper Half
                    if (i == 0)
                    {
                        if (j == 17 / 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    if (i == 1) 
                    {
                        if (j == 17 / 2 - i || j == 17/2 + i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    if (i == 2)
                    {
                        if (j == 17 / 2 - i || j == 17 / 2 + i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    if (i == 3)
                    {
                        if (j == 17 / 2 - i || j == 17 / 2 + i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    //Splitter of upper and lower half
                    if (i == 4 || i == 6)
                    {
                        if (j == 17 / 2 - 4 || j == 17 / 2 + 4)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    if (i == 5 || i == 7)
                    {
                        if (j == 17 / 2 - 5 || j == 17 / 2 + 5)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    // Lower half

                    if (i == 8)
                    {
                        if (j == (9 / 2) - 2 || j == (18 / 2) + 5)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    if (i == 9)
                    {
                        if (j == (7 / 2) - 2 || j == (21 / 2) + 5)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    if (i == 10)
                    {
                        if ((j >= 0 && j < 6) || (j > 10 && j < 17))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    //Stem
                    if (i == 11 || i == 12 || i == 13)
                    {
                        if (j == 11/2 || j == 23 / 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                        Console.Write(" "); 
                        }
                    }
                    //Vase
                    if (i == 14)
                    {
                        if (j >= 9 / 2 && j <= 25 / 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    if (i == 15)
                    {
                        if (j >= 11 / 2 && j <= 23 / 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    if (i == 16)
                    {
                        if (j >= 13 / 2 && j <= 21 / 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
