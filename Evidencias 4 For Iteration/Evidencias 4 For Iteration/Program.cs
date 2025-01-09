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
            for (int i = 1; i < 10; i++)
            {
                //Console.WriteLine(i);
                Console.WriteLine($"12 x {i} = {12 * i}");
                if (i == 7);
                {
                    Console.WriteLine("Found Seven!");
                    break;
                }
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }
            Console.ReadLine();
        }
    }
}     
            
