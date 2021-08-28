using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
        }

        public static bool IsPalindrome(int x)
        {
            var val = x.ToString();
            string result = string.Empty;

            for (int i = val.Length -1 ; i < val.Length; i--)
            {
                if (i >= 0)
                {
                    result = $"{result}{val[i]}";
                }
                else
                {
                    break;
                }

                
            }

           

            if (x.ToString() == result) return true;

            return false;
        }
    }
}
