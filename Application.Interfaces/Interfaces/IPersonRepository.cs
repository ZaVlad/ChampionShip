using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;
using Intefaces.Implementation.Models;

namespace Intefaces.Implementation.Interfaces
{
    public interface IPersonRepository:IBaseRepository
    {
        public Task<ICollection<PersonListItemDto>> GetList();
        public Task<PersonDetailDto> GetDetail(int id);
        public Task<Person> Get(int id);
        public Task<ICollection<PersonListItemDto>> GetListByDiscipline(int desciplineCode);
        public Task Create(PersonCreateDto person);
        public Task Delete(int id);
    }
}
