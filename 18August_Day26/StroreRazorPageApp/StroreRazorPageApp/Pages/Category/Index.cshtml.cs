using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StroreRazorPageApp.Data;
using StroreRazorPageApp.Models;

namespace StroreRazorPageApp.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly StroreRazorPageApp.Data.EcomContext _context;

        public IndexModel(StroreRazorPageApp.Data.EcomContext context)
        {
            _context = context;
        }

        public IList<Categories> Categories { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Categories = await _context.Categories.ToListAsync();
        }
    }
}
