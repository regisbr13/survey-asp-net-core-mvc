using Microsoft.EntityFrameworkCore;
using Survey.Models;

namespace Survey.Data
{
    public class SurveyContext : DbContext
    {
        public DbSet<ProgrammingLanguage> Languages { get; set; }

        public SurveyContext(DbContextOptions<SurveyContext> options) : base(options)
        {
        }
    }
}
