using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.Entity
{
    public class RaceDay : BaseEntity
    {
        public RaceDay()
        {
            
            RaceCards = new List<RaceCard>();
        }

        public string Name { get; set; }

        public DateTime Date { get; set; }


        //Relational Properties

        public virtual List<RaceCard> RaceCards { get; set; }
    }
}
