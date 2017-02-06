using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Day2_3
    {
        public static void Main()
        {
            int a = 1;
            a++; // a= a+1, a=2
            a--; // a= a-1, a=1

            Console.WriteLine(a);

            ++a; // a= a+1, a=2

            int b = a; //at this point, b = 2. 
            Console.WriteLine(a++); // 2, a is incremented after writeline (incremented after what had been displayed on the console!)
            Console.WriteLine(b); b = b + 1; //2 
            Console.WriteLine(++a); //4
            b = b + 1; Console.WriteLine(b); // 4, a is incremented before writeline
            // a+=5; //a=a+5



        }
    }
}
