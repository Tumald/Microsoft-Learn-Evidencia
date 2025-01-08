using System;


namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 5;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
            Console.Write("type your first name: ");
            string myfirstName;
            myfirstName = Console.ReadLine();

            string mylastName;
            Console.Write("Type your last name: ");
            mylastName = Console.ReadLine();

            Console.WriteLine("Hello," + myfirstName + " " +mylastName);

            Console.ReadKey();
        }
    }
}
