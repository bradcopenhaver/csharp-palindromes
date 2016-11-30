using Xunit;
using System;
using System.Collections.Generic;
using Palindrome.Objects;


namespace Palindrome
{
  public class PalindromeTest
  {
    [Fact]
    public void Will_Format_Sentence()
    {
      //Arrange
      string expectedResult = "helloworld";
      PalindromeChecker newChecker = new PalindromeChecker("Hello World");
      //Act
      string actualResult = newChecker.ToLowerAndTrim();
      //Assert
      Assert.Equal(expectedResult, actualResult);
    }
    [Fact]
    public void Will_Return_True_For_Palindrome()
    {
      PalindromeChecker newChecker = new PalindromeChecker("Race car");
      string blank = newChecker.ToLowerAndTrim();
      bool result = newChecker.Checker();
      Assert.Equal(true, result);
    }
  }
}
