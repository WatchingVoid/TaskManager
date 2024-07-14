using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaskManager.Models; 

namespace TaskManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Task> Tasks { get; set; }
    }
}