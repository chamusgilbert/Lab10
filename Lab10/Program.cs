using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> movieTitles = new List<string> { "Indiana Jones", "Star Wars", "Toy Story", "Monsters Inc.", "Alien", "Sahara", "Happy Gilmore", "The Wedding Singer", "Yellow Submarine", "The Lego Movie" };
            List<string> movieCategory = new List<string> { "Action/Adventure", "Sci-Fi", "Animation", "Animation", "Sci-Fi", "Action/Adventure", "Comedy", "Comedy", "Animation", "Animation" };
            Movie[] movie = new Movie[10];
            List<Movie> listOfMovie = new List<Movie>();
            List<Movie> listOfAction = new List<Movie>();
            List<Movie> listOfSciFi = new List<Movie>();
            List<Movie> listOfAnimation = new List<Movie>();
            List<Movie> listOfComedy = new List<Movie>();

            for (int i = 0; i < movieTitles.Count; i++)
            {
                movie[i] = new Movie(movieTitles.ElementAt(i), movieCategory.ElementAt(i));
                listOfMovie.Add(movie[i]);

                if (movieCategory.ElementAt(i) == "Action/Adventure")
                {
                    listOfAction.Add(movie[i]);
                }
                else if (movieCategory.ElementAt(i) == "Sci-Fi")
                {
                    listOfSciFi.Add(movie[i]);
                }
                else if (movieCategory.ElementAt(i) == "Animation")
                {
                    listOfAnimation.Add(movie[i]);
                }
                else
                {
                    listOfComedy.Add(movie[i]);
                }
            }

            PresentList(listOfMovie);

        }
        public static void PresentList(List<Movie> moviess)
        {
            Console.WriteLine("Pick a movie type");
            string userType = Console.ReadLine().ToLower();
            if (userType == "action" || userType == "adventure")
            {
                foreach (Movie item in moviess)
                {
                    if (item.category == "Action/Adventure")
                    {
                        Console.WriteLine(item.title);
                    }
                }
            }
            else if (userType == "sci-fi")
            {
                foreach (Movie item in moviess)
                {
                    if (item.category == "Sci-Fi")
                    {
                        Console.WriteLine(item.title);
                    }
                }
            }
            else if (userType == "comedy")
            {
                foreach (Movie item in moviess)
                {
                    if (item.category == "Comedy")
                    {
                        Console.WriteLine(item.title);
                    }
                }
            }
            else if (userType == "animation")
            {
                foreach (Movie item in moviess)
                {
                    if (item.category == "Animation")
                    {
                        Console.WriteLine(item.title);
                    }
                }
            }
            else
            {
                Console.WriteLine("I do not have that file in our directory");
                PresentList(moviess);
            }
        }
    }
}
