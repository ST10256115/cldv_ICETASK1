using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryApplication.Models;

namespace LibraryApplication.Data
{
    public class LibraryApplicationContext : DbContext
    {
        public LibraryApplicationContext (DbContextOptions<LibraryApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryApplication.Models.Books> Books { get; set; } = default!;
    }
}
