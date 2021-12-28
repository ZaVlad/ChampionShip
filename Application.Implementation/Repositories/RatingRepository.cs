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
    public class RatingRepository : IRatingRepository
    {
        private ChampionshipDbContext _dbContext;
        public RatingRepository(ChampionshipDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(RatingCreateDto entity)
        {
            await _dbContext.Set<Rating>().AddAsync(ConvertToDomainFromDto(entity));
             await SaveChanges();
        }

        public Task Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<RatingListItemDto> GetDetail(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<RatingListItemDto>> GetList()
        {
            var ratings = await _dbContext.Set<Rating>()
                .Select(s=> ConvertToListItemDto(s))
                .ToListAsync();

            return ratings;
        }

        public async Task SaveChanges()
        {
             await _dbContext.SaveChangesAsync();
        }
        private static RatingListItemDto ConvertToListItemDto(Rating rating)
        {
            return new RatingListItemDto()
            {
                Code = rating.Code,
                I = rating.I,
                K = rating.K,
                Member = rating.PersonId,
                Net = rating.Net,
                W = rating.W,
                Y = rating.Y
            };
        }
        private Rating ConvertToDomainFromDto(RatingCreateDto dto)
        {
            return new Rating()
            {
                I = dto.I,
                K = dto.K,
                Net = dto.Net,
                PersonId = dto.PersonId,
                Updated = dto.Updated,
                W = dto.W,
                Y = dto.Y
            };
        }

        public async Task<Rating> Get(int id)
        {
            return await _dbContext.Set<Rating>().FindAsync(id);
        }
    }
}
