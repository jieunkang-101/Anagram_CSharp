using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Models
{
  public class Anagrams
  {
    public string Word { get; set; }
    public static List<string> _inputList { get; set; } = new List<string>{ };

    public Anagrams(string word, List<string> inputList)
    {
      Word = word;
      _inputList = inputList;
    }

    public static void ClearAll()
    {
      _inputList.Clear();
    }

    public static string SortWord(string s)
    {
      char[] wordArr = s.ToCharArray();
      Array.Sort(wordArr); 
      string result = string.Join("", wordArr);
      return result;
    }

    public static bool CheckAnagrams(string word, List<string> userInputList)
    {
      string originalWord = Anagrams.SortWord(word);
      foreach(string element in userInputList)
      {
        string newWord = Anagrams.SortWord(element);
        if (newWord == originalWord){
          return true;
        }
      }
      return false;
    }
  }
}