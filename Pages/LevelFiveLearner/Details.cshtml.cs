using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Capenexis2022Learners.Data;
using Capenexis2022Learners.Models;

namespace Capenexis2022Learners.Pages.LevelFiveLearner
{
    public class DetailsModel : PageModel
    {
        private readonly Capenexis2022Learners.Data.Capenexis2022LearnersContext _context;

        public DetailsModel(Capenexis2022Learners.Data.Capenexis2022LearnersContext context)
        {
            _context = context;
        }

      public LevelFiveLearners LevelFiveLearners { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.LevelFiveLearners == null)
            {
                return NotFound();
            }

            var levelfivelearners = await _context.LevelFiveLearners.FirstOrDefaultAsync(m => m.Id == id);
            if (levelfivelearners == null)
            {
                return NotFound();
            }
            else 
            {
                LevelFiveLearners = levelfivelearners;
            }
            return Page();
        }
    }
}
