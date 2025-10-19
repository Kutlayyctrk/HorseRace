using HorseRace.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.Configurations
{
    public class HorseConfiguration : BaseConfiguration<Horse>
    {

        public HorseConfiguration()
        {
            ToTable("Atlar");
            Property(x => x.Name).HasColumnName("At Adı").IsRequired();
            Property(x => x.Age).HasColumnName("Yaş").IsRequired();
            Property(x => x.Region).HasColumnName("Irk").IsRequired();

        }
    }
}
