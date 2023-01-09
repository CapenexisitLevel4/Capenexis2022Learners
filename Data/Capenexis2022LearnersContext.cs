using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Capenexis2022Learners.Models;

namespace Capenexis2022Learners.Data
{
    public class Capenexis2022LearnersContext : DbContext
    {
        public Capenexis2022LearnersContext (DbContextOptions<Capenexis2022LearnersContext> options)
            : base(options)
        {
        }

        public DbSet<Capenexis2022Learners.Models.Learners> Learners { get; set; } = default!;

        public DbSet<Capenexis2022Learners.Models.LevelFiveLearners> LevelFiveLearners { get; set; } = default!;
    }
}
