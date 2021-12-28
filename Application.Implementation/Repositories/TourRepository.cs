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
    public class TourRepository : ITourRepository
    {
        private readonly ChampionshipDbContext _dbContext;
        public TourRepository(ChampionshipDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ICollection<TourListItemDto>> GetList()
        {
            var tours = await _dbContext.Set<Tour>()
                .Include(s => s.Discipline).ThenInclude(s => s.Age)
                .Include(s => s.Discipline).ThenInclude(s => s.Weight)
                .Include(s=>s.TourType)
                .Select(s => ConvertToListItemDto(s))
                .ToListAsync();
                
            return tours;
        }
        public Task Create(Tour entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<TourDetailDto> GetDetail(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }

        private static TourListItemDto ConvertToListItemDto(Tour tour)
        {
            return new TourListItemDto()
            {
                AgeId = tour.Discipline.Age.Code,
                AgeName = tour.Discipline.Age.Name,
                Code = tour.Code,
                DisciplineId = tour.DisciplineId,
                GroupName = tour.GroupName,
                Number = tour.Number,
                Order = tour.Discipline.Weight.Order,
                OrderNumber = tour.OrderNumber,
                Short = tour.TourType.Short,
                Status = tour.Status,
                TourTypeName = tour.TourType.Name,
                Updated = tour.Updated,
                WeightId = tour.Discipline.WeightId,
                WeightName = tour.Discipline.Weight.Name
            };
        }
    }
}
