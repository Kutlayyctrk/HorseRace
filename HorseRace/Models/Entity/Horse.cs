using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.Entity
{
    public class Horse: BaseEntity
    {
        public string  Name { get; set; }
        public int Age { get; set; }
        public string Region { get; set; }
        public int? RaceId { get; set; }
        public int? JokeyId { get; set; }

        //Relational Properties

        public virtual Jockey Jockey { get; set; }
        public virtual Race Race { get; set; }

    }
}
