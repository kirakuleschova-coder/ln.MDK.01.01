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

            Console.WriteLine("Ключи словаря: ");
            Console.WriteLine(String.Join(", ", Words.Keys));

            List<string> NOUNS = Words[nouns];
            Console.WriteLine("Существительные в словаре: ");
            Console.WriteLine(String.Join(", ", NOUNS));

            Console.Write("Введите, какой " +
                "тип слов из словаря Вас интересует" +
                "(Существительные, Глаголы, Местоимения): ");
            string userTypeWords = Console.ReadLine();
            int TypeWordsCount = Words[userTypeWords].Count;
            Console.WriteLine($"В словаре {TypeWordsCount} слова данного типа");
        }
    }
}
