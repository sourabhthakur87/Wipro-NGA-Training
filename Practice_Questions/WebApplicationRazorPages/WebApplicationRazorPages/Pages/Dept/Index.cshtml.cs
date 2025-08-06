﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationRazorPages.Models;

namespace WebApplicationRazorPages.Pages.Dept
{
    public class IndexModel : PageModel
    {
        private readonly WebApplicationRazorPages.Models.OrgContext _context;

        public IndexModel(WebApplicationRazorPages.Models.OrgContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Department = await _context.departments
                .Include(d => d.org).ToListAsync();
        }
    }
}
