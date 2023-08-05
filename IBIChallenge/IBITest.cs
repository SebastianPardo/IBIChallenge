using System;

namespace Test2
{
  class IBITest
  {

    public static string NumericPalindrome(int num)
    {
      string number = num.ToString();
      int middlePoint = number.Length / 2;
      for (int i = 0; i < number.Length / 2; i++)
      {
        if (number[i] == number[(number.Length - 1) - i])
        {
          return "false";
        }
      }
      return "true";

    }


    public static string ArrayAddition(int[] arr)
    {
      Array.Sort(arr);
      return SumNumbers(0, 0, arr.Take(arr.Length - 1).ToArray<int>(), arr.Last()).ToString().ToLower();
    }

    public static bool SumNumbers(int startIndex, int prevSum, int[] initialArray, int largestNumber)
    {
      for (int i = startIndex; i < initialArray.Length; i++)
      {
        var sum = prevSum + initialArray[i];
        if (sum == largestNumber)
          return true;
        if (SumNumbers(i + 1, sum, initialArray, largestNumber))
          return true;
      }

      return false;
    }

    public static int IntegerValues(string str)
    {
      int sum = 0;
      int count = str.Length;
      int i = 1;
      foreach (char c in str.ToUpper())
      {
        sum = sum + (int)Math.Pow(26, count - i) * ((int)c - 64);
        i++;
      }
      return sum;
    }

  }

}
