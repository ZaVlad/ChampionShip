using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;
using Intefaces.Implementation.Models;

namespace Intefaces.Implementation.Interfaces
{
    public interface IWeightRepository:IBaseRepository
    {
        Task<ICollection<WeightDto>> GetList();
        Task<WeightDto> GetDetail(int id);
        Task Create(Weight entity);
        Task Delete(int entityId);
    }
}
