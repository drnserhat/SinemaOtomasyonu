using MovieApp.Enums;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:/Users/excalibur/Desktop/C#/MovieApp/MovieApp/Pictures/";
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "The Godfather",
                    category = Category.gerilim,
                    minute = "2 saat 50 dakika",
                    price = 50,
                    picturePath = basePath + "godfather.jpg"
                },
                new Movie()
                {
                    movieName = "Inception",
                    category = Category.bilim_kurgu,
                    minute = "2 saat 20 dakika",
                    price = 30,
                    picturePath = basePath + "inception.png"
                },
                new Movie()
                {
                    movieName = "Tenet",
                    category = Category.fantastik,
                    minute = "2 saat 20 dakika",
                    price = 20,
                    picturePath = basePath + "Tenet.jpg"
                },
                new Movie()
                {
                    movieName = "3 Idıot",
                    category = Category.komedi,
                    minute = "2 saat 25 dakika",
                    price = 45,
                    picturePath = basePath + "3aptal.jpg"
                },
                new Movie()
                {
                    movieName = "Transformers",
                    category = Category.aksiyon,
                    minute = "2 saat 10 dakika",
                    price = 35,
                    picturePath = basePath + "Transformers.jpg"
                },
                new Movie()
                {
                    movieName = "BORU",
                    category = Category.drama,
                    minute = "2 saat 3 dakika",
                    price = 15,
                    picturePath = basePath + "Boru.jpg"
                },
            };
        }
    }
}
