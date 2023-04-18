using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblem
{
    public class CountNumber
    {
        public void Number()
        {
            Console.WriteLine("Enter A First String ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter A Second String");
            string Name1 = Console.ReadLine();
            if (Name == Name1)
            {
                Console.WriteLine("Strings Are Equal");
            }
            else
            {
                Console.WriteLine("The Strings Are Not Equal");
            }
        }
    }
}
