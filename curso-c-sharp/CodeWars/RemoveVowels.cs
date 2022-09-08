using System;
using System.Text.RegularExpressions;

namespace curso_c_sharp.CodeWars
{
  /// <summary>
  /// Trolls are attacking your comment section!
  /// A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
  /// Your task is to write a function that takes a string and return a new string with all vowels removed.
  /// For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
  /// Note: for this kata y isn't considered a vowel.
  /// </summary>
  public class RemoveVowels
  {
    public RemoveVowels()
    {
    }

    /// <summary>
    /// Removes the following vowels from a given string: "aeiou"
    /// </summary>
    /// <param name="str">The string in which the vowels are going to be removed</param>
    /// <returns>A string derived from <c>str</c> without vowels</returns>
    public static string Disemvowel(string str)
    {
      string vowels = "(a|e|i|o|u)";
      Regex regex = new (vowels, RegexOptions.Compiled | RegexOptions.IgnoreCase);
      return regex.Replace(str, m => m.Groups[0].Value.Remove(0, 1));
    }

    public static string DisemvowelReplace(string str)
    {
      return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
    }

    public static string DisemvowelConcat(string str)
    {
      return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
    }
  }
}

