using System;
using System.Collections.Generic;

namespace hvcp_web_api.Entities
{
	using System.ComponentModel.DataAnnotations;

	public partial class Demographics
    {
		[Key]
        public int Ss_Patient_Id { get; set; }
        public int? Ss_Parent_Id { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Patient_Id { get; set; }
        public string Account_Number { get; set; }
        public string Gender { get; set; }
        public DateTime? Date_Of_Birth { get; set; }
        public string Race { get; set; }
        public string Note { get; set; }
        public string PatientFullName { get; set; }
        public string PatientPrefix { get; set; }
        public string PatientSuffix { get; set; }

		public ICollection<Dicomstudies> Dicomstudies { get; set; }
		= new List<Dicomstudies>();
    }
}
