using HorseRace.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.Configurations
{
    public class JockeyConfiguration : BaseConfiguration<Jockey>
    {

        public JockeyConfiguration()
        {
            ToTable("Jokeyler");
            Property(x => x.Name).HasColumnName("Jokey Adı").IsRequired();
            Property(x => x.Age).HasColumnName("Yaş").IsRequired();
            

        }
    }
}
