using System;
using System.ComponentModel.DataAnnotations;

namespace yesterdayinspace.Models
{
    public class GPContent
    {
        public int ID { get; set; }
		public string Type { get; set; }
		public string ThumbURL { get; set; }
        public string URL { get; set; }
        public string Caption { get; set; }
    }
}
