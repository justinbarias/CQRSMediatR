using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using cqrsmediatr.domain.models;

namespace cqrsmediatr.persistence
{
    public class ApiDbContextFactory : IDesignTimeDbContextFactory<ApiContext>
    {
        public ApiDbContextFactory ()
        {
        }

        public ApiContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ApiContext>();
            var connectionString = configuration.GetConnectionString("TodoDatabase");

            builder.UseSqlServer(connectionString);

            return new ApiContext(builder.Options);
        }
    }
}
