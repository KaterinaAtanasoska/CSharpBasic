using ProjectLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary.Model
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Year { get; set; }
        public Genre GenreType { get; set; }
        private double Price { get; set; }
        public int MovieQuantity { get; set; }
        public Movie() { }
        public Movie(string title, string description, DateTime year, Genre genreType, int quantity) 
        {
            Title = title;
            Description = description;
            Year = year;
            GenreType = genreType;
            MovieQuantity = quantity;
        }

        public double SetPrice()
        {
            if (Year.Year < 2000)
            {
                Price = new Random().Next(100, 200);
            }
            else if (Year.Year > 2000 && Year.Year < 2010)
            {
                Price = new Random().Next(200, 300);
            }
            else if (Year.Year > 2010)
            {
                Price = new Random().Next(300, 500);
            }

            return Price;
        }

    }
}
