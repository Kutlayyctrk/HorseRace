using HorseRace.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.Configurations
{
    public abstract class BaseConfiguration<T>: EntityTypeConfiguration<T> where T : BaseEntity
    {

        protected BaseConfiguration()
        {
            Property(x => x.InstertedDate).HasColumnName("Yaratılma Tarihi");
            Property(x => x.UpdatedDate).HasColumnName("Güncelleme Tarihi");
            Property(x => x.DeletedDate).HasColumnName("Silme Tarihi");
            Property(x => x.DataStatus).HasColumnName("Veri Durumu");
        }
    }
}
