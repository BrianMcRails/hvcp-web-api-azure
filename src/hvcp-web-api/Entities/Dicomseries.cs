using System;
using System.Collections.Generic;

namespace hvcp_web_api.Entities
{
	using System.ComponentModel.DataAnnotations;

	using Microsoft.EntityFrameworkCore.Metadata.Internal;
	using System.ComponentModel.DataAnnotations.Schema;

	public partial class Dicomseries
    {
		[Key]
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
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedCount { get; set; }
        public string OperatorFirstName { get; set; }
        public string OperatorLastName { get; set; }
        public string OperatorMiddleName { get; set; }
        public string OperatorPrefix { get; set; }
        public string OperatorSuffix { get; set; }
        public int? NumberofStages { get; set; }
        public int? NumberofViewsinStage { get; set; }
        public string PerfPhysicianName { get; set; }
        public string PerfPhyLastName { get; set; }
        public string PerfPhyFirstName { get; set; }
        public string PerfPhyMiddleName { get; set; }
        public string PerfPhyPrefix { get; set; }
        public string PerfPhySuffix { get; set; }
        public string RequestedProcedureId { get; set; }
        public string ScheduledProcedureStepId { get; set; }
        public DateTime? ScheduledProcedureStartDate { get; set; }
        public DateTime? ScheduledProcedureStartTime { get; set; }
        public DateTime? PerformedProcedureStepStartDate { get; set; }
        public DateTime? PerformedProcedureStepStartTime { get; set; }

		[ForeignKey("SsdicomstudyId")]
		public Dicomstudies Dicomstudies { get; set; }

		public ICollection<Dicomimages> Dicomimages { get; set; }
			= new List<Dicomimages>();
    }
}
