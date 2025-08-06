using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageAppNew.Models;

namespace RazorPageAppNew.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageAppNew.Models.OrgContext _context;

        public DetailsModel(RazorPageAppNew.Models.OrgContext context)
        {
            _context = context;
        }

        public Organization Organization { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organization = await _context.organizations.FirstOrDefaultAsync(m => m.Id == id);
            if (organization == null)
            {
                return NotFound();
            }
            else
            {
                Organization = organization;
            }
            return Page();
        }
    }
}
