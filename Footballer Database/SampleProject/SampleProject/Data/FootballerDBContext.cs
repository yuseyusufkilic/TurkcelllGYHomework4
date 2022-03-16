using Microsoft.EntityFrameworkCore;
using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Data
{
    class FootballerDBContext: DbContext
    {
        public DbSet<Footballer> Footballers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }

        public DbSet<FootballerSponsor> FootballerSponsor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=YUSE;Database=FootballerDB2;Integrated Security=yes");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //many-to-many rs
            modelBuilder.Entity<FootballerSponsor>()
                .HasKey(key => new { key.FootballerId, key.SponsorId });

            modelBuilder.Entity<FootballerSponsor>()
                .HasOne(fb => fb.Footballer)
                .WithMany(ft => ft.FootballerSponsors)
                .HasForeignKey(fk => fk.FootballerId);

            modelBuilder.Entity<FootballerSponsor>()
                .HasOne(s => s.Sponsor)
                .WithMany(fs => fs.FootballerSponsors)
                .HasForeignKey(fk => fk.SponsorId);

            // one-to-many rs
            modelBuilder.Entity<Team>()
                .HasMany(fb => fb.Footballer).WithOne(tm => tm.Team);

            
            
            

            modelBuilder.Entity<Footballer>()
                .HasOne(fb => fb.Team)
                .WithMany(fbt => fbt.Footballer);

            //adding data to every entity

            modelBuilder.Entity<Team>().HasData(new Team { TeamId = 1, Name = "Fenerbahçe", });
            
            

            modelBuilder.Entity<Footballer>().HasData(new Footballer { FootballerId = 1, Name = "Ferdi", Surname = "Kadıoğlu",TeamId=1 });
            
            modelBuilder.Entity<Sponsor>().HasData(new Sponsor { SponsorId = 1, Name = "Carlsberg"  });

            modelBuilder.Entity<FootballerSponsor>().HasData(new FootballerSponsor { FootballerId = 1, SponsorId = 1, });

            

            


        }

    }
}
