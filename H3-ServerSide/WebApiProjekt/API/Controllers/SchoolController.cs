using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using API.Extensions;
using Mapster;
using ClassLibary.Interfaces;
using ClassLibary.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private IRepositoryWrapper _repositoryWrapper;

        public SchoolController(IRepositoryWrapper repositoryWrapper)
        {
            this._repositoryWrapper = repositoryWrapper;
        }

        // GET: CityController
        [HttpGet]
        public async Task<IActionResult> GetSchool(bool includeRelations = true)
        {

            if (false == includeRelations)
            {
                _repositoryWrapper.SchoolRepositoryWrapper.DisableLazyLoading();
            }
            else  // true == includeRelations && true == UseLazyLoading 
            {
                _repositoryWrapper.SchoolRepositoryWrapper.EnableLazyLoading();
            }
            var SchoolList = await _repositoryWrapper.SchoolRepositoryWrapper.FindAll();

            List<SchoolDto> schoolDtos;

            schoolDtos = SchoolList.Adapt<SchoolDto[]>().ToList();

            return Ok(schoolDtos);
        }

        //[HttpGet("{CityId}", Name = "GetCity")]
        //public async Task<IActionResult> GetCity(int CityId,
        //                                         bool includeRelations = true,
        //                                         string UserName = "No Name")
        //{
        //    if (false == includeRelations)
        //    {
        //        _repositoryWrapper.CityRepositoryWrapper.DisableLazyLoading();
        //    }
        //    else
        //    {
        //        _repositoryWrapper.CityRepositoryWrapper.EnableLazyLoading();
        //    }

        //    var City_Object = await _repositoryWrapper.CityRepositoryWrapper.FindOne(CityId);

        //    if (null == City_Object)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        CityDto CityDto_Object = City_Object.Adapt<CityDto>();
        //        return Ok(CityDto_Object);
        //    }
        //}

        //// Metoden herunder er "kun" medtaget for test formål. Den bruges til at vise
        //// hvordan data fra controlleren kan formatteres på forskellig måde.
        //[HttpGet]
        //[Route("[action]")]
        //public async Task<ActionResult> GetCitiesWithCountryID(int CountryID,
        //                                                       bool includeRelations = true,
        //                                                       string UserName = "No Name")
        //{
        //    if (false == includeRelations)
        //    {
        //        _repositoryWrapper.CityRepositoryWrapper.DisableLazyLoading();
        //    }
        //    else
        //    {
        //        _repositoryWrapper.CityRepositoryWrapper.EnableLazyLoading();
        //    }

        //    var CityList = await _repositoryWrapper.CityRepositoryWrapper.GetCitiesWithCountryID(CountryID);

        //    List<CityDto> CityDtos;

        //    CityDtos = CityList.Adapt<CityDto[]>().ToList();

        //    return Ok(CityDtos);
        //}

        //// POST: api/City
        //[HttpPost]
        //public async Task<IActionResult> CreateCity([FromBody] CityForSaveWithCountryDto CityDto_Object,
        //                                            string UserName = "No Name")
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    City City_Object = CityDto_Object.Adapt<City>();
        //    await _repositoryWrapper.CityRepositoryWrapper.Create(City_Object);

        //    return Ok(City_Object.CityId);
        //}

        //// PUT api/<CityController>/5
        //[HttpPut("{CityId}")]
        //public async Task<IActionResult> UpdateCity(int CityId,
        //                                            [FromBody] CityForUpdateDto CityDto_Object,
        //                                            string UserName = "No Name")
        //{
        //    if (CityId != CityDto_Object.CityId)
        //    {
        //        return BadRequest();
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var cityFromRepo = await _repositoryWrapper.CityRepositoryWrapper.FindOne(CityId);

        //    if (null == cityFromRepo)
        //    {
        //        return NotFound();
        //    }

        //    // Dur ikke med en Mapster Adapt i tilfældet med en update !!!
        //    // Derfor har jeg lavet min egen statiske metode CloneData til at kopiere 
        //    // data mellem 2 (generiske) objeter. Denne meode er lavet som en statisk metode i
        //    // en statisk klasse og kan derfor kaldes som en extension metode.
        //    // Metoden kan findes i filen Extensions/MyMapster.cs

        //    //var cityFromRepo1 = CityDto_Object.Adapt<City>();

        //    if (cityFromRepo.CloneData<City>(CityDto_Object))
        //    {
        //        await _repositoryWrapper.CityRepositoryWrapper.Update(cityFromRepo);
        //    }

        //    return NoContent();
        //}

        //// DELETE api/<CityController>/5
        //[HttpDelete("{CityId}")]
        //public async Task<IActionResult> DeleteCity(int CityId,
        //                                            string UserName = "No Name")
        //{
        //    _repositoryWrapper.CityRepositoryWrapper.DisableLazyLoading();

        //    var cityFromRepo = await _repositoryWrapper.CityRepositoryWrapper.FindOne(CityId);

        //    if (null == cityFromRepo)
        //    {
        //        return NotFound();
        //    }

        //    await _repositoryWrapper.CityRepositoryWrapper.Delete(cityFromRepo);

        //    return NoContent();
        //}
    }
}
