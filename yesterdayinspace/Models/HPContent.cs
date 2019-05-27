using System;
using System.ComponentModel.DataAnnotations;

namespace yesterdayinspace.Models
{
    public class HPContent
    {
        public int ID { get; set; }
        public string Section { get; set; }
		public string Title { get; set; }
		public string URL { get; set; }
		public string Caption { get; set; }
		public string Social { get; set; }
		public string Thumb { get; set; }
    }
}
