using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanKumarcl_Assignments_Fai
{

   
    class Assignment8
    {
        static void Calender(int month, int year)
        {
            Console.WriteLine("{0} {1}", CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month),year);
            Console.WriteLine("Sun  Mon  Tue  Wed  Thu  Fri  Sat");

            int firstday = (new DateTime(year, month, 1)).DayOfWeek - DayOfWeek.Sunday;
            

            if(firstday < 0)
            {
                firstday += 7;
            }

            int dayInMonth = getDaysInMonth(month, year);
             
            for(int day = 1;day <= dayInMonth; day++)
            {
                if(day == 1)
                {
                    Console.Write(new string(' ',3*firstday));
                }
                Console.Write("{0,4}",day);

                if((day + firstday) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            if ((dayInMonth + firstday) % 7 != 0)
            {
                Console.WriteLine();
            }

        }

        static int getDaysInMonth(int month, int year)
        {
            if(month == 2)
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    return 29;
                }
                else return 28;
            }else if(month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }else
            {
                return 31;
            }
        }
        static bool IsValidDate(int month, int year)
        {

            if (year < 1 || month < 1 || month > 12)
            {
                Console.WriteLine("INvalid Input");
                return false;
            }
            else
            {
                Console.WriteLine("Valid");
                Calender(month,year);
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ENter the month and year to print Calender");
            Console.WriteLine("Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Year: ");
            int year = int.Parse(Console.ReadLine());
            IsValidDate(month, year);
        }
    }
}


 //|| day < 1 || day > DateTime.DaysInMonth(year, month)