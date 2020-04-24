using ProjectLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary.Model
{
    class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Year { get; set; }
        public Genre GenreType { get; set; }
        private double Price { get; set; }

        public Movie() { }
        public Movie(string title, string description, DateTime year, Genre genreType) 
        {
            Title = title;
            Description = description;
            Year = year;
            GenreType = genreType;
        }

        public void SetPrice()
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
        }
    }
}
