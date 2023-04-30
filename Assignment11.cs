using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanKumarcl_Assignments_Fai
{
   
    class Assignment11
    {
        static double CalculateInterest(double principleAmount, int termInMonths, double interestRate)
        {
            double interestAmount = (principleAmount * interestRate * termInMonths) / 12;
            return interestAmount;

        }
        static void Main(string[] args)
        {
            double principle = 1000;
            int termInMonths = 12;
            double rate = 0.05;

            double interest = CalculateInterest(principle, termInMonths, rate);
            Console.WriteLine("Interest amount: "+interest);
        }
    }
}
