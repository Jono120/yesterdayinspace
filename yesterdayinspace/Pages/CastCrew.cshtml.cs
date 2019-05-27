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
    public class CastCrewModel : PageModel
    {
        private readonly yesterdayinspace.Models.YISContext _context;

        public CastCrewModel(yesterdayinspace.Models.YISContext context)
        {
            _context = context;
        }

        public IList<CCEntity> CCEntity { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<CCEntity> Entity = from s in _context.CCEntity
                                            select s;

            Entity = Entity.OrderBy(s => s.Name);

            CCEntity = await Entity.AsNoTracking().ToListAsync();
        }
    }
}