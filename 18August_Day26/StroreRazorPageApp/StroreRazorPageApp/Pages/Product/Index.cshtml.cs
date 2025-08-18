using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StroreRazorPageApp.Data;
using StroreRazorPageApp.Models;

namespace StroreRazorPageApp.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly StroreRazorPageApp.Data.EcomContext _context;

        public IndexModel(StroreRazorPageApp.Data.EcomContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Products = await _context.Products
                .Include(p => p.categ).ToListAsync();
        }
    }
}
