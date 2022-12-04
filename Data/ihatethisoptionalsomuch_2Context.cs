using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ihatethisoptionalsomuch_2.Models;

namespace ihatethisoptionalsomuch_2.Data
{
    public class ihatethisoptionalsomuch_2Context : DbContext
    {
        public ihatethisoptionalsomuch_2Context (DbContextOptions<ihatethisoptionalsomuch_2Context> options)
            : base(options)
        {
        }

        public DbSet<ihatethisoptionalsomuch_2.Models.Book> Book { get; set; } = default!;

        public DbSet<ihatethisoptionalsomuch_2.Models.Publisher> Publisher { get; set; }
    }
}
