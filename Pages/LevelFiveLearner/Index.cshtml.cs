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
    public class IndexModel : PageModel
    {
        private readonly Capenexis2022Learners.Data.Capenexis2022LearnersContext _context;

        public IndexModel(Capenexis2022Learners.Data.Capenexis2022LearnersContext context)
        {
            _context = context;
        }

        public IList<LevelFiveLearners> LevelFiveLearners { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.LevelFiveLearners != null)
            {
                LevelFiveLearners = await _context.LevelFiveLearners.ToListAsync();
            }
        }
    }
}
