using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);

            string str_reverse = new string(arr);

            if(str.ToLower().Equals(str_reverse.ToLower())) 
            {
                Console.WriteLine(str + " ->Its A palindrome string");
            }
            else
            {
                Console.WriteLine(str + " ->Its Not a palindrome string");
            }

            Console.ReadLine();

        }
    }
}
