using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanKumarcl_Assignments_Fai
{
    enum Operation : byte
    {
        Add,
        Sub,
        Mul,
        Div,
        q

    }
    class Assignment03
    {
        static void Main(string[] args)
        {
            bool loop = true;
          
            while (loop)
            {
                Array Operations = Enum.GetValues(typeof(Operation));
                Console.WriteLine("Enter the Operation from the List Below");
                for (int i = 0; i < Operations.Length; i++)
                {
                    Console.WriteLine(Operations.GetValue(i));
                }
                string input = Console.ReadLine();
                object selectedType = Enum.Parse(typeof(Operation), input, true);
                Operation selected = (Operation)selectedType;
                string opt = selected.ToString();
                /* Operation selected = (Operation)Enum.Parse(typeof(Operation), Console.ReadLine(), true);
                 Console.WriteLine("selected Operatino is {0}", selected);*/
                if (opt == "q")
                {
                    loop = false;
                    continue;
                }

                int result = 0;

                Console.WriteLine("Enter the first value");
                int val1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second value");
                int val2 = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case "Add":
                        result = val1 + val2;
                        break;

                    case "Sub":
                        result = val1 - val2;
                        break;

                    case "Mul":
                        result = val1 * val2;
                        break;

                    case "Div":
                        result = val1 / val2;
                        break;

                    default:
                        Console.WriteLine("invalid");
                        break;
                }

                Console.WriteLine("Result"+result);
            }
        }
       
    }
}
