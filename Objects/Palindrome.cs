using System;

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
      _inputString = _inputString.ToLower();
      _inputString = _inputString.Replace(" ", "");
      Console.WriteLine(_inputString);
      return _inputString;
    }

    public bool Checker()
    {
      _characters = _inputString.ToCharArray();
      Console.WriteLine(_characters);
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
  }
}
