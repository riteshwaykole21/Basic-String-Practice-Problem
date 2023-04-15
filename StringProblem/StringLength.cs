using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblem
{
    public class StringLength
    {
        public void Input()
        {
            Console.WriteLine("Enter A String ");
            string Name = Console.ReadLine();
            Console.WriteLine($"{Name.Length}");
        }
    }
}
