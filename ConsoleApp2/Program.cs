using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int n = Convert.ToInt32(Console.ReadLine());
            int result = a;
            for (int i = 0; i < n; ++i)
            {
                result = Convert.ToInt32(result * a);
            }
            Console.WriteLine(result);
        }
    }
}
