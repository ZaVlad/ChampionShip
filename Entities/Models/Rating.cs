using System;

namespace Entities.Models
{
    public class Rating
    {
        public int Code { get; set; }
        public int Net { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
        public int I { get; set; }
        public int W { get; set; }
        public int Y { get; set; }
        public decimal K { get; set; }
        public DateTime Updated { get; set; }
    }
}
