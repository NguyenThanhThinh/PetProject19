using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            var name = person.Name;

            Console.WriteLine(name);
            Console.WriteLine(Sum(7,4));
            Console.WriteLine($"{person.Name} + {person.PersonPhone}");
            Console.ReadKey();
        }
        public class Person
        {
          
            public string Name { get; private set; } =  "Thinh" ;
            public string PersonPhone { get;  } = "0976987788";
        }
        public static int Sum(int a, int b) => a + b;
        
        
    }
}
