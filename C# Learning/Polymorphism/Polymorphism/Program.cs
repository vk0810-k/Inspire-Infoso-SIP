/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.sum();
            Calculator.sum(5, 4);
            Calculator.sum(9.3f, 8.6f);
            Calculator.sum("Hello World");
            Console.Read();
        }
    }
    static class Calculator
    {
        public static void sum()
        {
            Console.WriteLine("No Value Provided");
        }
        public static void sum(int x, int y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }
        public static void sum(float x, float y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }
        public static void sum(string s)
        {
            Console.WriteLine("{0} - is not a numeric value", s);
        }
    }
}
*/

/*Qu 1.Write a program to save data to database. There should be a function Save() 
 * that accepts one, two or three values as parameter and then save that to database.*//*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.save();
            p.save("Jack");
            DateTime dt = DateTime.Now;
            p.save("Jack", 22, dt.ToShortDateString());
            Console.ReadKey();

        }
        public void save()
        {
            Console.WriteLine("No Data to Saved");
        }
        public void save(string name)
        {
            Console.WriteLine("{0} saved", name);
        }
        public void save(string name, int age)
        {
            Console.WriteLine("{0} and {1} - Saved", name, age);
        }
        public void save(string name, int age, string date)
        {
            Console.WriteLine("{0} and {1} are saved on {2}", name, age, date);
        }
    }
}*/

/*Qu 2: Write a program using virtual and override keyword in which base class 
 * should have a function TyreSize() that should be implemented in derived class 
 * using override keyword.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferrari f = new Ferrari();
            f.TyreSize();
            Console.ReadKey();
        }
    }
    public class Tyre
    {
        public virtual void TyreSize()
        {
            Console.WriteLine("Default Tyre Size is 13 Inches");
        }
    }
    public class Ferrari : Tyre
    {
        public override void TyreSize()
        {
            base.TyreSize();
            Console.WriteLine("Tyre Size is Overriden and new Tyre Size is : 14 Inches");
        }
    }
}