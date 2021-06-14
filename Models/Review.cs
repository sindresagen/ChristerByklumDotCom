using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Headline { get; set; }
        public string Name { get; set; }
        public string TastingNote { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int Points { get; set; }
        public string DrinkingWindow { get; set; }
        public int ItemNumber { get; set; }
        public DateTime DateOfTasting { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
