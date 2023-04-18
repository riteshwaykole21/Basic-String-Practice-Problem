using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblem
{
    public class StrtingDemo
    {
        public void Demo()
        {
            Console.WriteLine("Enter a One string");
            string Name = Console.ReadLine();
            int i = 0;
            int wrd = 1;
            int l = 0;
            while (l <= Name.Length - 1)
            {
                if (Name[l] == ' ' || Name[l] == '\n' || Name[l] == '\t')
                {
                    wrd++;
                }
                l++;
            }
            Console.WriteLine($"Total Number Of In Strings Are : {wrd}");
        }

    }
}
