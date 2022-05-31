/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace run_csharp_code
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // initialization

            i++; // i incremented by one. It is post increment

            Console.WriteLine("The value of i is {0}", i);

            Console.ReadLine();
        }
    }
}*//*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comparison_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            //Accepting two inputs from the user
            Console.Write("Enter first number\t");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Processing comparison
            //Check whether num1 is greater than or not
            if (num1 > num2)
            {
                Console.WriteLine("{0} is greater than {1}", num1, num2);
            }
            //Check whether num2 is greater than or not
            else if (num2 > num1)
            {
                Console.WriteLine("{0} is greater than {1}", num2, num1);
            }
            else
            {
                Console.WriteLine("{0} and {1} are equal", num1, num2);
            }
            Console.ReadLine();
        }
    }
}*//*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Or_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, userpassword;

        label: //Creating label

            Console.Write("\n\nEnter your login name:\t");
            username = Console.ReadLine();

            Console.Write("Enter your password:\t");
            userpassword = Console.ReadLine();

            try
            {
                if ((username == "Steven" || username == "Clark") && (userpassword == "demopass"))
                {
                    Console.WriteLine("\nLogin Successful.");
                }
                else
                {
                    Console.WriteLine("\nUnauthorised Access. Aborting...");
                }

                Console.Write("\n\nPress Y or y for continue. Press N or n for Exit:\t");
                char ans = Convert.ToChar(Console.ReadLine());
                if (ans == 'Y' || ans == 'y')
                {
                    goto label; //goto label

                }
                else
                {
                    Console.WriteLine("Press  Enter for Aborting...");
                    Console.ReadLine();
                    return;
                }
            }
            catch { }

        }
    }
}
*/

/*Qu1: Write a program to calculate (a+b)2.*//*

using System;
public class funcexer3
{
    public static int Sum(int num1, int num2)
    {
        int total;
        total = num1 * num1 + 2 * num1 * num2 + num2 * num2;
        return total;
    }

    public static void Main()
    {
        Console.Write("\n\nFunction to calculate the sum of two numbers :\n");
        Console.Write("--------------------------------------------------\n");
        Console.Write("Enter a number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));
    }
}
*/

/*Qu2: Write a program to calculate formulae πr2.*//*

using System;
public class area
{
    public static void Main()
    {

        double r, per_cir;
        double PI = 3.14;
        Console.WriteLine("Input the radius of the circle : ");
        r = Convert.ToInt32(Console.ReadLine());
        per_cir = PI * r * r;
        Console.WriteLine("Perimeter of Circle : {0}", per_cir);
        Console.Read();
    }
}*/

/*Qu3: Write a program to check whether input number is even or odd.*//*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace check1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}*/

/*Qu4: Write a program to calculate power of given number by user.*//*
using System;
public class Power
{

    public static void Main()
    {
        int bNum, pwr;
        int result;
        Console.Write("\n\n Recursion : Calculate power of any number :\n");
        Console.Write("------------------------------------------------\n");

        Console.Write(" Input the base  value : ");
        bNum = Convert.ToInt32(Console.ReadLine());

        Console.Write(" Input the exponent : ");
        pwr = Convert.ToInt32(Console.ReadLine());

        result = CalcuOfPower(bNum, pwr);//called the function CalcuOfPower

        Console.Write(" The value of {0} to the power of {1} is : {2} \n\n", bNum, pwr, result);
    }

    public static int CalcuOfPower(int x, int y)
    {
        if (y == 0)
            return 1;
        else
            return x * CalcuOfPower(x, y - 1);
    }
}*/

/*Qu5: Write a program to calculate area of triangle. Take required input from user and 
 * then calculate the area of triangle.*/

using System;
public class area
{
    public static void Main()
    {

        double b, h, per_tri;
        Console.WriteLine("Input the Base of the triangle : ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the Height of the triangle : ");
        h = Convert.ToInt32(Console.ReadLine());
        per_tri = 0.5 * b * h;
        Console.WriteLine("Perimeter of Circle : {0}", per_tri);
        Console.Read();
    }
}