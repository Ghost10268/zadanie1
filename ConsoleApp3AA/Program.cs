using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3AA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя");
            string imya = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            string familia = Console.ReadLine();
            Console.WriteLine("Введите своё отчество");
            string otchestvo = Console.ReadLine();
            Console.WriteLine($"{familia} {imya} {otchestvo}");
            Console.ReadKey();

        }
    }
}
