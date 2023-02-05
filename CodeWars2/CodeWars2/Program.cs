using System;
using System.Linq;

public class Solution
{
    public static int solve(string s)
    {
        int length = s.Length;
        if( length % 2 != 0)
        {
            return -1;
        }
        Stack<char>min = new Stack<char>();
        for(int i = 0; i < length; i++)
        {
            char c = s[i];
            if(c == ')' && min.Count > 0 ) 
            {
               if(min.Peek() == '(') 
               {
                min.Pop();
               }
                else
                {
                    min.Push(c);    
                }
            }
            else
            {
                min.Push(c);
            }
        }
        int red_len = min.Count;
        int n = 0;
        while(min.Count > 0 && min.Peek() == '(')
        {
            min.Pop();
            n++;
        }
        return (red_len / 2 + n % 2);
    }
}
public class LongestConsecutives
{

    public static string LongestConsec(string[] strarr, int k)
    {
        if (k > strarr.Length || strarr.Length == 0 || k <= 0)
        {
            return string.Empty;
        }

        var currentStr = string.Empty;
        for (var i = 0; i < strarr.Length; i++)
        {
            var str = string.Empty;
            for (var j = i; j < k + i && j < strarr.Length; j++)
            {
                str += strarr[j];
            }

            if (currentStr.Length < str.Length)
            {
                currentStr = str;
            }
        }

        return currentStr;
    }
}
public class Kata
{

    public static int[] RoundUp(int number, int[] list)
    {

        if (list == null || list.Length == 0)
        {
            return Array.Empty<int>();
        }
        int[] result = list
        .OrderBy(i => Math.Abs(i - number))
        .GroupBy(i => Math.Abs(i - number))
        .First()
        .ToArray();

        return result;
    }


    public static string Solution(string str)
    {
        char[] result = str.ToCharArray();
        Array.Reverse(result);
        return new string(result);
       
    }
}