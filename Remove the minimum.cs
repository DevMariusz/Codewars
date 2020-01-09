using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
  public static List<int> RemoveSmallest(List<int> numbers)
  {
    List<int> newItems = new List<int>(numbers);

    int smallestNumber;

    if (numbers.Count == 0)
    {
      return newItems;
    }
    else
    {
      smallestNumber = newItems[0];
    }

    for (int i = 0; i < newItems.Count; i++)
    {
      if (newItems[i] < smallestNumber)
      {
        smallestNumber = newItems[i];
      }
    }

    newItems.Remove(smallestNumber);

    return newItems;
  }
}
