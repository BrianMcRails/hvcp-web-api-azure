using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hvcp_web_api.Models
{
    public class DicomseriesDto
    {
		public int SsdicomseriesId { get; set; }
		public string SeriesUid { get; set; }
		public int SsdicomstudyId { get; set; }
		public int? SeriesNumber { get; set; }
		public DateTime? SeriesDate { get; set; }
		public DateTime? SeriesTime { get; set; }
		public string OperatorName { get; set; }
		public string ProtocolName { get; set; }
		public string Description { get; set; }
		public int? SeriesStatus { get; set; }
		public int? ImageCount { get; set; }
		public string Modality { get; set; }
		public int? NumberofStages { get; set; }
		public int? NumberofViewsinStage { get; set; }
		public string RequestedProcedureId { get; set; }
		public string ScheduledProcedureStepId { get; set; }
		public DateTime? ScheduledProcedureStartDate { get; set; }
		public DateTime? ScheduledProcedureStartTime { get; set; }
		public DateTime? PerformedProcedureStepStartDate { get; set; }
		public DateTime? PerformedProcedureStepStartTime { get; set; }

	    public int NumberOfImages
	    {
			get
			{
				return this.Dicomimages.Count;
			}
		}

		public ICollection<DicomimageDto> Dicomimages { get; set; }
			= new List<DicomimageDto>();
	}
}
