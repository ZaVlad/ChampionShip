using System.Collections.Generic;

namespace Entities.Models
{
    public class Discipline
    {
        public int Code { get; set; }
        public Age Age { get; set; }
        public int AgeId { get; set; }
        public Weight Weight { get; set; }
        public int WeightId { get; set; }
        public int Standart { get; set; }
        public ICollection<Tour> Tours { get; set; }

    }
}
