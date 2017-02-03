using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hvcp_web_api.Interfaces
{
	using hvcp_web_api.Entities;

	public interface IDicomstudiesRepository
	{
		Dicomstudies GetDicomstudy(int SS_Patient_ID, int SSDICOMStudyID);
	}
}
