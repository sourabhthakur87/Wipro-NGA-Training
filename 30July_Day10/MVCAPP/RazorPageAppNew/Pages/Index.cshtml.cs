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
    public class IndexModel : PageModel
    {
        private readonly RazorPageAppNew.Models.OrgContext _context;

        public IndexModel(RazorPageAppNew.Models.OrgContext context)
        {
            _context = context;
        }

        public IList<Organization> Organization { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Organization = await _context.organizations.ToListAsync();
        }
    }
}
