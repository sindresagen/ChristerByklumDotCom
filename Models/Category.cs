using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string District { get; set; }
        public string SubDistrict { get; set; }
        public string TypeOfWine { get; set; }
        public string Classification { get; set; }
        public string GrapeVariation { get; set; }
    }
}
