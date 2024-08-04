using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            DateTime dataTime = DateTime.Now;

            Console.WriteLine(dataTime.ToString());


            for (int i = 1; i < 10; i++)
            {
                for (int k = 0; k < i; k++)
                {
                   Console.Write("O");
                }

                Console.WriteLine();
            }

            Person person = new Person();
            person.Name = "Dima";
            person.Name = "Ivanov";
            person.Age = 20;

            Console.ReadKey();
        }
    }
}
