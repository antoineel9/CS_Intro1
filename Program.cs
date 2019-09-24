using System;

namespace CS_Intro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("puppy");


            //string variable
            string puppy = "what up"  + "  playa";
            Console.WriteLine(puppy);



            // number variable
            int num1 = 39;
            float num2 = 39.99f;
            double num3 = 39.99;

            //boolean variable 
            bool boolean = true;

            // concatenation
            string concat1 = "what up"  +"  playa";
            Console.WriteLine(concat1);

           
            //math
            int out1 = 2 + 6;
            float out2 = 4.4f + 8f;
            var out3 = 6 + 7.7;
            double out4 = 8.4- 2;

            int out5 = 8 * 4;

            //constants
            const bool redDoor = true;
            const double cNum1 = 3.445;
            const string myName = "El Rey!";

           
            //working with variables
            int coconut = num1 * out1;
            Console.WriteLine(coconut);

            string concat2 = myName + " EL Rey!";
            Console.WriteLine(concat2);

            //string interpolation
            //string interpolation
            Console.WriteLine("My name is {0}. Num {1}: Num:{2}.", myName, num3, out4);
        }
    }






}
                
