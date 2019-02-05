using IdealeWareMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealeWareMVC.Data
{
    public class IdealeWareContext : DbContext
    {
        public IdealeWareContext(DbContextOptions<IdealeWareContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
