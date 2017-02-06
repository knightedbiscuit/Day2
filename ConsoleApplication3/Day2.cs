using System;

namespace Day2
{
    class Program1
    {
        public static void Main()
        {
            int a = 10; int b = 5; 
            System.Console.WriteLine("Name\t\tAge");
            System.Console.WriteLine("Name\t"+"\t21");
            System.Console.WriteLine(a + "+" + b + "=" + (a + b));
            System.Console.WriteLine(a + "+" + b + "=" + a + b);
            System.Console.WriteLine("{0} + {1} = {2}", a, b, a+b);
            double cash = 12345678912.345;
            Console.WriteLine("$ {0:0,0.00}", cash); // , inside the bracket denote thousand seperator. {0:0,0} is the same as {0:0,000}. Choose the later version for readability
            Console.WriteLine("$ {0:0,000.00}", cash);
            Console.WriteLine("$ {0}", cash);
            double x = 123; //double y = 33.334;
            Console.WriteLine("{0:#.#}",x);
            Console.WriteLine("{0:0}", x);    //123
            Console.WriteLine("{0:0000}", x); //0123
            Console.WriteLine("{0:##00}", x); //123, # means optional. If there is C# will print, otherwise, it will not
        }
    }
}