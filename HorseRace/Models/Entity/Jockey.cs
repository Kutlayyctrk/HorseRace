using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.Entity
{
    public class Jockey : BaseEntity
    {
        public Jockey()
        {
            Horses=new List<Horse>();
        }
        public string Name { get; set; }
        public int Age { get; set; }

        //Relational Properties

        public virtual List<Horse> Horses { get; set; }
    }
}
