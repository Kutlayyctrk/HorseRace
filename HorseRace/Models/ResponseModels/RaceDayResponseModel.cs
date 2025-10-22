using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.ResponseModels
{
    public class RaceDayResponseModel
    {
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public override string ToString()
        {
            return "Name";

        }
    }
}
