﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Input String And Print it");
            Console.WriteLine("2 : Lenght Of A string");
            Console.WriteLine("Enter A Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    Print print = new Print();
                    print.Input();
                    break;
                case 2:
                    StringLength stringLength = new StringLength();
                    stringLength.Input(); 
                    break;
            }
            Console.ReadLine();
        }
    }
}
