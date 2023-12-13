using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Num4();
        } 

        static void Num1()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        static void Num2()

        {

            Console.WriteLine("Введите строку:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Введите число N больше 0:");
            int N = Int32.Parse(Console.ReadLine());

            int counter = 0;
            while (counter < N)
            {
                Console.WriteLine(inputString);
                counter++;
            }
        }
        static void Num3()
        {
            int i = 0;
            while (i < 10)
            {

            }

            int j = 0;
            while (j < 10)

                Console.Write("S");
            j++;

            Console.WriteLine();
            i++;
        }
 static void Num4()
    {
        int i = 1;
        while (i <= 10)
        {
        }
            int j = 1;
            while (j <= 10)
            {
             Console.Write ((i * j) + " ");
                j++;   
            }
            Console.WriteLine();
            i++;
        }
    }

    }
    

        

        

