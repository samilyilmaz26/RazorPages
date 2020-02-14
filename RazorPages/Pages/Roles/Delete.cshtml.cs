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
    public class DeleteModel : PageModel
    {
        private readonly RazorPages.Context.PersonelContext _context;

        public DeleteModel(RazorPages.Context.PersonelContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Roles = await _context.Set<Roles>().FindAsync(id);

            if (Roles != null)
            {
                _context.Set<Roles>().Remove(Roles);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
