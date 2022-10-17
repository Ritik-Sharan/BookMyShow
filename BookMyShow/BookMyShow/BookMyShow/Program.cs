using BookMyShowPL;
using System;

namespace BookMyShow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoviePL moviePL = new MoviePL();
            TheatrePL theatrePL = new TheatrePL();
            ShowTimingPL showTimingPL = new ShowTimingPL();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Cinema Roulette ----------!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) To go to Movie-Section");
            Console.WriteLine("2) To go to Theatre-Section");
            Console.WriteLine("3) To go to ShowTiming-Section");
            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    {
                        moviePL.MovieMenu();
                        break;
                    }
                case 2:
                    {
                        theatrePL.TheatreMenu();
                        break;
                    }
                case 3:
                    {
                        showTimingPL.ShowTimingMenu();
                        break;
                    }
            }
        }
    }
}
