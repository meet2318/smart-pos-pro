using Microsoft.EntityFrameworkCore;
using SmartPOS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPOS.Persistence.AppDbContext
{
    public class SmartPOSDbContext : DbContext
    {
        public SmartPOSDbContext(DbContextOptions<SmartPOSDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
