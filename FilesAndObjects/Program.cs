using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FilesAndObjects
{
    class Program
    {
        class Movie
        {
            public string title;
            public string rating;
            public string year;

            public Movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Help Me!");
            string filePath = @"C:\Users\opilane\Samples";
            string fileName = @"imdb.txt";
            //a list to store the movies from the file
            List<string> movieList = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();
            List<Movie> listOfMovies = new List<Movie>();
            foreach (string movieItem in movieList)
            {
                string[] tempArray = movieItem.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]);

                listOfMovies.Add(newMovie);
            }

            foreach(Movie movie in listOfMovies)
            {
                Console.WriteLine($"Title: {movie.title}; Rating: {movie.rating}; Year: {movie.year}");
            }


        }
    }
}
