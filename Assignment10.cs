using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanKumarcl_Assignments_Fai
{
    class Assignment10
    {
        static string inWords(int num)
        {
            string[] units = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine","Ten","Eleven","Twelve","Thirtheen","Fourteen","Fifteen","Sixtee","Seventeen","Eighteen","NineTheen"};
            string[] tens = { "", "", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
            string words = "";

            if(num >= 10000000)
            {
                words += units[num / 10000000] + " Crore";
                num %= 10000000;
            }

            if(num >= 1000000)
            {
                words += units[num / 1000000] + " Lakh";
                num %= 1000000;
            }

            if (num >= 1000)
            {
                words += units[num / 1000] + "Thounsand";
                num %= 1000;
                Console.WriteLine(num);
            }

            

            if (num >= 100)
            {
                words += units[num / 100] + "hundred";
                num %= 100;
                Console.WriteLine(num);
            }

            if(num >= 10)
            {
                words += tens[num / 10];
                num %= 10;
                Console.WriteLine(num);
            }
           if(num % 10 > 0)
            {
                words += units[num];
            }

            return words.Trim();
        }
        static void Main(string[] args)
        {
            int num = 12000;
            string words = inWords(num);
            Console.WriteLine(words);
        }
    }
}
