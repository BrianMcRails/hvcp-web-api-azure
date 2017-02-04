// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValuesController.cs" company="Lumedx">
//   Lumedx 2017
// </copyright>
// <summary>
//   Defines the ValuesController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace hvcp_web_api.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Runtime.InteropServices.ComTypes;
	using System.Threading.Tasks;

	using AutoMapper;

	using hvcp_web_api.Entities;
	using hvcp_web_api.Interfaces;
	using hvcp_web_api.Models;

	using Microsoft.AspNetCore.Mvc;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Logging;

	[Route("api/demographics")]
    public class DicomstudiesController : Controller
	{
		private ILogger<DicomstudiesController> logger;

		private IDicomstudiesRepository repository;

		public DicomstudiesController(ILogger<DicomstudiesController> logger, IDicomstudiesRepository repository)
		{
			this.logger = logger;
			this.repository = repository;
		}

		[HttpGet("{ss_patient_id}/dicomstudies/{id}", Name = "GetDicomstudy")]
		public IActionResult GetDicomstudy(int ss_patient_id, int id)
		{
			var dicomstudy = this.repository.GetDicomstudy(ss_patient_id, id);
			var result = Mapper.Map<DicomstudyWithChildrenDto>(dicomstudy);
			return this.Ok(result);
		}

		[HttpGet("{ss_patient_id}/dicomstudies/{ssdicomstudyid}/dicomimage/{id}", Name = "GetDicomImage")]
		public IActionResult GetDicomImage(int ss_patient_id, int ssdicomstudyid, int id)
		{
			var dicomimage = this.repository.GetDicomimage(ss_patient_id, ssdicomstudyid, id);
			var result = Mapper.Map<DicomimageDto>(dicomimage);
			// var result = this.repository.GetImagePath(dicomimage);
			
			return this.Ok(result);
		}
	}
}
