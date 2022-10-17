using BookMyShowBLL;
using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowPL
{
    public class TheatrePL
    {
        static TheatreBLL theatreBLL = new TheatreBLL();
        public void TheatreMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Theatre-Section ----------!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) To add a Theatre");
            Console.WriteLine("2) To delete a Theatre");
            Console.WriteLine("3) To update a Theatre");
            Console.WriteLine("4) To show all Theatre");
            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    {
                        AddTheatrePL();
                        TheatreMenu();
                        break;
                    }
                case 2:
                    {
                        DeleteTheatresPL();
                        TheatreMenu();
                        break;
                    }
                case 3:
                    {
                        UpdateTheatresPL();
                        TheatreMenu();
                        break;
                    }
                case 4:
                    {
                        ShowAllTheatresPL();
                        TheatreMenu();
                        break;
                    }
            }
        }

        public void AddTheatrePL()
        {
            Theatre theatre = new Theatre();
            Console.WriteLine("Enter TheatreName : ");
            theatre.Name = Console.ReadLine();
            Console.WriteLine("Enter Theatre Address : ");
            theatre.Address = Console.ReadLine();
            Console.WriteLine("Enter Theatre Comments : ");
            theatre.Comments = Console.ReadLine();

            string msg = theatreBLL.AddTheatreBLL(theatre);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("New Theatre added successfully!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void ShowAllTheatresPL()
        {
            List<Theatre> theatres = theatreBLL.ShowAllBLL();
            foreach (var item in theatres)
            {
                Console.WriteLine("Id : " + item.Id);
                Console.WriteLine("Name : " + item.Name);
                Console.WriteLine("Address : " + item.Address);
                Console.WriteLine("Comment : " + item.Comments);
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
