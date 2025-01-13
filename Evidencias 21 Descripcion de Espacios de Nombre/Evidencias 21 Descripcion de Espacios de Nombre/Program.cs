using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AssemblesAndNameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //string text = "A class is the most powerful data type in C#. Like a structure, " +
            //               "a class defines the data and behavior of the data type. ";

            //File.WriteAllText(@"C:\Users\FertecoPC\Desktop\Evidencias Desarrollo\Evidencias 21 Descripcion de Espacios de Nombre\Evidencias 21 Descripcion de Espacios de Nombre\Example.txt", text);

            //https://msdn.microsoft.com/en-us/library/fhd1f0sw(v=vs.110).aspx
            WebClient client = new WebClient();
            string reply = client.DownloadString("Http://msdn.microsoft.com");

            Console.WriteLine(reply);

            //gets full page html to file
            File.WriteAllText(@"C:\Users\FertecoPC\Desktop\Evidencias Desarrollo\Evidencias 21 Descripcion de Espacios de Nombre\Evidencias 21 Descripcion de Espacios de Nombre\Example.txt", reply);

            //Console.WriteLine("Hello, World");
            //Console.ReadLine();
        }
    }
}
