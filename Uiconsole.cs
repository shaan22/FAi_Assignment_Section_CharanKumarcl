using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanKumarcl_Assignments_Fai
{
    class UiConsole
    {


        internal static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        internal static int GetNumber(String question)
        {
            return int.Parse(GetString(question));
        }
        internal static Double GetDouble(String question)
        {
            return double.Parse(GetString(question));
        }

        internal static long GetLong(string question)
        {
            return long.Parse(GetString(question));
        }

        internal static DateTime GetDate(string v)
        {
            Console.WriteLine(v);
            return DateTime.Parse(Console.ReadLine());
        }






        internal static void PrintMessage(string v)

        {

            var Oldbg = Console.BackgroundColor;


            Console.WriteLine(v);

            Console.BackgroundColor = ConsoleColor.Green;

            Console.BackgroundColor = Oldbg;

        }



    }
}
