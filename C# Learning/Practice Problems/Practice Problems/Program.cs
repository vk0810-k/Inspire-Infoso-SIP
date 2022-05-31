/*Write a program that converts 1 lower case letter ("a" - "z") 
 * to its corresponding upper case letter ("A" - "Z"). For example 
 * if the user enters "c" then the program will show "C" on the screen.*//*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VP_Assignment1
{
    class Problem1
    {
        static void Main(string[] args)
        {
            char a;
            int b;
            Console.WriteLine("Enter A Letter Between a-z:");
            a = Convert.ToChar(Console.ReadLine());
            b = (int)a;
            if (b >= 97 && b <= 122)
            {
                b = b - 32;
                a = (char)b;
                Console.WriteLine("In Upper Case Letter:" + a);
            }
            else
            {
                Console.WriteLine("You Enter Wrong Letter, Please Enter Letter Between a-z....!");
            }
            Console.ReadKey();
        }
    }
}*/


/*Write a program that takes three points (x1, y1), (x2, y2) and(x3, y3) 
 * from the user and the program will check wheteher or not all the three 
 * points fall on one straight line.*//*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Programm2
{
    class Problem2
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, y1, y2, y3;
            int slope1, slope2, slope3;
            Console.WriteLine("Enter the values of x1 and y1 coordinates of first point");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of x2 and y2 coordinates of second point");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of x3 and y3 coordinates of third point");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            slope1 = y2 - y1 / x2 - x1;
            slope2 = y3 - y1 / x3 - x1;
            slope3 = y3 - y2 / x3 - x2;
            if (slope1 == slope2 && slope1 == slope3)
            {
                Console.WriteLine("\nAll points are fall on one straight line ");
            }
            else
            {
                Console.WriteLine("\nAll points are not fall on one straight line");
            }
            Console.ReadKey();
        }
    }
}*/

/*Write a program that takes a character from the user and determines whether 
 * the character entered is a capital letter, a small case letter, a digit or 
 * a special symbol. The following table shows the range of ASCII values for various characters.*//*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problem4
{
    class Problem4
    {
        static void Main(string[] args)
        {
            char a;
            int b;
            Console.WriteLine("Enter A Charater:");
            a = Convert.ToChar(Console.ReadLine());
            b = (int)a;
            if (b >= 65 && b <= 90)
            {
                Console.WriteLine("Entered Character Is Capital Letter:");
            }
            if (b >= 97 && b <= 122)
            {
                Console.WriteLine("Entered Character Is Small Letter:");
            }
            if (b >= 48 && b <= 57)
            {
                Console.WriteLine("Entered Character Is  Digit:");
            }
            if (b == 0 && b <= 47 || b >= 58 && b <= 64 || b >= 91 && b <= 96 || b >= 123 && b <= 127)
            {
                Console.WriteLine("Entered Character Is Special Symbols:");
            }
            Console.ReadKey();
        }
    }
}*/


