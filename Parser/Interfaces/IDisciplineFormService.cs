using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Entities.Models;

namespace Parser.Interfaces
{
    public interface IDisciplineFormService
    {
        public List<Discipline> GetList();
        public Discipline Get(int id);
        public Discipline Get(string name);


    }
}