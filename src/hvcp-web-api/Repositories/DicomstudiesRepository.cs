using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hvcp_web_api.Repositories
{
	using hvcp_web_api.Entities;
	using hvcp_web_api.Interfaces;
    public class DicomstudiesRepository : IDicomstudiesRepository
    {
	    private StudyInfoContext ctx;

	    public DicomstudiesRepository(StudyInfoContext ctx)
	    {
		    this.ctx = ctx;
	    }
	    public Dicomstudies GetDicomstudy(int SS_Patient_ID, int SSDICOMStudyID)
	    {
		    return this.ctx.Dicomstudies.Where(ds => ds.Ss_Patient_Id == SS_Patient_ID && ds.SsdicomstudyId == SSDICOMStudyID)
				    .FirstOrDefault();

	    }
    }
}
