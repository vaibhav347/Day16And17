using System;

namespace Day16And17Anagram
{
    class Program
        {
            static void Main(string[] args)
            {
                string str1 = "cat";
                string str2 = "tca";
                char[] ch1 = str1.ToLower().ToCharArray();
                char[] ch2 = str2.ToLower().ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                string a = new string(ch1);
                string b = new string(ch2);

                if (a == b)
                {
                    Console.WriteLine("strings are Anagrams");
                }
                else
                {
                    Console.WriteLine("strings are not Anagrams");
                }
            }
        }
    }



