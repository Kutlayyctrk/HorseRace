using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.Entity
{
    public class AllData
    {

        public DateTime Tarih { get; set; }
        public string RaceCardName { get; set; }
        public string RaceCardPlace { get; set; }
        public string RaceName { get; set; }
        public string HorseName { get; set; }
        public int HorseAge { get; set; }
        public string HorseRegion { get; set; }
        public string JockeyName { get; set; }
        public int JockeyAge { get; set; }
    }
}
