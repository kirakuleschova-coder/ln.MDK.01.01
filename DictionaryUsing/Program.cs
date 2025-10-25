using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> Words = 
                new Dictionary<string, List<string>>();

            string nouns = "Существительные";
            string verbs = "Глаголы";
            string pronouns = "Местоимения";
            Words.Add(nouns, new List<string>()
                                    {"Картошка", "Бульдозер", "Картина"});

            Words.Add(verbs, new List<string>()
                                    {"Копать", "Ездить", "Смотреть" });

            Words.Add(pronouns, new List<string>()
                                    {"Я", "Мы", "Они" });


            Console.WriteLine(String.Join(", ", Words.Keys));
        }
    }
}
