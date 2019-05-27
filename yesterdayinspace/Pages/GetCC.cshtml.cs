using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using yesterdayinspace.Models;

namespace yesterdayinspace.Pages.CCEntities
{
    public class GetEntityModel : PageModel
    {
        private readonly yesterdayinspace.Models.YISContext _context;

        public GetEntityModel(yesterdayinspace.Models.YISContext context)
        {
            _context = context;
        }

        public CCEntity CCEntity { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CCEntity = await _context.CCEntity.FirstOrDefaultAsync(m => m.ID == id);

            if (CCEntity == null)
            {
                return NotFound();
            }
            return new JsonResult(CCEntity);
        }
    }
}