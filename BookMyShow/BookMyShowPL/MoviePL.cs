using System;
using System.Collections.Generic;
using BookMyShowEntity;
using BookMyShowBLL;

namespace BookMyShowPL
{
    public class MoviePL
    {
        static MovieBLL movieBLL = new MovieBLL();
        public void MovieMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Movie-Section ----------!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) To add a Movie");
            Console.WriteLine("2) To delete a Movie");
            Console.WriteLine("3) To update a Movie");
            Console.WriteLine("4) To show all movies");
            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    {
                        AddMoviePL();
                        MovieMenu();
                        break;
                    }
                case 2:
                    {
                        DeleteMoviesPL();
                        MovieMenu();
                        break;
                    }
                case 3:
                    {
                        UpdateMoviesPL();
                        MovieMenu();
                        break;
                    }
                case 4:
                    {
                        ShowAllMoviesPL();
                        MovieMenu();
                        break;
                    }
            }
        }

            public void AddMoviePL()
            {
                Movie movie = new Movie();
                Console.WriteLine("Enter MovieName : ");
                movie.Name = Console.ReadLine();
                Console.WriteLine("Enter Movie Description : ");
                movie.MovieDesc = Console.ReadLine();
                Console.WriteLine("Enter Movie Type : ");
                movie.MovieType = Console.ReadLine();

                movieBLL.AddMovieBLL(movie);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("New Movie added successfully!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public void ShowAllMoviesPL()
            {
                List<Movie> movies = movieBLL.ShowAllBLL();
                foreach (var item in movies)
                {
                    Console.WriteLine("Id : " + item.Id);
                    Console.WriteLine("Name : " + item.Name);
                    Console.WriteLine("Description : " + item.MovieDesc);
                    Console.WriteLine("Type : " + item.MovieType);
                }
            }
            public void DeleteMoviesPL()
            {
               Movie movie = new Movie();
                Console.WriteLine("Enter MovieId : ");
                var movieId = Convert.ToInt32(Console.ReadLine());
                movieBLL.DeleteMovieBLL(movieId);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Movie Deleted Successfully");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public void UpdateMoviesPL()
            {
                Movie movie = new Movie();
                Console.Write("Enter Movie Id:");
                movie.Id = int.Parse(Console.ReadLine());
                Console.Write("Enter Movie Name:");
                movie.Name = Console.ReadLine();
                Console.Write("Enter Movie Description:");
                movie.MovieDesc = Console.ReadLine();
                Console.Write("Enter Movie Type:");
                movie.MovieType = Console.ReadLine();

                movieBLL.UpdateMovieBLL(movie);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movie Updated Successfully............");
                Console.ForegroundColor = ConsoleColor.White;
            }
    }
}
