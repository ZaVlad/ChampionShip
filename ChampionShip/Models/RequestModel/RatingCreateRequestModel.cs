using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intefaces.Implementation.Models;

namespace ChampionShip.Models.RequestModel
{
    public class RatingCreateRequestModel
    {
        public int Net { get; set; }
        public int PersonId { get; set; }
        public int I { get; set; }
        public int W { get; set; }
        public int Y { get; set; }
        public decimal K { get; set; }
        public DateTime Updated { get; set; }
    }

    public static partial class ViewModelMapperExtensions 
    {
        public static RatingCreateDto AsDto(this RatingCreateRequestModel requestModel)
        {
            return new RatingCreateDto()
            {
                I = requestModel.I,
                K = requestModel.K,
                Net = requestModel.Net,
                PersonId = requestModel.PersonId,
                Updated = requestModel.Updated,
                W = requestModel.W,
                Y = requestModel.Y
            };
        }
    }
}
