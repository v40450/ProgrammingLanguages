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
/*
        //print all of the languages
        PrettyPrintAll(languages);

        //a query that returns a string for each language
        var queryResult = from h in languages
          select $"{h.Year}, {h.Name}, {h.ChiefDeveloper}";
        PrintAll(queryResult);

        //languages with the name "C#"
        var cSharp = from h in languages
          where h.Name == "C#"
          select h;
        PrettyPrintAll(cSharp);

        //languages with the chiefDeveloper Contains() "Microsoft"
        var microsoft = from h in languages
          where h.ChiefDeveloper.Contains("Microsoft")
          select h;
        fPrettyPrintAll(microsoft);

        //languages with the Predecessors Contains() "Lisp"
        var lisp = from h in languages
          where h.Predecessors.Contains("Lisp")
          select h;
        PrettyPrintAll(lisp);

        //languages names that Contains() "Script"
        var script = from h in languages
          where h.Name.Contains("Script")
          select h.Name;
        PrintAll(script);

        //how many languages are included in the languages list?
        Console.WriteLine(languages.Count);
*/
        //how many languages were launched between 1995 and 2005?
        var launch = from h in languages
          where (h.Year >= 1995) && (h.Year <= 2005)
          select $"{h.Name} was invented in {h.Year}";
        Console.WriteLine(launch.Count());

        //print a string for each of those 66 languages
        PrintAll(launch);
       
    }

    public static void PrettyPrintAll(IEnumerable<Language> langs)
    {
      foreach(var h in langs)
      {
        Console.WriteLine(h.Prettify());
      }
    }
    public static void PrintAll(IEnumerable<Object> sequence)
    {
      foreach(var h in sequence)
      {
        Console.WriteLine(h);
      }
    }

  }
}
