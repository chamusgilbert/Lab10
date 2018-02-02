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



        }
    }
}
