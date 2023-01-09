using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Capenexis2022Learners.Data;
using Capenexis2022Learners.Models;

namespace Capenexis2022Learners.Pages.LevelFiveLearner
{
    public class EditModel : PageModel
    {
        private readonly Capenexis2022Learners.Data.Capenexis2022LearnersContext _context;

        public EditModel(Capenexis2022Learners.Data.Capenexis2022LearnersContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LevelFiveLearners LevelFiveLearners { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.LevelFiveLearners == null)
            {
                return NotFound();
            }

            var levelfivelearners =  await _context.LevelFiveLearners.FirstOrDefaultAsync(m => m.Id == id);
            if (levelfivelearners == null)
            {
                return NotFound();
            }
            LevelFiveLearners = levelfivelearners;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(LevelFiveLearners).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LevelFiveLearnersExists(LevelFiveLearners.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LevelFiveLearnersExists(int id)
        {
          return (_context.LevelFiveLearners?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
