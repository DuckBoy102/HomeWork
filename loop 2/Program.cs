using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your child age");
            int age;
            int counter1 = 0;
            int counter2 = 0;
            for (int i = 0; i < 12 && i >15; i++)
            {
                age =int.Parse(Console.ReadLine());
                if (age > 12 && age < 15)
                    counter1++;
            }
        }
    }
}
