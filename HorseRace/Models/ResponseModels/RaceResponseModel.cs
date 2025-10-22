using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.ResponseModels
{
    public class RaceResponseModel
    {
        public string RaceName { get; set; }

        public string BulletinName { get; set; }
        public override string ToString()
        {
            return "Name";

        }
    }
}
