using System;
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
            Console.WriteLine("3 : Seperate Character ");
            Console.WriteLine("4 : Reverse Order Of String");
            Console.WriteLine("5 : Count The Number Of String");
            Console.WriteLine("6 : Demo ");
            Console.WriteLine("7 : Number Of String ");
            Console.WriteLine("8 : Count Total Special Character");
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
                case 3:
                    SeparateChar separateChar = new SeparateChar();
                    separateChar.Input();   
                    break;
                case 4:
                    ReverseOrder reverseOrder = new ReverseOrder();
                    reverseOrder.Input();
                    break;
                case 5:
                    CountNumber countNumber = new CountNumber();
                    countNumber.Number();
                    break;
                case 6:
                    StrtingDemo strtingDemo = new StrtingDemo();
                    strtingDemo.Demo();
                    break;
                case 7:
                    Stringnumber stringnumber = new Stringnumber();
                    stringnumber.Number();
                    break;
                case 8:
                    CountChar countChar = new CountChar();
                    countChar.Number(); 
                    break;
            }
            Console.ReadLine();
        }
    }
}
