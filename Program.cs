using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates powers of a number from 1 to the number you enter \n " +
               "note that the maximum number can be 2^95");
            program();
            void program()
            {
                
                Console.WriteLine("enter a number you want its power");
                double basen = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("now enter the highest power");
                int powern = Convert.ToInt32(Console.ReadLine());

                if (powern > 0)
                {
                    for (int i = 1; i <= powern; i++)
                    {
                        decimal x = Convert.ToDecimal(Math.Pow(basen, i));
                        //double a = (MathF.Pow(3, i));
                        Console.WriteLine(basen + " to the power of " + i + " is : " + x);
                    }
                }
                if (powern <= 0)
                {
                    for (int i = 1; i >= powern; i--)
                    {
                        decimal x = Convert.ToDecimal(Math.Pow(basen, i));
                        Console.WriteLine(basen + " to the power of " + i + " is : " + x);
                    }
                }


                Console.WriteLine("enter 1 to continue or any other number to exit");
                int cont = Convert.ToInt32(Console.ReadLine());
                if (cont == 1)
                {
                    program();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            
           
        }
    }
}
