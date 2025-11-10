using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3000];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 10000);
            }
        }
    }
}
