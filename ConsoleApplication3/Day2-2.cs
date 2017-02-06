using System;

namespace ConsoleApplication3
{
    class Day2_2
    {
        public static void Main()
        {
            //int input = Console.ReadLine(); //Readline return string, so it's not possible to store readline return as integer. Need to convert first.

            string input = Console.ReadLine(); 
            Console.WriteLine("Hey {0}", input);

            int NumTix = Convert.ToInt32(input); // This step is neccessary to convert readline return to integer, if you are planning to use the return as integer. convert string input to integer - Method 1
            //bool isOK -Int32.TryParse(input, out NumTix); // Another method, which will reject the input unless the input can be converted.

            Console.WriteLine("Cost = {0}", NumTix * 2);

            // double A = "1.5"; int A =1.5; // C# is strongly typed.

            // In terms for variable storage, you can store a small number type into a big one, eg int to long. But not vice versa. Similarly, you are not allowed to store string to number datatype


            

        }
    }
}
