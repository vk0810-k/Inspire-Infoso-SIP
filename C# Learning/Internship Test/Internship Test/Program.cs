/*Fibonacci Series*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Question1
{
    public static int FindFibonacci(int n)
    {
        int p = 0;
        int q = 1;
        for (int i = 0; i < n; i++)
        {
            int temp = p;
            p = q;
            q = temp + q;
        }
        return p;
    }

    static void Main()
    {
        Console.Write(" Enter a Number : ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n The Fibonacci series of legth {0} is : \n", n1);
        for (int i = 0; i < n1; i++)
        {
            Console.Write(" {0} ", FindFibonacci(i));
        }
        Console.WriteLine("\n");
        Console.ReadLine();
    }
}*/


/*Palindrome of a Number*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Question2
{
    public static void Main()
    {
        int num, r, sum = 0, t;
        Console.Write("Input a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        for (t = num; num != 0; num = num / 10)
        {
            r = num % 10;
            sum = sum * 10 + r;
        }
        if (t == sum)
            Console.Write("The Number {0} is a palindrome number.\n", t);
        else
            Console.Write("The Number {0} is not a palindrome number.\n", t);
    }
}*/

/*Reverse Of String*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Question3
{
    static string StrReverse(string str)
    {
        string reverse = "";
        int strLen = 0;

        strLen = str.Length - 1;
        while (strLen >= 0)
        {
            reverse = reverse + str[strLen];
            strLen--;
        }
        return reverse;

    }
    static void Main(string[] args)
    {
        string str = "";
        string reverse = "";

        Console.Write("Enter a string : \n");
        str = Console.ReadLine();
        reverse = StrReverse(str);
        Console.WriteLine("\nReverse of string [{0}] is : \n {1}", str, reverse);
    }
}*/

/*Find Largest number in the list*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Question4
{
    static void Main()
    {
        int i = 0;
        int large = 0;
        int[] arr = new int[5];

        Console.WriteLine("Enter array elements : ");
        for (i = 0; i < arr.Length; i++)
        {
            Console.Write("Element[" + (i + 1) + "]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        large = arr[0];
        for (i = 1; i < arr.Length; i++)
        {
            if (large < arr[i])
                large = arr[i];
        }
        Console.WriteLine("Largest element in array is : " + large);
    }
}*/