using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChampionShip.Models.RequestModel
{
    public class RatingUpdateRequestModel
    {
        public int Net { get; set; }
        public int PersonId { get; set; }
        public int I { get; set; }
        public int W { get; set; }
        public int Y { get; set; }
        public decimal K { get; set; }
    }
}
