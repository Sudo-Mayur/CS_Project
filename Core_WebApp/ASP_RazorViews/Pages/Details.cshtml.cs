#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_RazorViews.Models;

namespace ASP_RazorViews.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ASP_RazorViews.Models.ApiDbContext _context;

        public DetailsModel(ASP_RazorViews.Models.ApiDbContext context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Categories.FirstOrDefaultAsync(m => m.CategoryRowId == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
