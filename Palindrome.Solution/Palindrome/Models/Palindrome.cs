using System;

namespace PalindromeChecker.Models
{
  public class Palindrome
  {
    // properties, constructors, methods, etc. go here
    public string Input { get; set; }

    public Palindrome(string input)
    {
      Input = input;
    }

    public char[] SplitWord()
    {
      string input = Input;
      char[] chars = input.ToCharArray();
      return chars;
    }
    public bool isPalindrome()
    {
      char[] splitArray = SplitWord();
      for (int i = 0; i < splitArray.Length; i++)
      {
        if (splitArray[i] == splitArray[splitArray.Length - 1 - i])
        { }
        else
        {
          return false;
        }
      }
      return true;
    }
  }
}


// > string test = "word";
// > test
// "word"
// > string[] newArray = test.Split("");
// > newArray
// string[1] { "word" }
// > char[] myArray = test.ToCharArray();
// > myArray
// char[4] { 'w', 'o', 'r', 'd' }