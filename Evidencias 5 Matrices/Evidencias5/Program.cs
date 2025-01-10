using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int number1 = 4;
            int number2 = 8;
            int number3 = 15;
            int number4 = 16;
            int number5 = 23;

            if (number1 == 16)
            {

            }
            else if (number2 == 16)
            {

            }
            else if (number3 == 16)
            {

            }
            
             
            int[] number = new int[5]


            int number[0] = 4;
            int number[1] = 8;
            int number[2] = 15;
            int number[3] = 16;
            int number[4] = 23;
            //number[5] = 42;

            Console.WriteLine(number[1]);
            Console.WriteLine(number.lenght);
            Console.ReadLine();
            */

            //int[] number = new int[] { 4, 8, 15, 16, 23, 42 };

            //string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };
            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */
            /*
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            string zig = "You can get what you want in life" + 
                "if you help enough" + 
                "other people get what they want";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }


       }
    }
}
