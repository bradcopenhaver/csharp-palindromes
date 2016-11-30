using System;
using System.Text.RegularExpressions;

namespace Palindrome.Objects
{
  public class PalindromeChecker
  {
    private string _inputString;
    private char[] _characters = new char[]{};

    public PalindromeChecker(string input)
    {
      _inputString = input;
    }

    public string ToLowerAndTrim()
    {
      string modified = _inputString.ToLower();
      modified = Regex.Replace(modified, "[^A-Za-z0-9]", "");
      Console.WriteLine(modified);
      return modified;
    }

    public bool Checker()
    {
      _characters = ToLowerAndTrim().ToCharArray();
      int back = _characters.Length - 1;
      for(int forward = 0; forward < _characters.Length / 2; forward++)
      {
        if(_characters[forward] != _characters[back])
        {
          return false;
        }
        back--;
      }
      return true;
    }

    public string GetInput()
    {
      return _inputString;
    }
  }
}
