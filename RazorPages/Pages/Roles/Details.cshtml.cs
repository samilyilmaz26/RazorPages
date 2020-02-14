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
    public class DetailsModel : PageModel
    {
        private readonly RazorPages.Context.PersonelContext _context;

        public DetailsModel(RazorPages.Context.PersonelContext context)
        {
            _context = context;
        }

        public Roles Roles { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Roles = await _context.Set<Roles>().FirstOrDefaultAsync(m => m.RoleId == id);

            if (Roles == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
