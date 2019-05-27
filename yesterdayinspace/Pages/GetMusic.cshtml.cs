using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using yesterdayinspace.Models;

namespace yesterdayinspace.Pages.MPContents
{
    public class MPContentsModel : PageModel
    {
        private readonly yesterdayinspace.Models.YISContext _context;

        public MPContentsModel(yesterdayinspace.Models.YISContext context)
        {
            _context = context;
        }

        public IList<MPContent> MPContent { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            IQueryable<MPContent> Music = from s in _context.MPContent
                                            select s;

            Music = Music.OrderBy(s => s.ID);

            MPContent = await Music.AsNoTracking().ToListAsync();

            return new JsonResult(MPContent);
        }
    }
}