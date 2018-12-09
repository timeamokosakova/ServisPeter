using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServisPeter.Models;

namespace ServisPeter.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ServisPeter.Models.Databaza> Databaza { get; set; }
        public DbSet<ServisPeter.Models.Pozns> Pozns { get; set; }
        public DbSet<ServisPeter.Models.Stroje> Stroje { get; set; }
    }
}
