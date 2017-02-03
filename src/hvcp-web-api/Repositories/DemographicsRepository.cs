using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hvcp_web_api.Repositories
{
	using hvcp_web_api.Entities;
	using hvcp_web_api.Interfaces;
	using hvcp_web_api.Models;
	using Microsoft.EntityFrameworkCore;

	public class DemographicsRepository : IDemographicsRepository
	{
		private StudyInfoContext ctx;

		public DemographicsRepository(StudyInfoContext ctx)
		{
			this.ctx = ctx;
		}

		public IEnumerable<Demographics> GetDemographics()
		{
			return this.ctx.Demographics.Include(d => d.Dicomstudies).OrderBy(d => d.Last_Name).Where(d => d.Dicomstudies.Count > 0).ToList();
		}

	    public Demographics GetDemographic(int SsPatientId, bool includeDicomstudies)
	    {
		    if (includeDicomstudies)
		    {
			    return
				    this.ctx.Demographics.Include(d => d.Dicomstudies)
						.Where(d => d.Ss_Patient_Id == SsPatientId).FirstOrDefault();
		    }
		    return this.ctx.Demographics.Where(d => d.Ss_Patient_Id == SsPatientId).FirstOrDefault();
	    }

	    public Dicomstudies GetDicomstudyForDemographic(int SS_Patient_ID, int SsdicomstudyId)
	    {
			return this.ctx.Dicomstudies
				.Where(d => d.Ss_Patient_Id == SS_Patient_ID && d.SsdicomstudyId == SsdicomstudyId).FirstOrDefault();
		}

	    public IEnumerable<Dicomstudies> GetDicomstudiesForDemographic(int SS_Patient_ID)
	    {
			return this.ctx.Dicomstudies
						  .Where(d => d.Ss_Patient_Id == SS_Patient_ID).ToList();
		}
    }
}
