using System;
using System.Collections.Generic;

namespace Lab10
{


    class Test
    {
        public static void PresentList(List<Movie> moviess)
        {
            Console.WriteLine("Pick a movie type");
            string userType = "action";
            if (userType == "action")
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
