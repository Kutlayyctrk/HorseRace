using HorseRace.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.Entity
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            InstertedDate = DateTime.Now;
            DataStatus = DataStatus.Inserted;
        }

        public int Id { get; set; }
        public DateTime InstertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public DataStatus DataStatus { get; set; }
    }
}
