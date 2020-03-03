using System;
using System.IO;
using Anagram.Models;

namespace Anagram
{
  public class Program
  {
     public static void Main()
    {
      // System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
      string[] lines = System.IO.File.ReadAllLines(@"c:/Users/Guest/Desktop/Anagram.Solution/Anagram/Dictionary.txt");

      Console.WriteLine("choose a word");
      string word = Console.ReadLine(); 

      foreach(string x in lines)
      {
        if(word.Contains(x))
        {
          Console.WriteLine("Word exists");
        }
      }


      
    }
  }
}