/*Write a program using a switch statement that takes one value from the 
 * user and asks about the type of conversion and then performs a 
 * conversion depending on the type of conversion. If user enters:
I->convert from inches to centimeters.
G->convert from gallons to liters.
M->convert from mile to kilometer.
P->convert from pound to kilogram.
If the user enters any other character then show a proper message.*//*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problem5
{
    class Problem5
    {
        static void Main(string[] args)
        {
            int value;
            char choice;
            double centimeter, liters, kilometer, kilogram;
            Console.WriteLine("Enter A Digit Value:");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n Press Any Of The Given Choices \n " +
                "I -> convert from inches to centimeters.\n " +
                "G -> convert from gallons to liters.\n " +
                "M -> convert from mile to kilometer.\n " +
                "P - > convert from pound to kilogram.");
              choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 'I':
                    centimeter = value / 0.3937; //1 cm is equal is 0.3037 inch
                    Console.WriteLine("\n\n {0} Inch to Centimeters is : {1}", value,centimeter);
                    break;
                case 'i':
                    centimeter = value / 0.3937;
                    Console.WriteLine("\n\n {0} Inch to Centimeters is : {1}", value, centimeter);
                    break;
                case 'G':
                    liters = value * 3.78; // 1 gallon=3.78 litters
                    Console.WriteLine("\n\n {0} Gallon to Litres is : {1}", value, liters);
                    break;
                case 'g':
                    liters = value * 3.78; // 1 gallon=3.78 litters
                    Console.WriteLine("\n\n {0} Gallon to Litres is : {1}", value, liters);
                    break;
                case 'M':
                    kilometer = value * 1.60;
                    Console.WriteLine("\n\n {0} Mile to Kilometers is : {1}", value, kilometer);
                    break;
                case 'm':
                    kilometer = value * 1.60;
                    Console.WriteLine("\n\n {0} Mile to Kilometers is : {1}", value, kilometer);
                    break;
                case 'P':
                    kilogram = value * 0.453;
                    Console.WriteLine("\n\n {0} Pound to Kilogram is : {1}", value, kilogram);
                    break;
                case 'p':
                    kilogram = value * 0.453;
                    Console.WriteLine("\n\n {0} Pound to Kilogram is : {1}", value, kilogram);
                    break;
                default:
                    Console.WriteLine("You Enter A Invalid Choice, Please Enter A Valid Choice...!");
                    break;
            }
            Console.ReadKey();
        }
    }
}*/


/*In a company, worker efficiency is determined on the basis of the time 
 * required for a worker to complete a specific job. If the time taken 
 * by the worker is between 2 - 3 hours, then the worker is said to be 
 * highly efficient. If the time required by the worker is 3 - 4 hours, 
 * then the worker is ordered to increase their speed. If the time taken 
 * is 4 - 5 hours then the worker is given training to improve his speed 
 * and if the time taken by the worker is more than 5 hours then the 
 * worker must leave the company. If the time taken by the worker is 
 * input through the keyboard then find the efficiency of the worker.*//*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problem6
{
    class Problem6
    {
        static void Main(string[] args)
        {
            int time;
            Console.WriteLine("Enter Time Required For A Worker To Complete A Particular Job In Hours");
            time = Convert.ToInt32(Console.ReadLine());
            if (time >= 2 && time >= 3)
            {
                Console.WriteLine("Worker Efficiency Is Highly Efficient.");
            }
            if (time >= 3 && time >= 4)
            {
                Console.WriteLine("Worker Should Improve His Speed.");
            }
            if (time >= 4 && time >= 5)
            {
                Console.WriteLine("Worker Is Given Training To Improve His Speed.");
            }
            if (time > 5)
            {
                Console.WriteLine("Worker Should Leave The Company.");
            }
            Console.ReadKey();
        }
    }
}*/

/*Display a number in rectangle of 3 columns wide and 5 rows tall using that digit*//*
using System;
public class Exercise13
{
    public static void Main()
    {
        int x;

        Console.Write("Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}  {0}  {0}  {0}  {0}", x);
        Console.WriteLine("{0}           {0}", x);
        Console.WriteLine("{0}           {0}", x);
        Console.WriteLine("{0}           {0}", x);
        Console.WriteLine("{0}  {0}  {0}  {0}  {0}", x);
    }
}
*/

