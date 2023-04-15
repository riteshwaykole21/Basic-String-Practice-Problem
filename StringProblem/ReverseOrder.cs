using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblem
{
    public class ReverseOrder
    {
        public void Input()
        {
            Console.WriteLine("Enter A One String");
            string Name = Console.ReadLine();
            for (int i = Name.Length - 1; i >= 0; i--)
            {
                Console.Write(Name[i] + " ");
            }
        }
    }
}
