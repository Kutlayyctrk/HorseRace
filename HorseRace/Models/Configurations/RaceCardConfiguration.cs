using HorseRace.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.Configurations
{
    public class RaceCardConfiguration:BaseConfiguration<RaceCard>
    {
        public RaceCardConfiguration()
        {
            ToTable("Bültenler");
            Property(x => x.Name).HasColumnName("BültenAdı").IsRequired();
            Property(x=>x.Place).HasColumnName("Bülten Bölgesi").IsRequired();
        }
    }
}
