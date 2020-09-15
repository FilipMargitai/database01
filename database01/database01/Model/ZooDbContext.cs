using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace database01.Model
{
    public class ZooDbContext : DbContext
    {
        public ZooDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Animal> Animals { get; set; }
    }
}
