using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;
using Intefaces.Implementation.Models;

namespace Intefaces.Implementation.Interfaces
{
    public interface ITourRepository:IBaseRepository
    {
        Task<ICollection<TourListItemDto>> GetList();
        Task<TourDetailDto> GetDetail(int id);
        Task Create(Tour entity);
        Task Delete(int entityId);
    }
}
