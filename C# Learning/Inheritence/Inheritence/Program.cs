/*Qu 1: You are assigning to develop a project in which you have to achieve following goals.
 Write a program for creating Laptop.
 Name, Price, Processor, Ram and Hard_drive should be defined in base class as constant.
 You need to inherit these functionalities in your program and Print Details.
 All the laptop should have different name, price, processor, ram and Hard_drive.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop lp = new Laptop();

            lp.ShowDetails(Laptop.Lenove, Laptop.Price1000, Laptop.i3, Laptop.Ram2GB, Laptop.HD500GB);
            Console.WriteLine("\n\n*************************************\n");

            lp.ShowDetails(Laptop.Dell, Laptop.Price1500, Laptop.i5, Laptop.Ram4GB, Laptop.HD1TB);
            Console.WriteLine("\n\n*************************************\n");

            lp.ShowDetails(Laptop.Sony, Laptop.Price2000, Laptop.i9, Laptop.Ram8GB, Laptop.HD1TB);
            Console.WriteLine("\n\n*************************************\n");

            Console.ReadKey();
        }
    }
    class Laptop : LaptopBase
    {
        public void ShowDetails(string name, string price, string processor, string ram, string hdd)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Processor : " + processor);
            Console.WriteLine("Ram : " + ram);
            Console.WriteLine("HDD : " + hdd);
        }
    }

    class LaptopBase
    {
        public const string i3 = "i3";
        public const string i5 = "i5";
        public const string i7 = "i7";
        public const string i9 = "i9";

        public const string Ram2GB = "2GB";
        public const string Ram4GB = "4GB";
        public const string Ram8GB = "8GB";

        public const string HD500GB = "500GB";
        public const string HD1TB = "1TB";

        public const string Price1000 = "$1000";
        public const string Price1500 = "$1500";
        public const string Price2000 = "$2000";

        public const string Lenove = "Lenovo";
        public const string Sony = "Sony";
        public const string Dell = "Dell";
    }
}