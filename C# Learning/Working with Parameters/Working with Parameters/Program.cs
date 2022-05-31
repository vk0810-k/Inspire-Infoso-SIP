/*Qu 1: Write a program to show difference between value type parameter and reference type parameter.*//*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example1
{
    class Program
    {
        public static void value(int num)
        {
            num++;
        }
        public static void reference(ref int num)
        {
            num++;
        }

        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number:\t");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n\tValue Type");
            Console.WriteLine("----------------");
            Console.Write("\nPrevious Value:\t{0}", num);
            Program.value(num);
            Console.Write("\nCurrent Value:\t{0}", num);

            Console.WriteLine("\n\n\n----------------");
            Console.WriteLine("\tReference Type");
            Console.WriteLine("--------------------");
            Console.Write("\nPrevious Value:\t{0}", num);
            Program.reference(ref num);
            Console.Write("\nCurrent Value:\t{0}", num);
            Console.ReadLine();
        }
    }
}
*/

/*Qu2: Write a program in which accept two argument as parameter from the user 
 * and returns four output value as add, subtract, multiplication and division.*//*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example2
{
    class Program
    {
        public static void parameter(int num1, int num2, out int add, out int sub, out int mul, out float div)
        {
            add = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = (float)num1 / num2;
        }
        static void Main(string[] args)
        {
            int num1, num2;
            int add, sub, mul;
            float div;
            Console.Write("Enter 1st number\t");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter 2nd number\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            Program.parameter(num1, num2, out add, out sub, out mul, out div);
            Console.WriteLine("\n\n{0} + {1} = {2}", num1, num2, add);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, sub);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, mul);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, div);

            Console.ReadLine();
        }
    }
}*/

/*Exercise 2: Write a program in which accept four numbers from the user and 
 * returns add, subtraction and multiplication of the value using out parameter.*/
using System;
public class Exercise7
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
    }
}
