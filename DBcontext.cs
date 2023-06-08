using Microsoft.EntityFrameworkCore;
using LLL_api.Models;

namespace LLL_api
{
    public class DBcontext : DbContext
    {

        public DBcontext(DbContextOptions<DBcontext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DBcontext");
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<InformationModel> Information { get; set; }



    }
}
