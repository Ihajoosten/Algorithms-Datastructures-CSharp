using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures
{
    public class IsPalindrome
    {
        public static bool IsPalindromeOrNot(String s)
        {
            int N = s.Length;
            bool isPalindrome = false;
            for (int i = 0; i < (N / 2); i++)
            {
                if (s[i] != s[N - 1 - i])
                {
                    return false;
                }
                isPalindrome = true;
            }
            return isPalindrome;
        }
    }
}
