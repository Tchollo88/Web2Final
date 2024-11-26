using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Holloman_Web2Final.Models;

namespace Holloman_Web2Final.Data
{
    public class Holloman_Web2FinalDb : DbContext
    {
        public Holloman_Web2FinalDb (DbContextOptions<Holloman_Web2FinalDb> options)
            : base(options)
        {
        }

        public DbSet<Holloman_Web2Final.Models.Customer> Customer { get; set; } = default!;
    }
}
