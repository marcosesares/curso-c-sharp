using System;
using System.Text.RegularExpressions;

namespace curso_c_sharp.CodeWars
{

  public class Kata
  {
    private const int EndIndex = 1;

    public static string ToCamelCase(string str)
    {
      string result = string.Empty;
      if (!string.IsNullOrEmpty(str))
      {
        string[] splitStr = str.Split('_','-');
        result = splitStr[0];
        for (int i = 1; i < splitStr.Length; i++)
        {
          result += string.Concat(splitStr[i][..EndIndex].ToUpper(), splitStr[i][EndIndex..]);
        }
      }
      return result;
    }

    public static string ToCamelCaseSelect(string str)
    {
      return string.Concat(str.Split('-', '_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));
    }

    public static string ToCamelCaseReplace(string str)
    {
      return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
    }

    public static int GetVowelCount(string str)
    {
      string vowels = "aeiou";
      int result = str.Where(s => vowels.Contains(s)).Count();
      return result;
    }

    public static int GetVowelCount2(string str)
    {
      return str.Count(i => "aeiou".Contains(i));
    }

    public static int GetVowelCount3(string str)
    {
      return (Regex.Matches(str, @"[aeiouAEIOU]")).Count;
    }
  }
}
