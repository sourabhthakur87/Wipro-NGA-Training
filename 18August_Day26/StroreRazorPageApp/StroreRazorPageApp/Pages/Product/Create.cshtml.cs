using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StroreRazorPageApp.Data;
using StroreRazorPageApp.Models;

namespace StroreRazorPageApp.Pages.Product
{
    public class CreateModel : PageModel
    {
        private readonly StroreRazorPageApp.Data.EcomContext _context;

        public CreateModel(StroreRazorPageApp.Data.EcomContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Price"] = new SelectList(_context.Categories, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Products Products { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add(Products);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
