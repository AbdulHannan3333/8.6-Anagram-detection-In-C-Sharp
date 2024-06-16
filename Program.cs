using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6_Anagram_detection
{
    internal class Program
    {
        static bool AreAnagram(string str1, string str2) 
        {
            // Check String Length
            if (str1.Length != str2.Length) 
            {
                return false;
            }
            //Character Count Array
            int[] charcount = new int[256];
            //Count Character in First String
            foreach (char c in str1)
            {
                charcount[c]++;
            }
            //Reduce Count for Second Sreing
            foreach (char c in str2)
            {
                charcount[c]--;
            }
            // Check All Counts Are Zero 
            for (int i = 0; i < charcount.Length; i++) 
            {
                if (charcount[i] != 0) 
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string str1 = "listen";
            string str2 = "silent";
            if (AreAnagram(str1, str2))
            {
                Console.WriteLine($"{str1} and {str1} are Anagram");
            }
            else 
            {
                Console.WriteLine($"{str1} and {str2} are Not Anagram");
            }
        }
    }
}
