﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly StroreRazorPageApp.Data.EcomContext _context;

        public DetailsModel(StroreRazorPageApp.Data.EcomContext context)
        {
            _context = context;
        }

        public Products Products { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (products == null)
            {
                return NotFound();
            }
            else
            {
                Products = products;
            }
            return Page();
        }
    }
}
