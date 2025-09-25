using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант 5
            //Номер 1
            Console.WriteLine("Введите количество чисел в массиве");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
