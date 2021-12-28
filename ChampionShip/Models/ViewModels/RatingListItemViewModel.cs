using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intefaces.Implementation.Models;

namespace ChampionShip.Models.ViewModels
{
    public class RatingListItemViewModel
    {
        public int Code { get; set; }
        public int Net { get; set; }
        public int Member { get; set; }
        public int I { get; set; }
        public int W { get; set; }
        public int Y { get; set; }
        public decimal K { get; set; }

    }
    public static partial class ViewModelMapperExtensions
    {
        public static RatingListItemViewModel AsListItemViewModel(this RatingListItemDto rating)
        {
            return new RatingListItemViewModel()
            {
                Code = rating.Code,
                I = rating.I,
                K = rating.K,
                Member = rating.Member,
                Net = rating.Net,
                W = rating.W,
                Y = rating.Y
            };
        }
    }
}
