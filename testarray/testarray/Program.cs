using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3];
            array[0] = "Мультимедийные технологии";
            array[1] = "Физическая культура";
            array[2] = "Менеджмент в профессиональной деятельности";

            array[1] = "Физра";
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);

            Console.WriteLine("-----------------------------------------------------------");

            string[] twoarray = new string[3];
            twoarray[0] = array[2];
            twoarray[1] = array[1];
            twoarray[2] = array[0];
            Console.WriteLine(twoarray[0]);
            Console.WriteLine(twoarray[1]);
            Console.WriteLine(twoarray[2]);

            Console.WriteLine("-----------------------------------------------------------");

            int[] tenarray = new int[10000];
            for (int a = 0; a < tenarray.Length; a++)
            {
                tenarray[a] = a + 1;
            }
            Console.Write("[");
            for (int a = 0; a < tenarray.Length-1; a++)
            {
                Console.Write(tenarray[a] + ",");
            }
            Console.Write(tenarray[tenarray.Length - 1] + "]");
        }
    }
}
