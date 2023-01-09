using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Capenexis2022Learners.Data;
using Capenexis2022Learners.Models;

namespace Capenexis2022Learners.Pages.Learner
{
    public class DeleteModel : PageModel
    {
        private readonly Capenexis2022Learners.Data.Capenexis2022LearnersContext _context;

        public DeleteModel(Capenexis2022Learners.Data.Capenexis2022LearnersContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Learners Learners { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Learners == null)
            {
                return NotFound();
            }

            var learners = await _context.Learners.FirstOrDefaultAsync(m => m.Id == id);

            if (learners == null)
            {
                return NotFound();
            }
            else 
            {
                Learners = learners;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Learners == null)
            {
                return NotFound();
            }
            var learners = await _context.Learners.FindAsync(id);

            if (learners != null)
            {
                Learners = learners;
                _context.Learners.Remove(Learners);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
