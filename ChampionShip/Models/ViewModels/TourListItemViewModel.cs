using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intefaces.Implementation.Models;

namespace ChampionShip.Models.ViewModels
{
    public class TourListItemViewModel
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
    public static partial class ViewModelMapperExtensions
    {
        public static TourListItemViewModel AsListItemViewModel(this TourListItemDto tour)
        {
            return new TourListItemViewModel()
            {
                AgeId = tour.AgeId,
                AgeName = tour.AgeName,
                Code = tour.Code,
                DisciplineId = tour.DisciplineId,
                GroupName = tour.GroupName,
                Number = tour.Number,
                Order = tour.Order,
                OrderNumber = tour.OrderNumber,
                Short = tour.Short,
                Status = tour.Status,
                TourTypeName = tour.TourTypeName,
                Updated = tour.Updated,
                WeightId = tour.WeightId,
                WeightName = tour.WeightName
            };
        }
    }
}
