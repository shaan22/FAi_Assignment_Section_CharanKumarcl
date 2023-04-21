using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanKumarcl_Assignments_Fai
{
    class Assignment4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the Array");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the data type give System.typename");
            string typeName = Console.ReadLine();
            Type selectedType = Type.GetType(typeName, false, true);
            if (selectedType == null)
            {
                Console.WriteLine("Invalid Cts type");
                return;
            }
            Array instance = Array.CreateInstance(selectedType, size);



            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the value of the array at index {0} for datatype{1}", i, selectedType);
                string input = Console.ReadLine();
                instance.SetValue(Convert.ChangeType(input, selectedType), i);
            }
            Console.WriteLine("All the elements of the Array");
            foreach (var item in instance)
            {
                Console.WriteLine(item);
            }



        }
    }
}
