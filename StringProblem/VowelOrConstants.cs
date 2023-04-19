using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblem
{
    public class VowelOrConstants
    {
        public void Numbers()
        {
            Console.WriteLine("Enter a String");
            string Name = Console.ReadLine();
            int vowel = 0;
            int Cons = 0;
            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i] == 'a' || Name[i] == 'e' || Name[i] == 'i' || Name[i] == 'o' || Name[i] == 'u' || Name[i] == 'A' || Name[i] == 'E' || Name[i] == 'I' || Name[i] == 'O' || Name[i] == 'U')
                {
                    vowel++;
                }
                else if (Name[i] >= 'a' && Name[i] <= 'z'|| Name[i] >= 'A' && Name[i] <= 'Z')
                {
                    Cons++;
                }
            }
            Console.WriteLine($"Total Number Of Vowel In String : {vowel}");
            Console.WriteLine($"Total Number Of Constant : {Cons}");
        }
    }
}
