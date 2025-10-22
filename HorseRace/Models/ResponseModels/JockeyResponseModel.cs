using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Models.ResponseModels
{
    public class JockeyResponseModel
    {
        public string JockeyName { get; set; }
        public int JockeyAge { get; set; }


        public override string ToString()
        {
            return "Name";

        }
    }
}
