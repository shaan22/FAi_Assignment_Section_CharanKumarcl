using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanKumarcl_Assignments_Fai
{
    class Assignment7
    {
        static bool isPrimeNumber(int num)
        {
            if(num <= 1)
            {
                return false;
            }
           
                for(int i = 2;i< Math.Sqrt(num); i++)
                {
                    if(num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            
        }

        static void Main(string[] args)
        {
            bool state = true;

            do
            {
                int num = UiConsole.GetNumber("ENter the number to check its prime");
                bool isprime = isPrimeNumber(num);
                Console.WriteLine("The given number {0} is {1}", num, isprime ? "isprime" : "notPrime");
                Console.WriteLine("Press C to Continue or E to exit");
                string type = Console.ReadLine();
                if(type == "E")
                {
                    state = false;
                }
            } while (state);
           

        }
    }
}
