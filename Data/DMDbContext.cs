using System;
using System.Collections.Generic;
using System.Text;
using DealsMo.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DealsMo.Data
{
    public class DMDbContext : IdentityDbContext
    {
        public DMDbContext(DbContextOptions<DMDbContext> options)
            : base(options)
        {
        }

        public DbSet<DealCategory> DealCategories { get; set; }
    }
}
