using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanKumarcl_Assignments_Fai
{
    class Assignment9
    {
        private const char V = ' ';

        public static string reverseByWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            string[] reverseWords = new string[words.Length];

            for(int i = words.Length - 1,j =0; i >= 0; i--,j++)
            {
                reverseWords[j] = words[i];
            }

            // do stuff here
            return string.Join(" ",reverseWords);
        }
        static void Main(string[] args)
        {
            string bf = "My name charan i luv Bangalore";
            Console.WriteLine("The senteced before reverse");
            Console.WriteLine(bf);
            Console.WriteLine("The senteced after reverse");
            string af = reverseByWords(bf);
            Console.WriteLine(af);
        }
    }
}
