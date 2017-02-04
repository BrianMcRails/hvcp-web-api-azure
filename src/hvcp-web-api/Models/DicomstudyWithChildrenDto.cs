using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hvcp_web_api.Models
{
    public class DicomstudyWithChildrenDto
    {
		public int SsdicomstudyId { get; set; }
		public string StudyUid { get; set; }
		public int? Ss_Patient_Id { get; set; }
		public string AccessionNumber { get; set; }
		public DateTime? StudyDate { get; set; }
		public string Description { get; set; }
		public string Modality { get; set; }
		public int? StudyStatus { get; set; }
		public string SourceAe { get; set; }
		public int? ImageCount { get; set; }
		public long? StudySize { get; set; }
		public string InstitutionName { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public DateTime? StudyTime { get; set; }
		public string StudyId { get; set; }
		public DateTime? CreatedDate { get; set; }
		public int? ModifiedCount { get; set; }
		public string DestinationAe { get; set; }
		public string RetrievalType { get; set; }
		public DateTime? LastAccessedDate { get; set; }
		public string StudyType { get; set; }
		public string Masks { get; set; }
		public int NumberOfSeries
		{
			get
			{
				return this.Dicomseries.Count;
			}
		}

		public ICollection<DicomseriesDto> Dicomseries { get; set; }
			= new List<DicomseriesDto>();
	}
}
