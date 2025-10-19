using HorseRace.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.Configurations
{
    public class RaceConfiguration : BaseConfiguration<Race>
    {
        public RaceConfiguration()
        {
            ToTable("Yarışlar");
            Property(x => x.Name).HasColumnName("Yarış Adı").IsRequired();
        }
    }
}
