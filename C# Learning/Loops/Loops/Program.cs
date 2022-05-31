/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, res, i;

            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            i = 1; //Initialization
            //Check whether condition matches or not
            while (i <= 12)
            {
                res = num1 * i;
                Console.WriteLine("{0} x {1} = {2}", num1, i, res);
                i++; //Increment by one
            }
            Console.ReadLine();
        }
    }
}*/

/*Qu 1.Input a number from user and displays power of the number. 
 * Ask users to whether continue or not. If user press 'y' or 'Y' 
 * then continue and again accept a number. If a user presses any 
 * other characters or numbers then quit. (Use while loop)*//*
using System;
public class RecExercise15
{

    public static void Main()
    {
        int bNum, pwr;
        int result;
        do {
            Console.Write("\n\n Recursion : Calculate power of any number :\n");
            Console.Write("------------------------------------------------\n");

            Console.Write(" Input the base  value : ");
            bNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input the exponent : ");
            pwr = Convert.ToInt32(Console.ReadLine());

            result = CalcuOfPower(bNum, pwr);

            Console.Write(" The value of {0} to the power of {1} is : {2} \n\n", bNum, pwr, result);

        }
        Console.Write("\n\nPress Y or y for continue. Press N or n for Exit:\t");
            char ans = Convert.ToChar(Console.ReadLine());
        while (ans == 'Y' || ans == 'y')
        {
            return;
        }
    }

    public static int CalcuOfPower(int x, int y)
    {
        if (y == 0)
            return 1;
        else
            return x * CalcuOfPower(x, y - 1);
    }
}
*/

/*Qu 2.Using for loop print the following output on console. 
    1
   121
  12321
 1234321
123454321*//*

using System;
public class Exercise36
{
    public static void Main()
    {
        int i, j, n;

        Console.Write("\n\n");
        Console.Write(" Display the pattern in which first and last number of each row will be 1:\n");
        Console.Write("----------------------------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input number of rows : ");
        n = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i <= n; i++)
        {
            for (j = 1; j <= n - i; j++)
                Console.Write(" ");
            for (j = 1; j <= i; j++)
                Console.Write("{0}", j);
            for (j = i - 1; j >= 1; j--)
                Console.Write("{0}", j);

            Console.Write("\n");
        }
    }
}
*/

/*Qu 3.Using for loop print the following output on console.
    1
   121
  12321
 1234321
123454321
 1234321
  12321
   121
    1*/

using System;
public class Exercise36
{
    public static void Main()
    {
        int i, j, n;

        Console.Write("\n\n");
        Console.Write(" Display the pattern in which first and last number of each row will be 1:\n");
        Console.Write("----------------------------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input number of rows : ");
        n = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i <= n; i++)
        {
            for (j = 1; j <= n - i; j++)
                Console.Write(" ");
            for (j = 1; j <= i; j++)
                Console.Write("{0}", j);
            for (j = i - 1; j >= 1; j--)
                Console.Write("{0}", j);

            Console.Write("\n");
        }
        for (i = n-1; i >= 1; i--)
        {
            for (j = 1; j >= n - i; j++)
                Console.Write(" ");
            for (j = 1; j >= i; j--)
                Console.Write("{0}", j);
            for (j = i - 1; j <= 1; j++)
                Console.Write("{0}", j);

            Console.Write("\n");
        }
    }
}