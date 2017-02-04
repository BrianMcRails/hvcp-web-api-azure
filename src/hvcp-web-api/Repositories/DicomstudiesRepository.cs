using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hvcp_web_api.Repositories
{
	using System.IO;

	using hvcp_web_api.Entities;
	using hvcp_web_api.Interfaces;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Query.ResultOperators.Internal;

	public class DicomstudiesRepository : IDicomstudiesRepository
    {
	    private StudyInfoContext ctx;

	    public DicomstudiesRepository(StudyInfoContext ctx)
	    {
		    this.ctx = ctx;
	    }
	    public Dicomstudies GetDicomstudy(int SS_Patient_ID, int SSDICOMStudyID)
	    {
		    return this.ctx.Dicomstudies.Include(d => d.Dicomseries).ThenInclude(d => d.Dicomimages).Where(ds => ds.Ss_Patient_Id == SS_Patient_ID && ds.SsdicomstudyId == SSDICOMStudyID)
				    .FirstOrDefault();
	    }

		public Dicomimages GetDicomimage(int SS_Patient_ID, int SSDICOMStudyID, int SSDICOMImageID)
		{
			return this.ctx.Dicomimages.Where(i => i.SsdicomimageId == SSDICOMImageID 
				&& i.Dicomseries.Dicomstudies.SsdicomstudyId == SSDICOMStudyID
				&& i.Dicomseries.Dicomstudies.Ss_Patient_Id == SS_Patient_ID).FirstOrDefault();
		}

		public string GetImagePath(Dicomimages dicomImage)
		{
			var setting =
				this.ctx.Sssettings.Where(s => s.GroupName == $"CardioPACS\\ArchiveServer\\Settings\\Volumes\\{dicomImage.OriginalVolume}" && s.KeyName == "Path")
					.FirstOrDefault();
			var root = setting.KeyValue;
			var result = Path.Combine(root, dicomImage.Dicomseries.Dicomstudies.StudyUid, dicomImage.Dicomseries.SeriesUid, dicomImage.ImageUid);
			return result;
		}
	}
}
