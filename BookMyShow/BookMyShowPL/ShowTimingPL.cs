using BookMyShowBLL;
using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowPL
{
    public class ShowTimingPL
    {
        static ShowTimingBLL showTimingBLL = new ShowTimingBLL();
        TheatreBLL theatreBLL = new TheatreBLL();
        public void ShowTimingMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to ShowTiming-Section ----------!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) To add ShowTiming");
            Console.WriteLine("2) To delete ShowTiming");
            Console.WriteLine("3) To update ShowTiming");
            Console.WriteLine("4) To show all ShowTiming");
            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    {
                        AddShowTimingPL();
                        ShowTimingMenu();
                        break;
                    }
                //case 2:
                //    {
                //        DeleteShowTimingPL();
                //        ShowTimingMenu();
                //        break;
                //    }
                //case 3:
                //    {
                //        UpdateShowTimingPL();
                //        ShowTimingMenu();
                //        break;
                //    }
                case 4:
                    {
                        ShowAllShowTimingPL();
                        ShowTimingMenu();
                        break;
                    }
            }
        }

        public void AddShowTimingPL()
        {
            ShowTiming showTiming = new ShowTiming();
            Console.WriteLine("Enter MovieId : ");
            showTiming.MovieId =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter TheatreId : ");
            showTiming.TheatreId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ShowTime : ");
            showTiming.ShowTime = Convert.ToDateTime(Console.ReadLine());

            string msg = showTimingBLL.AddShowTimingBLL(showTiming);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("New ShowTime added successfully!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void ShowAllShowTimingPL()
        {
            List<ShowTiming> showTimings = showTimingBLL.ShowShowTimingBLL();
            foreach (var item in showTimings)
            {
                Console.WriteLine("Id : " + item.Id);
                Console.WriteLine("MovieId : " + item.MovieId);
                Console.WriteLine("TheatreId : " + item.TheatreId);
                Console.WriteLine("ShowTime : " + item.ShowTime);
            }
        }
        public void DeleteTheatresPL()
        {
            Theatre theatre = new Theatre();
            Console.WriteLine("Enter TheatreId : ");
            var theareId = Convert.ToInt32(Console.ReadLine());
            theatreBLL.DeleteMovieBLL(theareId);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Theatre Deleted Successfully");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void UpdateTheatresPL()
        {
            Theatre theatre = new Theatre();
            Console.Write("Enter Theatre Id:");
            theatre.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter TheatreName : ");
            theatre.Name = Console.ReadLine();
            Console.WriteLine("Enter Theatre Address : ");
            theatre.Address = Console.ReadLine();
            Console.WriteLine("Enter Theatre Comments : ");
            theatre.Comments = Console.ReadLine();

            theatreBLL.UpdateTheatreBLL(theatre);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Theatre Updated Successfully............");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
