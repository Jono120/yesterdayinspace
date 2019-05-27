using Microsoft.EntityFrameworkCore;
namespace yesterdayinspace.Models
{
    public class YISContext : DbContext
    {
        public YISContext(DbContextOptions<YISContext> options)
            : base(options)
        {
        }

        public DbSet<yesterdayinspace.Models.CCEntity> CCEntity { get; set; }
		public DbSet<yesterdayinspace.Models.APContent> APContent { get; set; }
		public DbSet<yesterdayinspace.Models.GPContent> GPContent { get; set; }
		public DbSet<yesterdayinspace.Models.MPContent> MPContent { get; set; }
		public DbSet<yesterdayinspace.Models.HPContent> HPContent { get; set; }
    }
}
