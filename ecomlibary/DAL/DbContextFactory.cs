using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecomlibary.DAL
{
    public class DbContextFactory: IDesignTimeDbContextFactory<finalEcom>
    {
        public finalEcom CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder();
            optionBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database=finalEcom; trusted_connection=true; ");
            return new finalEcom(optionBuilder.Options);

            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //   .SetBasePath(Directory.GetCurrentDirectory())
            //   .AddJsonFile("appsettings.json")
            //   .Build();

            //var optionsBuilder = new DbContextOptionsBuilder<finalEcom>();
            //var connectionString = configuration.GetConnectionString("DefaultConnection");
            //optionsBuilder.UseSqlServer(connectionString);

            //return new finalEcom(optionsBuilder.Options);
        }
    }
}
