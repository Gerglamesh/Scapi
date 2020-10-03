using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SCAPI_Frontend.Models;

namespace SCAPI_Frontend.Context
{
    public class ScapiContext : DbContext
    {
        private readonly IConfiguration _config;

        public ScapiContext(IConfiguration config, DbContextOptions options) : base (options) 
        {
            _config = config;
        }

        public virtual DbSet<ChordModel> Chords { get; set; }
        public virtual DbSet<ChordDiagramModel> ChordDiagrams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
