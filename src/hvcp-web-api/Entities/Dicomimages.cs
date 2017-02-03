using System;
using System.Collections.Generic;

namespace hvcp_web_api.Entities
{
	using System.ComponentModel.DataAnnotations;

	public partial class Dicomimages
    {
		[Key]
        public int SsdicomimageId { get; set; }
        public string ImageUid { get; set; }
        public int SsdicomseriesId { get; set; }
        public int? ImageNumber { get; set; }
        public int? NumberOfFrames { get; set; }
        public int? Rows { get; set; }
        public int? Columns { get; set; }
        public string StageName { get; set; }
        public string ViewName { get; set; }
        public int? StageNumber { get; set; }
        public DateTime? ImageDate { get; set; }
        public DateTime? ImageTime { get; set; }
        public int? CineRate { get; set; }
        public double? WindowWidth { get; set; }
        public double? WindowLevel { get; set; }
        public int? ImageType { get; set; }
        public double? PixelSpacing { get; set; }
        public double? ImagerPixelSpacing { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ImageSize { get; set; }
        public int? ModifiedCount { get; set; }
        public int? ImageStatus { get; set; }
        public string ImageComments { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ViewNumber { get; set; }
        public string SopclassUid { get; set; }
        public string OriginalTransferSyntax { get; set; }
        public int? BitsAllocated { get; set; }
        public int? VolumeManagementFlag { get; set; }
        public int? InstanceCompressed { get; set; }
        public int? AlternateLoop { get; set; }
        public string OriginalFileName { get; set; }
        public string OriginalVolume { get; set; }
        public string CompressedVolume { get; set; }
        public string SubFolder { get; set; }
        public string Masks { get; set; }
    }
}
