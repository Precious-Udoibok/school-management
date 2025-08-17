using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SchoolManagement.Persistence
{
    public class SchoolManagementDbContextFactory : IDesignTimeDbContextFactory<SchoolManagementDbContext>
    {
        public SchoolManagementDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SchoolManagementDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=SchoolManagementDB;Trusted_Connection=True;TrustServerCertificate=True;");

            return new SchoolManagementDbContext(optionsBuilder.Options);
        }
    }
}

