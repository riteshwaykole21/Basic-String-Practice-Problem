using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblem
{
    public class SeparateChar
    {
        public void Input()
        {
            Console.WriteLine("Enter A String");
            string Name = Console.ReadLine();   
            for(int i = 0; i < Name.Length; i++)
            {
                Console.Write(Name[i] + " ");
            }
        }
    }
}
