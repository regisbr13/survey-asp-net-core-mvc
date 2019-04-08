using Microsoft.EntityFrameworkCore;
using Survey.Data;
using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Services
{
    public class LanguageService
    {
        private readonly SurveyContext _context;

        public LanguageService(SurveyContext context)
        {
            _context = context;
        }


        // Listar todos:
        public async Task<List<ProgrammingLanguage>> FindAllAsync()
        {
            return await _context.Languages.ToListAsync();
        }

        // Buscar por Id:
        public async Task<ProgrammingLanguage> FindById(int id)
        {
            return await _context.Languages.FirstAsync(x => x.Id == id);
        }

        // Atualizar:
        public async Task UpdateAsync(ProgrammingLanguage language)
        {
            bool hasAny = await _context.Languages.AnyAsync(x => x.Id == language.Id);
            if(!hasAny)
            {
                throw new Exception("não encontrado");
            }
            try
            {
                _context.Update(language);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        // Lista com linguagens e votos:
        public List<Object> Objects()
        {
            List<Object> list = new List<object>();
            foreach (var language in _context.Languages.ToList())
            {
                var obj = new { language.Name, language.Vote };
                list.Add(obj);
            }
            return list;
        }
    }
}
