using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class CountRepeats
  {
    private string _UserInputWord;
    private string _UserInputString;

    public CountRepeats (string UserInputWord, string UserInputString)
    {
      _UserInputWord = UserInputWord;
      _UserInputString = UserInputString;

    }
    public int CountWords() {
      int count = 0;
      string UserInputString = _UserInputString.ToLower();
      string UserInputWord = _UserInputWord.ToLower();

      string[] userString = UserInputString.Split();

      for (int index = 0; index < userString.Length; index++){
        if (userString[index] == UserInputWord) {
          count += 1;
        }
      }
       return count;
    }
  }
}
