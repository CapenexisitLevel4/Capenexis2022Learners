using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Capenexis2022Learners.Data;
using Capenexis2022Learners.Models;

namespace Capenexis2022Learners.Pages.LevelFiveLearner
{
    public class CreateModel : PageModel
    {
        private readonly Capenexis2022Learners.Data.Capenexis2022LearnersContext _context;

        public CreateModel(Capenexis2022Learners.Data.Capenexis2022LearnersContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public LevelFiveLearners LevelFiveLearners { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.LevelFiveLearners == null || LevelFiveLearners == null)
            {
                return Page();
            }

            _context.LevelFiveLearners.Add(LevelFiveLearners);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
