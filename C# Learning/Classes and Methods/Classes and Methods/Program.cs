/*Qu.Write a program to explain method in C#. Create a static function 
 * add() that accept two number from user and returns sum of the number.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example1
{
    class calculation
    {
        static int num1, num2, sum, sub, div, mul, mod;
        public static void inp()
        {
            Console.Write("Enter number 1st.\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2nd.\t");
            num2 = Convert.ToInt32(Console.ReadLine());

        }

        public static void add()
        {
            sum = num1 + num2;

            Console.Write("\nAddition = {0}", sum);
            Console.ReadLine();
        }

        public static void subs()
        {
            sub = num1 - num2;

            Console.Write("\nSubstraction = {0}", sub);
            Console.ReadLine();
        }

        public static void mult()
        {
            mul = num1 * num2;

            Console.Write("\nMultiplication = {0}", mul);
            Console.ReadLine();
        }

        public static void divs()
        {
            div = num1 / num2;

            Console.Write("\nDivision = {0}", div);
            Console.ReadLine();
        }

        public static void mods()
        {
            mod = num1 % num2;

            Console.Write("\nModulus = {0}", mod);
            Console.ReadLine();
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            calculation.inp();
            calculation.add();
            calculation.subs();
            calculation.mult();
            calculation.divs();
            calculation.mods();
        }
    }
}