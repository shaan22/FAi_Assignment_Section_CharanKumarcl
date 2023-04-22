using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanKumarcl_Assignments_Fai
{
   
    class Assignment6
    {
        static bool isValidDate(int year, int month, int day)
        {
            
            if (year < 1 || month < 1 || month > 12 || day < 1 || day > DateTime.DaysInMonth(year,month))
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[][] dates = new int[][]
            {
                new int[] {2018,13,1},
                 new int[] {2018,2,29},
                  new int[] {2016,2,23},
            };

            foreach(int[] date in dates)
            {
                bool isValid = isValidDate(date[0], date[1], date[2]);
                Console.WriteLine("{0}-{1}-{2}: {3}", date[0],date[1],date[2],isValid ? "Valid" : "Invalid");
            }
        }
    }
}
