using System.Threading.Tasks;

namespace Intefaces.Implementation.Interfaces
{
    public interface IBaseRepository
    {
        public Task SaveChanges();
    }
}
