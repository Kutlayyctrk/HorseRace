using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.ResponseModels
{
    public class RaceCardResponseModel
    {
        public string Name { get; set; }

        public string PlaceName { get; set; }

        public string RaceDayName { get; set; }
        public override string ToString()
        {
            return "Name";

        }
    }
}
