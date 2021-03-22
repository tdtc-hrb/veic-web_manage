using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using veic_web.Models;
using veic_web.Models.Data;

namespace veic_web.Pages.Languages
{
    public class DeleteModel : PageModel
    {
        private readonly veic_web.Models.Data.CarnumberDbContext _context;

        public DeleteModel(veic_web.Models.Data.CarnumberDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Language Language { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Language = await _context.Languages.FirstOrDefaultAsync(m => m.Id == id);

            if (Language == null)
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

            Language = await _context.Languages.FindAsync(id);

            if (Language != null)
            {
                _context.Languages.Remove(Language);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
