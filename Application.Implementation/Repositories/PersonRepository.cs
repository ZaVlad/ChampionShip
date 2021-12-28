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
    public class PersonRepository : IPersonRepository
    {
        private ChampionshipDbContext _dbContext;
        public PersonRepository(ChampionshipDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async  Task<ICollection<PersonListItemDto>> GetList()
        {
            var persons = await _dbContext.Set<Person>().ToListAsync();
            var personsListItemDto = persons.Select(s => ConvertToListItemDto(s)).ToArray();

            return personsListItemDto;
        }

        public async Task<ICollection<PersonListItemDto>> GetListByDiscipline(int disciplineCode)
        {
            var discipline = await _dbContext.Set<Discipline>().Include(s => s.Age).FirstOrDefaultAsync(s => s.Code == disciplineCode);
            var personsListItems = await _dbContext.Set<Person>().Where(s => s.Team == discipline.Age.Team).Select(s=>ConvertToListItemDto(s)).ToListAsync();
            return personsListItems;

        }
        public async Task<PersonDetailDto> GetDetail(int id)
        {
            var person = await _dbContext.Set<Person>().FindAsync(id);
            return ConvertToDetailDto(person);
        }

        public async Task<Person> Get(int id)
        {
            return await _dbContext.Set<Person>().FindAsync(id);
        }

        public async Task Create(PersonCreateDto person)
        {
            await _dbContext.Set<Person>().AddAsync(ConvertFromDtoToDomain(person));
            await SaveChanges();
        }

        public async Task Delete(int id)
        {
            var person = await _dbContext.Set<Person>().FindAsync(id);
            _dbContext.Set<Person>().Remove(person);
            await SaveChanges();
        }

        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }

        private static Person ConvertFromDtoToDomain(PersonCreateDto person)
        {
            return new Person()
            {
                BirthDate = person.BirthDate,
                CardNumber = person.CardNumber,
                CardType = person.CardType,
                CBDCode = person.CBDCode,
                Code = person.Code,
                CodeEPC = person.CodeEPC,
                Country = person.Country,
                Department = person.Department,
                IsCommand = person.IsCommand,
                LastName = person.LastName,
                MiddleName = person.MiddleName,
                Name = person.Name,
                Parent = person.Parent,
                IssuedBy = person.PassportIssuedBy,
                PassportIssuedDate = person.PassportIssuedDate,
                IssuedPlace = person.PassportIssuedPlace,
                PassportNumber = person.PassportNumber,
                Payment = person.Payment,
                Sex = person.Sex,
                Team = person.Team,
                Trainer = person.Trainer,
                Updated = person.Updated,
                _judge = person._judge,
                _org = person._org,
                _sport = person._sport,
                _tex = person._tex,
                _texpr = person._texpr,
                _train = person._train,
                _zvan = person._zvan
            };
        }
        private static PersonListItemDto ConvertToListItemDto(Person person)
        {
            return new PersonListItemDto()
            {
                BirthDate = person.BirthDate,
                Code = person.Code,
                Country = person.Country,
                IsCommand = person.IsCommand,
                LastName = person.LastName,
                MiddleName = person.MiddleName,
                Name = person.Name,
                Parent = person.Parent,
                Sex = person.Sex,
                Team = person.Team,
            };
        }
        private static PersonDetailDto ConvertToDetailDto(Person person)
        {
            return new PersonDetailDto()
            {
                BirthDate = person.BirthDate,
                CardNumber = person.CardNumber,
                CardType = person.CardType,
                CBDCode = person.CBDCode,
                Code = person.Code,
                CodeEPC = person.CodeEPC,
                Country = person.Country,
                Department = person.Department,
                IsCommand = person.IsCommand,
                LastName = person.LastName,
                MiddleName = person.MiddleName,
                Name = person.Name,
                Parent = person.Parent,
                PassportIssuedBy = person.IssuedBy,
                PassportIssuedDate = person.PassportIssuedDate,
                PassportIssuedPlace = person.IssuedPlace,
                PassportNumber = person.PassportNumber,
                Payment = person.Payment,
                Sex = person.Sex,
                Team = person.Team,
                Trainer = person.Trainer,
                Updated = person.Updated,
                _judge = person._judge,
                _org = person._org,
                _sport = person._sport,
                _tex = person._tex,
                _texpr = person._texpr,
                _train = person._train,
                _zvan = person._zvan
            };
        }

       
    }
      
    
}
