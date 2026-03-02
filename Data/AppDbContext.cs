using ado_cp_7.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ado_cp_7.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students => Set<Student>();
    }
}
