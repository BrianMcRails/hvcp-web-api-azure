using System;
using System.Collections.Generic;

namespace hvcp_web_api.Entities
{
	using System.ComponentModel.DataAnnotations;

	using Microsoft.EntityFrameworkCore.Metadata.Internal;
	using System.ComponentModel.DataAnnotations.Schema;

	public partial class Dicomstudies
    {
		[Key]
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

		[ForeignKey("Ss_Patient_Id")]
		public Demographics Demographics { get; set; }


	}
}
