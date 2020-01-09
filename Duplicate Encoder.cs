public class Kata
{
  public static string DuplicateEncode(string word)
  {
    word = word.ToLower();
    string convertedText = "";
    for (int i = 0; i < word.Length; i++)
    {
      for (int j = 0; j < word.Length; j++)
      {
        if (word[i] == word[j] & i!=j)
        {
          convertedText += ")";
          break;
        }
        else if (j== word.Length-1)
        {
          convertedText += "(";
        }
      }
    }
    word=convertedText;
    return word;
  }
}
