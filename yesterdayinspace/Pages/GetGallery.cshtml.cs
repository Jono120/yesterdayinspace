using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using yesterdayinspace.Models;

namespace yesterdayinspace.Pages.GPContents
{
    public class GPContentsModel : PageModel
    {
        private readonly yesterdayinspace.Models.YISContext _context;

        public GPContentsModel(yesterdayinspace.Models.YISContext context)
        {
            _context = context;
        }

        public IList<GPContent> GPContent { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            IQueryable<GPContent> Gallery = from s in _context.GPContent
                                            select s;

            Gallery = Gallery.OrderByDescending(s => s.ID);

            GPContent = await Gallery.AsNoTracking().ToListAsync();

            return new JsonResult(GPContent);
        }
    }
}