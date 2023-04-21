using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanKumarcl_Assignments_Fai
{
    class Assignment02

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements");
            string v = Console.ReadLine();
            int n = int.Parse(v);
            int[] arr = new int[n];
            Console.WriteLine("ENter Array elements");
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    Console.WriteLine("Even Numbers ");
                    Console.WriteLine(arr[i]);
                }
                else
                {
                    Console.WriteLine("Odd Numbers ");
                    Console.WriteLine(arr[i]);
                }
            }
        }
        
    }
}
