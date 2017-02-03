using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace hvcp_web_api.Controllers
{
	using AutoMapper;

	using hvcp_web_api.Entities;
	using hvcp_web_api.Interfaces;
	using hvcp_web_api.Models;
	using hvcp_web_api.Repositories;

	[Route("api/[controller]")]
    public class DemographicsController : Controller
	{
		private IDemographicsRepository repository;

	    public DemographicsController(StudyInfoContext ctx, IDemographicsRepository repository)
	    {
		    this.repository = repository;
	    }

        // GET: api/values
        [HttpGet]
        public IActionResult GetDemographics()
        {
	        var demographicsEntities = this.repository.GetDemographics();
	        var results = Mapper.Map<IEnumerable<DemographicDto>>(demographicsEntities);
			
			return Ok(results);

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetDemographic(int id, bool includeDicomtudies = true)
        {
	        var demographic = this.repository.GetDemographic(id, includeDicomtudies);
	        var result = Mapper.Map<DemographicDto>(demographic);
            return Ok(result);
        }
    }
}
