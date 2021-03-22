using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using veic_web.Models;
using veic_web.Models.Data;

namespace veic_web.Pages.Articles
{
    public class CreateModel : PageModel
    {
        private readonly veic_web.Models.Data.CarnumberDbContext _context;

        public CreateModel(veic_web.Models.Data.CarnumberDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Type_id"] = new SelectList(_context.Types, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Article Article { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Articles.Add(Article);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
