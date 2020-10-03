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
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Check Constraints
            builder.Entity<ChordModel>(c => c.HasCheckConstraint("CK_ChordModel_ChordType", "[ChordType] IN ('Open', 'Barré')"));

            //Seeding
            builder.Entity<ChordModel>().HasData(new ChordModel
            {
                Id = 1,
                BaseNote = "C",
                FretPosition = 3,
                StartString = 5,
                TriadType = "Major",
                ChordType = "Open"                
            },
            new ChordModel 
            {
                Id = 2,
                BaseNote = "C",
                FretPosition = 3,
                StartString = 5,
                TriadType = "Major",
                ChordType = "Barré"
            },
            new ChordModel
            {
                Id = 3,
                BaseNote = "C",
                FretPosition = 8,
                StartString = 6,
                TriadType = "Major",
                ChordType = "Barré"
            },
            new ChordModel
            {
                Id = 4,
                BaseNote = "C",
                FretPosition = 10,
                StartString = 4,
                TriadType = "Major",
                ChordType = "Barré"
            },
            new ChordModel
            {
                Id = 5,
                BaseNote = "C",
                FretPosition = 10,
                StartString = 4,
                TriadType = "Major",
                ChordType = "Barré"
            });

            builder.Entity<ChordDiagramModel>().HasData(new ChordDiagramModel
            {
                Id = 1,
                Path = "Does not exist yet",
                ChordId = 1
            },
            new ChordDiagramModel
            {
                Id = 2,
                Path = "Does not exist yet",
                ChordId = 2
            },
            new ChordDiagramModel
            {
                Id = 3,
                Path = "Does not exist yet",
                ChordId = 3
            },
            new ChordDiagramModel
            {
                Id = 4,
                Path = "Does not exist yet",
                ChordId = 4
            },
            new ChordDiagramModel
            {
                Id = 5,
                Path = "Does not exist yet",
                ChordId = 5
            });
        }
    }
}
