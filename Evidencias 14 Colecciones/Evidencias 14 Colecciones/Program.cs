using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car();
            //car1.Make = "Oldsmobile";
            //car1.Modle = "Cutlas Supreme";
            //car1.VIN = "A1";

            //Car car2 = new Car();
            //car2.Make = "Geo";
            //car2.Modle = "Prism";
            //car2.VIN = "B2";

            //Book book1 = new Book();
            //book1.Author = "Robert Tabor";
            //book1.Title = "Microsoft .NET XML Web Services";
            //book1.ISBN = "0=000=00000=0";

            ////ArrayLists are dynamically sized,
            ////cool features sorting, remove items
            //ArrayList myArraylist = new ArrayList();
            //myArraylist.Add(car1);
            //myArraylist.Add(car2);
            //myArraylist.Add(book1);
            //myArrayList.Remove(book1);

            foreach (car car in myArraylist)
            {
                Console.WriteLine(car.Make);
            }

        }
        Car car1 = new Car() { Make = "BMW", Modle = "750li", VIN = "C3" };
        Car car2 = new Car() { Make = "Toyota", Modle = "4Runner", VIN = "D4" };

        //collection initializer
        List<Car> myList = new List<Car>
            {
                new Car {Make = "Oldsmobile", Modle = "Cutless Supreme", VIN = "A1" },
                new Car {Make = "Nisan" , Modle = "Altima", VIN = "F6" }
            };

        Console.ReadLine();

        }
}



    class Car
    {
        public string Make { get; set; }
        public string Modle { get; set; }
        public string VIN { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
