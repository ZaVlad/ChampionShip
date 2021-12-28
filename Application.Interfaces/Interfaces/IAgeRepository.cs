using System.Collections.Generic;
using System.Threading.Tasks;
using Intefaces.Implementation.Models;

namespace Intefaces.Implementation.Interfaces
{
    public interface IAgeRepository : IBaseRepository
    {
        Task<ICollection<AgeDto>> GetList();
        Task<AgeDto> GetDetail(int id);
        Task Create(AgeDto entity);
        Task Delete(int entityId);
    }
}
