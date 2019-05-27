using System;
using System.ComponentModel.DataAnnotations;

namespace yesterdayinspace.Models
{
    public class MPContent
    {
        public int ID { get; set; }
		public string Title { get; set; }
		public string Embed { get; set; }
		public string BandURL { get; set; }
        public string SoundURL { get; set; }
		public string Info { get; set; }
    }
}