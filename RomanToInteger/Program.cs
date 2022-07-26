using System;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("III"));
        }

        public static int RomanToInt(string s)
        {
            int result = 0;
            foreach (var item in s)
            {
                switch (item)
                {
                    case 'I':
                        result += 1;
                        break;
                    case 'V':
                        if(result == 1)
                        {
                            result = 4;
                        }
                        else
                        {
                            result += 5;
                        }
                        break;
                    case 'X':
                        if (result == 1)
                        {
                            result = 9;
                        }
                        else
                        {
                            result += 10;
                        }
                        break;
                    case 'L':
                        if (result == 10)
                        {
                            result =40 ;
                        }
                        else
                        {
                            result += 50;
                        }
                        break;
                    case 'C':
                        if (result == 10)
                        {
                            result = 90;
                        }
                        else
                        {
                            result += 100;
                        }
                        break;
                    case 'D':
                        if (result == 100)
                        {
                            result = 400;
                        }
                        else
                        {
                            result += 500;
                        }
                        break;
                    case 'M':
                        if (result == 100)
                        {
                            result = 900;
                        }
                        else
                        {
                            result += 1000;
                        }
                        break;

                    default:
                        break;
                }
            }

            return result;

        }
    }
}
