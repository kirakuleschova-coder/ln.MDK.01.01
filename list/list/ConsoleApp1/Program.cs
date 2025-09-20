using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            List<string> isxodlist = new List<string>();
            Console.WriteLine("Исходный размер списка = " + isxodlist.Count);
            isxodlist.Add("Маша");
            isxodlist.Add("Кира");
            isxodlist.Add("Ирина");
            isxodlist.Add("Егор");
            isxodlist.Add("Илья");
            Console.WriteLine("Размер списка после добавления элементов = " + isxodlist.Count);
            
            List<string> filtrlist = new List<string>();
            Console.WriteLine("Введите текст: ");
            filtrlist.Add(Console.ReadLine()); 
            Console.WriteLine("Вывод");

        }
    }
}
