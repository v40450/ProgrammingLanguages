using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("./languages.tsv")
              .Skip(1)
              .Select(line => Language.FromTsv(line))
              .ToList();

            foreach (Language language in languages)
            {
                Console.WriteLine(language.Prettify());
            }

            var queryResult = from h in languages
                              select $"{h.Year}, {h.Name}, {h.ChiefDeveloper}";

            foreach (string h in queryResult)
            {
                Console.WriteLine(h);
            }


        }
    }
}
