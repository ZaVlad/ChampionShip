using System;

namespace Intefaces.Implementation.Models
{
    public class RatingCreateDto
    {
        public int Net { get; set; }
        public int PersonId { get; set; }
        public int I { get; set; }
        public int W { get; set; }
        public int Y { get; set; }
        public decimal K { get; set; }
        public DateTime Updated { get; set; }
    }
}
