﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, area, perimeter;
            string widthString, lengthString, rerun;
            Boolean flag = true;

            Console.WriteLine("Welcome to Grand Circus' Room Detail");
            do
            {

                Console.Write("Enter Length: ");
                lengthString = Console.ReadLine();
                length = double.Parse(lengthString);

                Console.Write("Enter Width: ");
                widthString = Console.ReadLine();
                width = double.Parse(widthString);

                area = length * width;
                perimeter = (length * 2) + (width * 2);

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);


                Console.Write("Do you wish to continue? Y/N ");
                rerun = Console.ReadLine();

                if (rerun.ToLower() == "n")
                {
                    flag = false;
                    Console.WriteLine("Goodbye");
                }
            }
            while (flag);

        }
    }
}
