using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using yesterdayinspace.Models;

namespace yesterdayinspace.Pages.APContents
{
    public class APContentsModel : PageModel
    {
        private readonly yesterdayinspace.Models.YISContext _context;

        public APContentsModel(yesterdayinspace.Models.YISContext context)
        {
            _context = context;
        }

        public IList<APContent> APContent { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<APContent> APage = from s in _context.APContent
                                            select s;

            APage = APage.OrderBy(s => s.ID);

            APContent = await APage.AsNoTracking().ToListAsync();
        }
    }
}