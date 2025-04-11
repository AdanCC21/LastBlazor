using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Data.Context
{
    public class MyDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Ruta Base
                .AddJsonFile("appsettings.json", optional: true) // archivo donde esta la conexcion a la base de datos
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();  
            var connectionString = config.GetConnectionString("ConexionBD");

            optionsBuilder.UseSqlServer(connectionString);

            return new MyDbContext(optionsBuilder.Options);
        }
    }
}