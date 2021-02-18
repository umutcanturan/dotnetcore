using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Data.Factory
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseNpgsql("User ID=DotnetDbUser;Password=dotnet123;Server=62.171.149.43;Port=8085;Database=DotnetDb;Integrated Security=true;Pooling=true;");
            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}
