using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChecker;

namespace PalindromeChecker.Models
{
  [TestClass]
  public class ClassNameTests
  {
    // Test methods go here
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }

    [TestMethod]
    public void Palindrome_AssignsAttribute_InputString()
    {
      Palindrome test = new Palindrome("test");
      Assert.AreEqual("test", test.Input);
    }

    [TestMethod]
    public void Palindrome_SplitsInputToArray_Array()
    {
      Palindrome test = new Palindrome("test");
      char[] testArray = { 't', 'e', 's', 't' };
      Assert.AreEqual(testArray[0], test.SplitWord()[0]);
      Assert.AreEqual(testArray[1], test.SplitWord()[1]);
      Assert.AreEqual(testArray[2], test.SplitWord()[2]);
      Assert.AreEqual(testArray[3], test.SplitWord()[3]);
    }
    public void Palindrome_IsPalindrome_bool()
    {
      Palindrome testFailString = new Palindrome("test");
      Palindrome testPassString = new Palindrome("testtset");
      Palindrome testFailNum = new Palindrome("123");
      Palindrome testPassNum = new Palindrome("101");
      Assert.AreEqual(false, testFailString.isPalindrome());
      Assert.AreEqual(true, testPassString.isPalindrome());
      Assert.AreEqual(false, testFailNum.isPalindrome());
      Assert.AreEqual(true, testPassNum.isPalindrome());
    }
  }
}