using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace StringProblem
{
    public class Stringnumber
    {
        public void Number()
        {
            Console.WriteLine("Enter A One String");
            string Name = Console.ReadLine();
            int wrd = 1;
            for (int i = 0; i <= Name.Length - 1; i++)
            {
                if (Name[i] == ' ' || Name[i] == '\n' || Name[i] == '\t')
                {
                    wrd++;
                }
            }
            Console.WriteLine($"Total Number Of In Strings Are : {wrd}");
        }
    }
}
