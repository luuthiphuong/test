using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo.Models;
using MvcMovie.Models;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Demo.Models.Product> Product { get; set; }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
