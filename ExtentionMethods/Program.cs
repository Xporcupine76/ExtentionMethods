using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace ExtentionMethods
{

    class program
    {

        static void Main(string[] args)
        {
            string x = "Hello world";
            string y = "hello";
            Console.WriteLine(x + " is captialized " + x.IsCap());
            Console.WriteLine(y + " is captialized " + y.IsCap());

        }

    }
    public static class StringCap
    {
        public static bool IsCap(this string s)
        {

            if(string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);    


        }

    }
}

