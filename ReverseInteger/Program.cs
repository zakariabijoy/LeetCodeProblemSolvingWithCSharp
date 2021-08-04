using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(1534236469));
        }

        public static int Reverse(int x)
        {
            var val = x.ToString();
            string result="";
            for (int i = val.Length-1; i <= val.Length; i--)
            {
                if (val[0] == '-')
                {
                    if (result.Contains('-'))
                    {

                        if (i == 0)
                            break;
                        if (i < 0)
                            break;
                        result += val[i];
                    }
                    else
                    {   
                        result += val[0];
                        result += val[i];
                        continue;
                    }

                }
                else
                {
                    if (i < 0)
                        break;
                    result += val[i];
                    continue;
                }
               
            }
            try
            {
                return int.Parse(result);
            }
            catch (Exception)
            {

                return 0;
            }
           
        }
    }
}
