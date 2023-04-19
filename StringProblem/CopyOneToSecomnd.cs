using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblem
{
    public class CopyOneToSecomnd
    {
        public void Number()
        {
            Console.WriteLine("Enter A One String");
            string Name = Console.ReadLine();
            string[] Enter = new string[1];
            int i = 0;
            while (i < Name.Length)
            {
                string tmp = Name[i].ToString();
                Enter[i] = tmp;
                i++;
            }
            Console.WriteLine("First String Is : {0}" , Name);
            Console.WriteLine("The Second String Is : " , string.Join("",Enter));
        }
    }
}
