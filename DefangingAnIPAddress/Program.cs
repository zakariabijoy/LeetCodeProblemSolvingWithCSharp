using System;

namespace DefangingAnIPAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( DefangIPaddr("1.1.1.1"));
        }


        public static string DefangIPaddr(string address)
        {
            string ip = string.Empty;

            for (int i = 0; i < address.Length; i++)
            {
                if(address[i] == '.')
                {
                    ip = $"{ip}[{address[i]}]";
                }
                else
                {
                    ip = $"{ip}{address[i]}";
                }
                
            }

            return ip;
        }
    }
}
