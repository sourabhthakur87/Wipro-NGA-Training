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
    public class DetailsModel : PageModel
    {
        private readonly StroreRazorPageApp.Data.EcomContext _context;

        public DetailsModel(StroreRazorPageApp.Data.EcomContext context)
        {
            _context = context;
        }

        public Categories Categories { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _context.Categories.FirstOrDefaultAsync(m => m.Id == id);
            if (categories == null)
            {
                return NotFound();
            }
            else
            {
                Categories = categories;
            }
            return Page();
        }
    }
}
