using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[5];
            Console.WriteLine("Enter name of cities you want to store");
            for (int i = 0; i < 5; i++)
            {
                str[i] = Console.ReadLine();
            }
            Console.WriteLine("Enterred cities are");
            foreach (Object s in str)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
