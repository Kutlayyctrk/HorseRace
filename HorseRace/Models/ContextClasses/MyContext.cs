using HorseRace.Models.Configurations;
using HorseRace.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new HorseConfiguration());
            modelBuilder.Configurations.Add(new JockeyConfiguration());
            modelBuilder.Configurations.Add(new RaceConfiguration());
            modelBuilder.Configurations.Add(new RaceDayConfiguration());
            modelBuilder.Configurations.Add(new RaceCardConfiguration());

            base.OnModelCreating(modelBuilder);

        }


        public DbSet<Horse> Horses { get; set; }
        public DbSet<Jockey> Jockeys { get; set; }

        public DbSet<Race> Races { get; set; }

        public DbSet<RaceDay> RaceDays { get; set; }

        public DbSet<RaceCard> RaceCards { get; set; }
    }
}
