using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Entities.Models;
using Intefaces.Implementation.Interfaces;
using Intefaces.Implementation.Models;
using Microsoft.EntityFrameworkCore;

namespace Aplication.Repositories
{
    public class WeightRepository : IWeightRepository
    {
        private ChampionshipDbContext _dbContext;
        public WeightRepository(ChampionshipDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task Create(Weight entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<WeightDto> GetDetail(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<WeightDto>> GetList()
        {
            return await _dbContext.Set<Weight>().Select(s => s.AsDto()).ToListAsync();
        }

        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
