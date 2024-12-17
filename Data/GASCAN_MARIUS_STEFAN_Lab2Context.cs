using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GASCAN_MARIUS_STEFAN_Lab2.Models;

namespace GASCAN_MARIUS_STEFAN_Lab2.Data
{
    public class GASCAN_MARIUS_STEFAN_Lab2Context : DbContext
    {
        public GASCAN_MARIUS_STEFAN_Lab2Context (DbContextOptions<GASCAN_MARIUS_STEFAN_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<GASCAN_MARIUS_STEFAN_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<GASCAN_MARIUS_STEFAN_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<GASCAN_MARIUS_STEFAN_Lab2.Models.Author> Author { get; set; } = default!;
       
    }
}
