using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ю2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if(x < 10)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                string s1 = x.ToString();
                char s2 = s1[1];
                s1 = s1.Remove(1, 1);
                s1 = s1 + s2;
                Console.WriteLine(s1);
                
                
            }
        }
    }
}
