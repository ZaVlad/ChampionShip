using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intefaces.Implementation.Interfaces;

namespace ChampionShip.Controllers
{
    [ApiController]
    public class WeightsController : ControllerBase
    {
        private readonly IWeightRepository _repository;
        public WeightsController(IWeightRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("[controller]")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.GetList());
        }
    }
}
