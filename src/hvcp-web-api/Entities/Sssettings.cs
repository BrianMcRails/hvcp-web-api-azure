using System;
using System.Collections.Generic;

namespace hvcp_web_api.Entities
{
	using System.ComponentModel.DataAnnotations;

	public partial class Sssettings
    {
		[Key]
        public string GroupName { get; set; }
		[Key]
        public string KeyName { get; set; }
        public string KeyValue { get; set; }
        public string StringValue { get; set; }
        public string BinaryValue { get; set; }
        public string Description { get; set; }
    }
}