/*Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer. The charge are as follow:

Unit	Charge/unit
upto 199	@1.20
200 and above but less than 400	@1.50
400 and above but less than 600	@1.80
600 and above	@2.00
If bill exceeds Rs. 400 then a surcharge of 15% will be charged and the minimum bill should be of Rs. 100/-*//*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class exercise18
{
    static void Main(string[] args)
    {
        int custid, conu;
        double chg, surchg = 0, gramt, netamt;
        string connm;

        Console.Write("\n\n");
        Console.Write("Calculate Electricity Bill:\n");
        Console.Write("----------------------------");
        Console.Write("\n\n");

        Console.Write("Input Customer ID :");
        custid = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the name of the customer :");
        connm = Console.ReadLine();
        Console.Write("Input the unit consumed by the customer : ");
        conu = Convert.ToInt32(Console.ReadLine());
        if (conu < 200)
            chg = 1.20;
        else if (conu >= 200 && conu < 400)
            chg = 1.50;
        else if (conu >= 400 && conu < 600)
            chg = 1.80;
        else
            chg = 2.00;
        gramt = conu * chg;
        if (gramt > 300)
            surchg = gramt * 15 / 100.0;
        netamt = gramt + surchg;
        if (netamt < 100)
            netamt = 100;
        Console.Write("\nElectricity Bill\n");
        Console.Write("Customer IDNO                       :{0}\n", custid);
        Console.Write("Customer Name                       :{0}\n", connm);
        Console.Write("unit Consumed                       :{0}\n", conu);
        Console.Write("Amount Charges @Rs. {0}  per unit :{1}\n", chg, gramt);
        Console.Write("Surchage Amount                     :{0}\n", surchg);
        Console.Write("Net Amount Paid By the Customer     :{0}\n", netamt);
    }
}
*/

/*Write a program in C# Sharp to accept a grade and display the equivalent description:

Grade	Description
E	Excellent
V	Very Good
G	Good
A	Average
F	Fail*//*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class exercise19
{
    static void Main(string[] args)
    {
        string notes;
        char grd;
        Console.Write("\n\n");
        Console.Write("Accept a grade and display equivalent description:\n");
        Console.Write("---------------------------------------------------");
        Console.Write("\n\n");


        Console.Write("Input the grade :");
        grd = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (grd)
        {
            case 'E':
                notes = " Excellent";
                break;
            case 'V':
                notes = " Very Good";
                break;
            case 'G':
                notes = " Good ";
                break;
            case 'A':
                notes = " Average";
                break;
            case 'F':
                notes = " Fails";
                break;
            default:
                notes = "Invalid Grade Found.";
                break;
        }
        Console.Write("You have chosen  : {0}\n", notes);
    }
}
*/

/*Write a program in C# Sharp which is a Menu-Driven Program to compute the area of the various geometrical shape.*//*

using System;
public class Exercise24
{
    public static void Main()
    {
        int choice, r, l, w, b, h, a;
        double area = 0;

        Console.Write("\n\n");
        Console.Write("A menu driven program to compute the area of various geometrical shape:\n");
        Console.Write("-------------------------------------------------------------------------");
        Console.Write("\n\n");


        Console.Write("Input 1 for area of circle\n");
        Console.Write("Input 2 for area of rectangle\n");
        Console.Write("Input 3 for area of triangle\n");
        Console.Write("Input 4 for area of square\n");
        Console.Write("Input your choice : ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Input radius of the circle : ");
                r = Convert.ToInt32(Console.ReadLine());
                area = 3.14 * r * r;
                break;
            case 2:
                Console.Write("Input length  of the rectangle : ");
                l = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input  width of the rectangle : ");
                w = Convert.ToInt32(Console.ReadLine());
                area = l * w;
                break;
            case 3:
                Console.Write("Input the base of the triangle :");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the hight of the triangle :");
                h = Convert.ToInt32(Console.ReadLine());
                area = .5 * b * h;
                break;
            case 4:
                Console.Write("Input length  of the sqaure : ");
                a = Convert.ToInt32(Console.ReadLine());
                area = a * a;
                break;
        }
        Console.Write("The area is : {0}\n", area);
    }
}
*/

/*Write a program in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term.*/

using System;
public class funcexer12
{
    public static int Fib(int n1)
    {
        //if ( (n1 == 1) || (number == 2) )
        if (n1 <= 2)
            return 1;
        else
            return Fib(n1 - 1) + Fib(n1 - 2);
    }

    public static void Main()
    {
        int num;

        Console.Write("\n\nRecursive Function : To calculate the Fibonacci number of a specific term :\n");
        Console.Write("-------------------------------------------------------------------------------\n");
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nThe Fibonacci of {0} th term  is {1} \n", num, Fib(num));
    }
}
