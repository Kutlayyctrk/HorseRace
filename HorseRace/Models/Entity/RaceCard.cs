using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.Entity
{
    public class RaceCard : BaseEntity
    {
        public RaceCard()
        {
            Races = new List<Race>();
        }
        public string Name { get; set; }

        public string Place { get; set; }

        public int? RaceDayId { get; set; }

        //Relational Properties

        public virtual RaceDay RaceDay { get; set; }

        public virtual List<Race> Races { get; set; }
    }
}
