using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hvcp_web_api.Interfaces
{
	using hvcp_web_api.Entities;


	public interface IDemographicsRepository
	{

		IEnumerable<Demographics> GetDemographics();

		Demographics GetDemographic(int SS_Patient_ID, bool includeDicomstudies);

		IEnumerable<Dicomstudies> GetDicomstudiesForDemographic(int SS_Patient_ID);

		Dicomstudies GetDicomstudyForDemographic(int SS_Patient_ID, int SSDICOMStudyID);
	}
}
