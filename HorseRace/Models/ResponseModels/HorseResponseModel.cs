using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.ResponseModels
{
    public class HorseResponseModel
    {
        public string  Name  { get; set; }
        public int Age { get; set; }
        public string  JockeyName { get; set; }
        public string  RaceName { get; set; }
        public override string ToString()
        {
            return "Name";

        }
    }
}
