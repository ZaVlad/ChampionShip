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
    public class ToursController : ControllerBase
    {
        private readonly ITourRepository _tourRepository;
        public ToursController(ITourRepository tourRepository)
        {
            _tourRepository = tourRepository;
        }

        [HttpGet("[controller]")]
        public async Task<IActionResult> Get()
        {
            var tours = await _tourRepository.GetList();
            return Ok(tours.Select(s=>s.AsListItemViewModel()));
        }
    }
}
