using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext: DbContext
    {
        private readonly DbContextOptions<ApplicationDbContext> options;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.options = options;
        }
        public DbSet<Item> Items { get; set; }
    }
}
