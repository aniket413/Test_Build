using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Build
{
    internal class Program
    {
        void Addition()
        {
            int a = 100, b = 200, c;
            c = a + b;
            Console.WriteLine("Addition=" + c);
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            p.Addition();
            Console.ReadLine();
                
        }
    }
}
