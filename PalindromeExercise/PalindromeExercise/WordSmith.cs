using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str)
        {
            var reversed = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }
            
            
            if(reversed == str)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
