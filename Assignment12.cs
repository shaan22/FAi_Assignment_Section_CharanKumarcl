using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanKumarcl_Assignments_Fai.Entities
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
    }

    namespace DataLayer
    {
        using Entities;

        interface ICustomerRepo 
        {
            void AddCustomer(Customer customer);
            bool DeleteCustomer(int id);
            void UpdateCustomer(Customer customer);
            Customer FindCustomerById(int id);
        }

        class CustomerRepo : ICustomerRepo
        {
            const int size = 100;
            Customer[] customers = new Customer[size];

            public void AddCustomer(Customer customer)
            {
                for(int i = 0; i < size; i++)
                {
                    if(customers[i] == null)
                    {
                        customers[i] = new Customer
                        {
                            CustomerId = customer.CustomerId,
                            CustomerName = customer.CustomerName,
                            CustomerAddress = customer.CustomerAddress

                        };
                        break;
                       
                    }
                }
            }

           

            public bool DeleteCustomer(int id)
            {
                for(int i = 0; i < size; i++)
                {
                    if(customers[i] != null && customers[i].CustomerId == id)
                    {
                        customers[i].CustomerId = 0;
                        customers[i].CustomerAddress = null;
                        customers[i].CustomerName = null;
                        return true;
                    }
                   
                }
                return false;

            }

            public Customer FindCustomerById(int id)
            {
                for(int i = 0; i < size; i++)
                {
                    if (customers[i] != null && customers[i].CustomerId == id)
                    {
                        return customers[i];
                    }
                }
                return null;
              
            }

            public void UpdateCustomer(Customer customer)
            {
               for(int i = 0; i < size; i++)
                {
                    if(customers[i] != null && customers[i].CustomerId == customer.CustomerId)
                    {
                        customers[i].CustomerId = customer.CustomerId;
                        customers[i].CustomerName = customer.CustomerName;
                        customers[i].CustomerAddress = customer.CustomerAddress;
                    }
                    Console.WriteLine("Customers is updated");
                }
            }
        }

    }
    namespace UiLayer
    {
        using DataLayer;
        using System.IO;

        class Assignment12
        {

            static CustomerRepo customerManager = new CustomerRepo();
            const string filePath = @"C:\Users\ckumarcl\source\repos\CharanKumarcl-Assignments-Fai\CharanKumarcl-Assignments-Fai\CustomerMenu.txt";

            static string Menu()
            {
                Console.WriteLine("Enter Your choice");
                Console.WriteLine();
                return File.ReadAllText(filePath);
            }

            static void clearScreen()
            {
                Console.WriteLine("Press any KEy to clear");
                Console.ReadKey();
                Console.Clear();
            }

            static void Main(string[] args)
            {
               string menu =  Menu();
                bool state = true;
                do
                {
                    string choice = UiConsole.GetString(menu);
                    state = ProcessMenu(choice);
                } while (state);
            }

            static bool ProcessMenu(string choice)
            {
                switch (choice)
                {
                    case "N":
                        addingCustomerHelper(); return true;
                    case "U":
                        updateCustomerHelper();
                        return true;
                    case "F":
                        findingCustomerHelper();
                        return true;
                    case "D":
                        DeleteCustomerHelper();
                        return true;

                    default:
                        return false;
                }
            }

            private static void findingCustomerHelper()
            {

                int id = UiConsole.GetNumber("Enter the customer id to find");
                Customer customer1 = customerManager.FindCustomerById(id);
                if(customer1 != null)
                {
                    Console.WriteLine("Customer found");
                }else
                {
                    Console.WriteLine("Not Found");
                }
                    
                
            }

            private static void updateCustomerHelper()
            {
                Customer customerobj = new Customer();
                customerobj.CustomerId = UiConsole.GetNumber("Enter the Customer Id");
                customerobj.CustomerAddress = UiConsole.GetString("Enter the address");
                customerobj.CustomerName = UiConsole.GetString("Enter the Customer Name");
                customerManager.UpdateCustomer(customerobj);
                Console.BackgroundColor = ConsoleColor.Green;
                UiConsole.PrintMessage("Cusomter Updateed SUccessfully");
            }

            private static void addingCustomerHelper()
            {
                Customer customerobj = new Customer();
                customerobj.CustomerId = UiConsole.GetNumber("Enter the Customer Id");
                customerobj.CustomerAddress = UiConsole.GetString("Enter the address");
                customerobj.CustomerName = UiConsole.GetString("Enter the Customer Name");
                customerManager.AddCustomer(customerobj);
                Console.BackgroundColor = ConsoleColor.Green;
                UiConsole.PrintMessage("Cusomter Added SUccessfully");
                
            }

            private static void DeleteCustomerHelper()
            {
                int id = UiConsole.GetNumber("Enter the customer id to Delete");
                bool state = customerManager.DeleteCustomer(id);
                if (state)
                {
                    Console.WriteLine(" Customer Deletion successful");
                }else
                {
                    Console.WriteLine("Not Found");
                }
            }
            
        }
    }
   
}
