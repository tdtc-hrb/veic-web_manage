using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using veic_web.Models;
using veic_web.Models.Data;

namespace veic_web.Pages.Articles
{
    public class IndexModel : PageModel
    {
        private readonly veic_web.Models.Data.CarnumberDbContext _context;

        public IndexModel(veic_web.Models.Data.CarnumberDbContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            Article = await _context.Articles
                .Include(a => a.Type).ToListAsync();
        }
    }
}
