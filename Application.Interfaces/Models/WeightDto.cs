using Entities.Models;

namespace Intefaces.Implementation.Models
{
    public class WeightDto
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
    }
    public static partial class DtoMapperExtension
    {
        public static WeightDto AsDto(this Weight weight)
        {
            return new WeightDto()
            {
                Code = weight.Code,
                Name = weight.Name,
                Order = weight.Order
            };
        }
    }
}
