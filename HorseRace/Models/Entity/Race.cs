using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.Entity
{
    public class Race : BaseEntity
    {
        public Race()
        {
            Horses = new List<Horse>();
        }
        public string Name { get; set; }
        public int? RaceCardId { get; set; }

        //Relational Properties

        public virtual RaceCard RaceCard { get; set; }
        public virtual List<Horse> Horses { get; set; }
    }
}
