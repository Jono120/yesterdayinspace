using System;
using System.ComponentModel.DataAnnotations;

namespace yesterdayinspace.Models
{
    public class CCEntity
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
		public string AltRole { get; set; }
        public string ThumbImg { get; set; }
        public string BioImg { get; set; }
        public string BioText { get; set; }

		public string Social1Type { get; set; }
		public string Social1URL { get; set; }
		public string Social1Display { get; set; }

		public string Social2Type { get; set; }
		public string Social2URL { get; set; }
		public string Social2Display { get; set; }

		public string Social3Type { get; set; }
		public string Social3URL { get; set; }
		public string Social3Display { get; set; }

		public string Social4Type { get; set; }
		public string Social4URL { get; set; }
		public string Social4Display { get; set; }

		public string Social5Type { get; set; }
		public string Social5URL { get; set; }
		public string Social5Display { get; set; }
    }
}
