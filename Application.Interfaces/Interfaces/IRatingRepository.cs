using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;
using Intefaces.Implementation.Models;

namespace Intefaces.Implementation.Interfaces
{
    public interface IRatingRepository : IBaseRepository
    {
        Task<ICollection<RatingListItemDto>> GetList();
        Task<RatingListItemDto> GetDetail(int id);
        Task<Rating> Get(int id);
        Task Create(RatingCreateDto entity);
        Task Delete(int entityId);
    }
}
