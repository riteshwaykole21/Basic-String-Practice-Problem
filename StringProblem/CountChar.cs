using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblem
{
    public class CountChar
    {
        public void Number()
        {
            Console.WriteLine("Enter a One String");
            string Name = Console.ReadLine();
            int Alp = 0;
            int digit = 0;
            int splich = 0;
            for (int i = 0; i < Name.Length; i++)
            {
                if ((Name[i] >= 'a' && Name[i] <= 'z')  || (Name[i] >= 'A' && Name[i] <= 'Z'))
                {
                    Alp++;
                }
                else if(Name[i] >= '0' && Name[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    splich++;
                }
            }
            Console.WriteLine($"Number Of Alphabets :  {Alp}");
            Console.WriteLine($"Number Of Digit  : {digit}");
            Console.WriteLine($"Numberb Of Splich : {splich}");
        }
    }
}
