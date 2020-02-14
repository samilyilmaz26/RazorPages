using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Context;
using RazorPages.Entities;

namespace RazorPages
{
    public class IndexModel : PageModel
    {
        private readonly RazorPages.Context.PersonelContext _context;

        public IndexModel(RazorPages.Context.PersonelContext context)
        {
            _context = context;
        }

        public IList<Roles> Roles { get;set; }

        public async Task OnGetAsync()
        {
            Roles = await _context.Set<Roles>().ToListAsync();
        }
    }
}
