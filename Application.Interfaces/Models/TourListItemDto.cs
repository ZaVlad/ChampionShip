using System;

namespace Intefaces.Implementation.Models
{
    public class TourListItemDto
    {
        public int Code { get; set; }
        public int DisciplineId { get; set; }
        public int Number { get; set; }
        public string GroupName { get; set; }
        public int OrderNumber { get; set; }
        public int Status { get; set; }
        public int WeightId { get; set; }
        public int AgeId { get; set; }
        public string AgeName { get; set; }
        public string WeightName { get; set; }
        public int Order { get; set; }
        public string TourTypeName { get; set; }
        public string Short { get; set; }
        public DateTime Updated { get; set; }
    }
   
}
