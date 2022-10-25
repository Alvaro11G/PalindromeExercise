using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str)
        {
            //reverse word
            var reversed = "";
            str = str.ToLower();
            for(int i = str.Length -1; i >= 0; i--)
            {
                reversed += str[i];
            }
            //compare the original with reversed
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
