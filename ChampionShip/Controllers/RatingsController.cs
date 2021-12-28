using ChampionShip.Models.RequestModel;
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
    public class RatingsController: ControllerBase
    {
        private readonly IRatingRepository _ratingRepo;
        private readonly IPersonRepository _personRepo;
        public RatingsController(IRatingRepository ratingRepository, IPersonRepository personRepository)
        {
            _ratingRepo = ratingRepository;
            _personRepo = personRepository;
        }

        [HttpGet("[controller]")]
        public async Task<IActionResult> Get()
        {
            var ratings = await _ratingRepo.GetList();
            return Ok(ratings.Select(s=>s.AsListItemViewModel()));
        }
        [HttpPost("[controller]")]
        public async Task<IActionResult> Create(RatingCreateRequestModel ratingCreateRequest)
        {
            if(await _personRepo.Get(ratingCreateRequest.PersonId) is null)
            {
                return NotFound("Person with this code doesn't exists");
            }
            await _ratingRepo.Create(ratingCreateRequest.AsDto());
            return NoContent();
        }
        [HttpPut("[controller]/{id:int}")]
        public async Task<IActionResult> Update(RatingUpdateRequestModel ratingUpdateModel, int id)
        {
            var rating = await _ratingRepo.Get(id);

            if(rating is null)
            {
                return NotFound("Rating with this id doesn't exists");
            }
            if(await _personRepo.Get(ratingUpdateModel.PersonId) is null)
            {
                return NotFound("Person with this id doesn't exists");
            }

            rating.I = ratingUpdateModel.I;
            rating.K = ratingUpdateModel.K;
            rating.Net = ratingUpdateModel.Net;
            rating.PersonId = ratingUpdateModel.PersonId;
            rating.W = ratingUpdateModel.W;
            rating.Y = ratingUpdateModel.Y;
            await _ratingRepo.SaveChanges();

            return NoContent();
        }
    }
}
