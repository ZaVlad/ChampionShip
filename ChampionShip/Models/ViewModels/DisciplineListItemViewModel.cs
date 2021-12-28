using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intefaces.Implementation.Models;

namespace ChampionShip.Models.ViewModels
{
    public class DisciplineListItemViewModel
    {
      public int Code { get; set; }
        public string AgeName { get; set; }
        public int AgeId { get; set; }
        public string WeightName { get; set; }
        public int WeightId { get; set; }
        public int Standart { get; set; }
    }
    public static partial class ViewModelMapperExtensions
    {
        public static DisciplineListItemViewModel AsListItemViewModel(this DisciplineListItemDto discipline)
        {
            return new DisciplineListItemViewModel()
            {
                Code = discipline.Code,
                AgeId = discipline.AgeId,
                AgeName = discipline.AgeName,
                Standart = discipline.Standart,
                WeightId = discipline.WeightId,
                WeightName = discipline.WeightName
            };
        }
    }
}
