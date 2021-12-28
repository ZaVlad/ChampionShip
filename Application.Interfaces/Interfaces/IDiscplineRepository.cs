using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;
using Intefaces.Implementation.Models;

namespace Intefaces.Implementation.Interfaces
{
    public interface IDiscplineRepository:IBaseRepository
    {
        Task<ICollection<DisciplineListItemDto>> GetList();
        Task<DisciplineDetailDto> GetDetail(int id);
        Task<Discipline> Get(int id);
        Task<Discipline> Get(string name);

        Task Create(DisciplineCreateDto entity);
        Task Delete(int entityId);
    }
}
