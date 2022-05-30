using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);

            List<int> list = new List<int>() { 16, 2, 95, 11 };
            /* ==
            List<int> list = new List<int>();
            list.Add(16);
            list.Add(2);
            list.Add(95);
            list.Add(11);*/

            foreach (int item in list)
            {
                Console.WriteLine("Count : "+ list.Count+ "\t"+item);
            }
        }
    }
}
