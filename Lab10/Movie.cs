using System.Collections.Generic;
namespace Lab10

{
    class Movie
    {
        private string title;
        private string category;

        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
            System.Console.WriteLine(title + " " + category);


        }
        public static void PresentList(List<Movie> action, List<Movie> sciFi, List<Movie> animation, List<Movie> comedy)
        {

        }
    }
}
