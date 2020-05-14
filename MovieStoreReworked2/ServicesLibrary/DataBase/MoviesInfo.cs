using ProjectLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLibrary
{
    public class MoviesInfo
    {
        public static Movie[] Movies = new Movie[]
        {
            new Movie("Dumb and Dumber", "Movie Description", new DateTime (1994, 12, 6), ProjectLibrary.Enum.Genre.Comedy, 4),
            new Movie("Annabelle", "Movie Description", new DateTime (2014, 10, 9), ProjectLibrary.Enum.Genre.Horror, 6),
            new Movie("Dolittle", "Movie Description", new DateTime (2020, 1, 1), ProjectLibrary.Enum.Genre.Adventure, 2),
            new Movie("John Wick", "Movie Description", new DateTime (2014, 12, 4), ProjectLibrary.Enum.Genre.Action, 4),
            new Movie("The Godfather", "Movie Description", new DateTime (1972, 3, 24), ProjectLibrary.Enum.Genre.Crime, 1),
            new Movie("Parasite", "Movie Description", new DateTime (2019, 11, 8), ProjectLibrary.Enum.Genre.Drama, 7),
            new Movie("Logan", "Movie Description", new DateTime (2017, 3, 3), ProjectLibrary.Enum.Genre.Drama, 4),
            new Movie("Side Effects", "Movie Description", new DateTime (2013, 2, 8), ProjectLibrary.Enum.Genre.Mystery, 3)
        };

        public static void ShowMovies()
        {
            foreach (Movie movie in MoviesInfo.Movies)
            {
                if (movie.MovieQuantity >= 1)
                {
                    Console.WriteLine($"Title: {movie.Title} | Description: {movie.Description} " +
                        $"| Realese year: {movie.Year.Year} | Genre: {movie.GenreType} | Price: {movie.SetPrice()} " +
                        $"| Movie quantity: {movie.MovieQuantity}");
                }                
            }
        }
        public static void SelectMovie()
        {
            Console.WriteLine("Movies for renting:");
            ShowMovies();

            Console.WriteLine("Input the title of the movie you like to rent:");
            string TitleForRent = Console.ReadLine();
            bool incorrectInputTitle = false;

            foreach (Movie movie in MoviesInfo.Movies)
            {
                if (movie.Title == TitleForRent)
                {
                    if (movie.MovieQuantity >= 1)
                    {
                        List<Movie> listMovie = new List<Movie>(MembersInfo.UserLogged.Movies);
                        listMovie.Add(movie);
                        MembersInfo.UserLogged.Movies = listMovie.ToArray();
                        movie.MovieQuantity--;
                        Console.WriteLine($"Thank you for renting {TitleForRent}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, movie is already rented.");
                    }
                }
                else
                {
                    incorrectInputTitle = true;                    
                }
            }

            if (incorrectInputTitle == true)
            {
                Console.WriteLine($"No results to show with {TitleForRent}");
            }
        }        
    }
}
