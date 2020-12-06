using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stanciu_Madalina_Lab8.Models;

namespace Stanciu_Madalina_Lab8.Data
{
    public class Stanciu_Madalina_Lab8Context : DbContext
    {
        public Stanciu_Madalina_Lab8Context (DbContextOptions<Stanciu_Madalina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Stanciu_Madalina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Stanciu_Madalina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Stanciu_Madalina_Lab8.Models.Category> Category { get; set; }
    }
}
