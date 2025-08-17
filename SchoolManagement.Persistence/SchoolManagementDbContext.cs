
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace SchoolManagement.Persistence
{
    internal class SchoolManagementDbContext : DbContext
    {
        public SchoolManagementDbContext(DbContextOptions<SchoolManagementDbContext>options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DataSet<>
    }
}
