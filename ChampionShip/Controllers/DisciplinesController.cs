using ChampionShip.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Entities.Models;
using Intefaces.Implementation.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChampionShip.Controllers
{
    [ApiController]
    public class DisciplinesController :ControllerBase
    {
        private readonly IDiscplineRepository _repository;
        public DisciplinesController( IDiscplineRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        [HttpGet("[controller]")]
        public async Task<IActionResult> Get()
        {
            var disciplinesDto = await _repository.GetList();
            var disciplineViewModel = disciplinesDto.Select(s => s.AsListItemViewModel());
            return Ok(disciplineViewModel);
        }

        
    }
}
