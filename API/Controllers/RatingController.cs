using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        
        private IRatingRepository ratingRepository;
        private IMapper mapper;

        public RatingController(IRatingRepository ratingRepository,
            IMapper mapper)
        {
            this.ratingRepository = ratingRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> CreateRating([FromBody] AddRatingDto addRatingDto)
        {
            //map dto to domain model
            var ratingDomainModel = mapper.Map<Rating>(addRatingDto);

            ratingDomainModel = await ratingRepository.CreateRatingAsync(ratingDomainModel);

            //map domain model to dto
            var ratingDto = mapper.Map<RatingDto>(ratingDomainModel);

            return Ok(ratingDto);

        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            //pass query parameters to the repository
            var ratingDomain = await ratingRepository.GetRatingAsync();

            //map domain model to dto
            var ratingDto = mapper.Map<List<RatingDto>>(ratingDomain);

            return Ok(ratingDto);
        }
    }
}
