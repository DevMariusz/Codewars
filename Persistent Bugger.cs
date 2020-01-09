using System;

public class Persist
{
	public static int Persistence(long n)
	{
    int total;
    int myCount = 0;

    while(n.ToString().Length > 1)
    {
      total = 1;
      for (int i = 0; i < n.ToString().Length; i++)
      {
        total *= n.ToString()[i] - '0';
      }
      myCount += 1;
      n = total;
    }

    return myCount;

	}
}
