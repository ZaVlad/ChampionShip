using Entities.Models;

namespace Intefaces.Implementation.Models
{
    public class AgeDto
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public byte Sex { get; set; }
        public int C { get; set; }
        public int PO { get; set; }
        public int Team { get; set; }
    }
    public static partial class DtoMapperExtension
    {
        public static AgeDto AsDto( this Age age)
        {
            return new AgeDto()
            {
                Code = age.Code,
                C = age.C,
                Name = age.Name,
                PO = age.PO,
                Sex = age.Sex,
                Team = age.Team
            };
        }
    }
}
