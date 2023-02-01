using System;
using PalindromeChecker.Models;

namespace PalindromeChecker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word or number");
      string input = Console.ReadLine();
      Palindrome inputPalindrome = new Palindrome(input);
      if (inputPalindrome.isPalindrome())
      {
        Console.WriteLine("This is a Palindrome");
      }
      else
      {
        Console.WriteLine("This is not a Palindrome");
      }
    }
  }
}