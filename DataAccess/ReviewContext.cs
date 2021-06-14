using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLibrary.DataAccess
{
    public class ReviewContext : DbContext
    {
        public ReviewContext(DbContextOptions options) : base(options) { }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
