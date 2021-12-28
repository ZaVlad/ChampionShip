using System;

namespace Entities.Models
{
    public class Tour
    {
        public int Code { get; set; }
        public Discipline Discipline { get; set; }
        public int DisciplineId { get; set; }
        public TourType TourType { get; set; }
        public int Number { get; set; }
        public string GroupName { get; set; }
        public int OrderNumber { get; set; }
        public int Status { get; set; }
        public int GroupA { get; set; }
        public int GroupB { get; set; }
        public int GroupC { get; set; }
        public int CountLimit { get; set; }
        public DateTime Updated { get; set; }
    }
}
