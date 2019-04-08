using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Data
{
    public class SeedingService
    {
        private readonly SurveyContext _context;

        public SeedingService(SurveyContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Languages.Any())
            {
                return;
            }

            ProgrammingLanguage pl1 = new ProgrammingLanguage("C#", 0);
            ProgrammingLanguage pl2 = new ProgrammingLanguage("Java", 0);
            ProgrammingLanguage pl3 = new ProgrammingLanguage("Javascript", 0);
            ProgrammingLanguage pl4 = new ProgrammingLanguage("C/C++", 0);
            ProgrammingLanguage pl5 = new ProgrammingLanguage("Ruby", 0);
            ProgrammingLanguage pl6 = new ProgrammingLanguage("Python", 0);
            ProgrammingLanguage pl7 = new ProgrammingLanguage("Outra", 0);

            _context.AddRange(pl1, pl2, pl3, pl4, pl5, pl6, pl7);
            _context.SaveChanges();
        }
    }
}
