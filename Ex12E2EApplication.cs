using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace CharanKumarcl_Assignments_Fai
{
    namespace Entities
    {
        class Movies
        {
            public int MovieId { get; set; }
            public string MovieTitle { get; set; }
            public string MovieType { get; set; }
            public DateTime DateTime { get; set; }



            public int TicketPrice { get; set; }
        }
    }




    namespace DataLayer
    {
        using Entities;





        class ExpenseManager
        {
            const int size = 100;
            private Movies[] movieArr = new Movies[size];



            public void AddingExpense(Movies movie)
            {
                for (int i = 0; i < size; i++)
                {
                    if (movieArr[i] == null)
                    {
                        movieArr[i] = new Movies
                        {
                            MovieId = movie.MovieId,
                            MovieTitle = movie.MovieTitle,
                            MovieType = movie.MovieType,
                            DateTime = movie.DateTime,
                            TicketPrice = movie.TicketPrice
                        };
                        break;
                    }
                }

            }



            internal void UpdatingExpense(Movies movie)
            {
                for (int i = 0; i < size; i++)
                {
                    if (movieArr[i] != null && movieArr[i].MovieId == movie.MovieId)
                    {
                        movieArr[i].MovieId = movie.MovieId;
                        movieArr[i].MovieTitle = movie.MovieTitle;
                        movieArr[i].MovieType = movie.MovieType;
                        movieArr[i].DateTime = movie.DateTime;
                        movieArr[i].TicketPrice = movie.TicketPrice;





                    }
                }
            }



            internal void DeletingExpense(Movies movie)
            {
                for (int i = 0; i < size; i++)
                {
                    if (movieArr[i] != null && movieArr[i].MovieId == movie.MovieId)
                    {
                        movieArr[i].MovieId = 0;
                        movieArr[i].MovieTitle = null; ;
                        movieArr[i].MovieType = null;

                        movieArr[i].TicketPrice = 0;

                    }
                }
            }

           




public Movies[] GetAllExpense(string type)

            {

                int index = 0;

                foreach (Movies item in movieArr)

                {

                    if (item != null && item.MovieType.Contains(type))

                    {

                        index++;

                    }



                }



                if (index != 0)

                {

                    int tempVarialble = 0;

                    Movies[] FoundMovie = new Movies[index];

                    foreach (Movies item in movieArr)

                    {

                        if (item != null && item.MovieType.Contains(type))

                        {

                            FoundMovie[tempVarialble] = item;

                            tempVarialble++;

                        }



                    }

                    return FoundMovie;



                }

                else

                {

                    return null;

                }

            }



            internal Movies[] GetExpenseId(int Id)

            {
                Movies[] FoundMovie = new Movies[10];
                int i = 0;
                foreach (Movies item in movieArr)
                {
                    if(item != null && item.MovieId == Id)
                    {
                        FoundMovie[i] = item;
                        i++;
                    }
                }
                return FoundMovie;

            }





        }





    }



    namespace UiLayer

    {

        using Entities;

        using DataLayer;

        class Ex12E2EApplication

        {

            static ExpenseManager manager = new ExpenseManager();

            const string filePath = @"C:\Users\ckumarcl\source\repos\CharanKumarcl-Assignments-Fai\CharanKumarcl-Assignments-Fai\Menu.txt";

            static string GetMenu()

            {

                Console.WriteLine("Enter Your choice");

                Console.WriteLine();

                return File.ReadAllText(filePath);

            }



            static void clearScreeen()

            {

                Console.WriteLine("Press any Key to Clear");

                Console.ReadKey();

                Console.Clear();

            }

            static void Main(string[] args)

            {

                string menu = GetMenu();



                bool processing = true;

                do

                {



                    string choice = UiConsole.GetString(menu);



                    processing = processMenu(choice);

                    clearScreeen();

                } while (processing);



            }



            static bool processMenu(string choice)

            {

                switch (choice)

                {

                    case "N":

                        addingExpenseHelper(); return true;

                    case "U":

                        updateExpenseHelper();

                        return true;

                    case "F":

                        findingExpenseHelper();

                        return true;

                    case "D": return true;



                    default:

                        return false;

                }

            }



            private static void addingExpenseHelper()

            {

                Movies Movieobj = new Movies();

               Movieobj.MovieId = UiConsole.GetNumber("Enter the Movie Id Number");
                Movieobj.MovieTitle = UiConsole.GetString("Enter The Movie Title ");

                Movieobj.MovieType = UiConsole.GetString("Enter The Movie Type ");

                Movieobj.DateTime = UiConsole.GetDate("Enter the Date In DD/MM/YYYY");

                Movieobj.TicketPrice = UiConsole.GetNumber("Enter The Amount");


                manager.AddingExpense(Movieobj);

                UiConsole.PrintMessage("Entry Added Successfully");

                Console.BackgroundColor = ConsoleColor.Green;

            }



            public static void findingExpenseHelper()

            {

                string finder = UiConsole.GetString("ENter the Movie Detail or  apart of the detail to find");


                Movies[] movies = manager.GetAllExpense(finder);

                if (movies != null)

                {

                    foreach (Movies expense in movies)

                    {

                        Console.WriteLine($"The Movie Tile is{expense.MovieTitle}  on {expense.DateTime} and the ticket price is {expense.TicketPrice}");

                    }

                }

                else

                {

                    Console.WriteLine("No expense found ");

                }





            }



            public static void updateExpenseHelper()

            {

                Movies Movieobj = new Movies();

                Movieobj.MovieId = UiConsole.GetNumber("Enter the Movie Id Number");
                Movieobj.MovieTitle = UiConsole.GetString("Enter The Movie Title ");

                Movieobj.MovieType = UiConsole.GetString("Enter The Movie Type ");

                Movieobj.DateTime = UiConsole.GetDate("Enter the Date In DD/MM/YYYY");

                Movieobj.TicketPrice = UiConsole.GetNumber("Enter The Amount");

                manager.AddingExpense(Movieobj);

                UiConsole.PrintMessage("Updation Successful");

            }

        }



    }

}






