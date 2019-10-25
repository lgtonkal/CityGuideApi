using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CityGuide.Data;
using CityGuide.Dtos;
using CityGuide.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityGuide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
		private IAppRepository _appRepository;
		private IMapper _mapper;

		public CitiesController(IAppRepository appRepository, IMapper mapper)
		{
			_appRepository = appRepository;
			_mapper = mapper;
		}

		public IActionResult GetCities()
		{
			var cities = _appRepository.GetCities();
			var citiesToReturn = _mapper.Map<List<CityForListDto>>(cities);

			return Ok(citiesToReturn);
		}

		[HttpGet("detail")]
		public IActionResult GetCityById(int id)
		{
			var city = _appRepository.GetCityById(id);
			var citiyToReturn = _mapper.Map<CityForDetailDto>(city);

			return Ok(citiyToReturn);
		}

		[HttpGet("photos")]
		public IActionResult GetPhotosByCity(int cityId)
		{
			var photos = _appRepository.GetPhotosByCity(cityId);

			return Ok(photos);
		}

		[HttpPost("add")]
		[Authorize]
		public IActionResult Add([FromBody] City city)
		{
			_appRepository.Add(city);
			_appRepository.SaveAll();

			return Ok(city);
		}
    }
}