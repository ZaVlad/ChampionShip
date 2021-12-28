using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Entities.Models;
using Intefaces.Implementation.Interfaces;
using Intefaces.Implementation.Models;
using Microsoft.EntityFrameworkCore;

namespace Intefaces.Application.Repositories
{
    public class DisciplineRepository : IDiscplineRepository
    {
        private ChampionshipDbContext _dbContext;
        public DisciplineRepository(ChampionshipDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<DisciplineDetailDto> GetDetail(int id)
        {
            var discipline = await _dbContext.Set<Discipline>().FindAsync(id);
            return ConvertToDetailDto(discipline);
        }
        public async Task<ICollection<DisciplineListItemDto>> GetList()
        {
            var disciplines =  
                await _dbContext.Set<Discipline>()
                 .Include(s => s.Weight)
                .Include(s => s.Age)
                .ToListAsync();

            return disciplines.Select(s => ConvertToListItemDto(s)).ToArray();
        }

        public async Task<Discipline> Get(string name)
        {
            return await _dbContext.Set<Discipline>()
                .Include(s => s.Weight)
                .FirstOrDefaultAsync(s => s.Weight.Name == name);
        }

        public async Task Create(DisciplineCreateDto entity)
        {
            await _dbContext.Set<Discipline>().AddAsync(ConvertToDomainFromDto(entity));
        }

        public async Task Delete(int entityId)
        {
            var entity = await _dbContext.Set<Discipline>().FindAsync(entityId);
            _dbContext.Set<Discipline>().Remove(entity);
        }

        public async Task<Discipline> Get(int id)
        {
            return await _dbContext.Set<Discipline>().FindAsync(id);
        }

        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }


        private Discipline ConvertToDomainFromDto(DisciplineCreateDto dto)
        {
            return new Discipline()
            {
                AgeId = dto.AgeId,
                Code = dto.Code,
                Standart = dto.Standart,
                WeightId = dto.WeightId
            };
        }
        private DisciplineListItemDto ConvertToListItemDto(Discipline discipline)
        {
            return new DisciplineListItemDto()
            {
                Code = discipline.Code,
                AgeName = discipline.Age.Name,
                AgeId = discipline.AgeId,
                Standart = discipline.Standart,
                WeightName = discipline.Weight.Name,
                WeightId = discipline.WeightId
            };
        }

        private DisciplineDetailDto ConvertToDetailDto(Discipline discipline)
        {
            return new DisciplineDetailDto()
            {
                Code = discipline.Code,
                AgeName = discipline.Age.Name,
                C = discipline.Age.C,
                Order = discipline.Weight.Order,
                PO = discipline.Age.PO,
                Sex = discipline.Age.Sex,
                Team = discipline.Age.Team,
                AgeId = discipline.AgeId,
                Standart = discipline.Standart,
                WeightName = discipline.Weight.Name,
                WeightId = discipline.WeightId
            };
        }

        
    }
}
