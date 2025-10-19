using HorseRace.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.Configurations
{
    public class RaceDayConfiguration : BaseConfiguration<RaceDay>
    {
        public RaceDayConfiguration()
        {
            ToTable("YarışGünleri");
            Property(x => x.Name).HasColumnName("Yarış Günü Adı").IsRequired();
            Property(x=>x.Date).HasColumnName("Yarış Günü Tarihi").IsRequired();

        }
    }
}
