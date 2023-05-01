using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanKumarcl_Assignments_Fai
{
     abstract class Account
    {
        public long AccountNo { get; set; }
        public string HolderName { get; set; }
        public int HolderId { get; set; }
        public int Balance { get; set; }
        public void CreditAmount(int Amount) => Balance += Amount;

        public void DebitAccount(int Amount)
        {
            if(Amount > Balance)
            {
                throw new Exception("Insufficient funds");
            }
            else
            {
                Balance -= Amount;
            }
        }

        public abstract void CalculateInterest();
    }

    class SBAccount : Account
    {
        public override void CalculateInterest()
        {
            int principal = Balance;
            double term = 0.25;
            double rateOfInterest = 6.5 / 100;
            double interestAmount = principal * term * rateOfInterest;
            CreditAmount((int)interestAmount);

        }
    }

    class FDAccount : Account
    {
        public override void CalculateInterest()
        {
            int principal = Balance;
            double term = 0.25;
            double rateOfInterest = 6.5 / 100;
            double interestAmount = principal * (1 + rateOfInterest / 100) * 3 - principal;
            Console.WriteLine("This is the interest for Fd Account");
            CreditAmount((int)interestAmount);
        }
    }

    class RDAccount : Account
    {
        public override void CalculateInterest()
        {
            int principal = Balance;
            double term = 0.25;
            double rateOfInterest = 6.5 / 100;
            double interestAmount = principal * (1 + rateOfInterest / 100) * 3 - principal;
            Console.WriteLine("This is the interest for Fd Account");
            CreditAmount((int)interestAmount);
        }
    }

    class AccountFactory
    {
        public static Account ChooseAccount(string type)
        {
            if (type == "SB")
            {
                return new SBAccount();
            }
            else if (type == "FD")
            {
                return new FDAccount();
            }
            else return new RDAccount();
        }
    }
    class Assignment13
    {
        static void Main(string[] args)
        {
            string type = UiConsole.GetString("ENter the Account type SB || RD || FD");
            Account acc = AccountFactory.ChooseAccount(type);
            acc.AccountNo = UiConsole.GetLong("ENter the account number");
            acc.HolderName = UiConsole.GetString("ENter the Name");
            acc.HolderId = UiConsole.GetNumber("Enter the Account Id");
            acc.CreditAmount(45000);
            acc.CalculateInterest();
            Console.WriteLine("The Current Balance is "+acc.Balance);
        }
    }
}
