using ChampionShip.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intefaces.Implementation.Interfaces;

namespace ChampionShip.Controllers
{
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepository _personRepo;
        private readonly IDiscplineRepository _disciplineRepo; 
        public PersonsController(IPersonRepository repository,IDiscplineRepository discplineRepository)
        {
            _personRepo= repository;
            _disciplineRepo = discplineRepository;
        }
        [HttpGet("[controller]")]
        public async Task<IActionResult> Get()
        {
            var persons = await _personRepo.GetList();
            var personListItems = persons.Select(s => s.AsViewModel()); 

            return Ok(personListItems);
        }
        [HttpGet("[controller]/{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            if(await _personRepo.Get(id) is null)
            {
                return NotFound("Person with this code doesn't exists");
            }

            var person = await _personRepo.GetDetail(id);
            return Ok(person.AsViewModel());
        }
        [HttpGet("[controller]/discipline/{id:int}")]
        public async Task<IActionResult> GetByDiscipline(int id)
        {
            if(await _disciplineRepo.Get(id) is null)
            {
                return NotFound("Discipline with this code doesn't exists");
            }
            var persons = await _personRepo.GetListByDiscipline(id);
            var personListItems = persons.Select(s => s.AsViewModel());

            return Ok(personListItems);
        }
    }
}
