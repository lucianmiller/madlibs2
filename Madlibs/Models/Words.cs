using System.Collections.Generic;

namespace Madlibs.Models
{
  public class Words
  {
    public string Person1 { get; set; }
    public string Person2 { get; set; }
    public string Animal { get; set; }
    public string Exclamation { get; set; }
    public string Verb { get; set; }
    public string Noun { get; set; }

    public Words(string person1, string person2, string animal, string exclamation, string verb, string noun)
    {
      Person1 = person1;
      Person2 = person2;
      Animal = animal;
      Exclamation = exclamation;
      Verb = verb;
      Noun = noun;
    }
  }
}