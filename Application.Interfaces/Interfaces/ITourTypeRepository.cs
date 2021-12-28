using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;
using Intefaces.Implementation.Models;

namespace Intefaces.Implementation.Interfaces
{
    public interface ITourTypeRepository : IBaseRepository
    {
        Task<ICollection<TourTypeDto>> GetList();
        Task<TourTypeDto> GetDetail(int id);
        Task Create(TourType entity);
        Task Delete(int entityId);
    }
}
