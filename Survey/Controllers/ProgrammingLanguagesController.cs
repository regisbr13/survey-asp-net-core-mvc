using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Survey.Models;
using Survey.Services;

namespace Survey.Controllers
{
    public class ProgrammingLanguagesController : Controller
    {
        private readonly LanguageService _service;

        public ProgrammingLanguagesController(LanguageService service)
        {
            _service = service;
        }

        // GET: Lista com todos
        public async Task<IActionResult> Index()
        {
            var languages = await _service.FindAllAsync();
            return View(languages);
        }

        // POST: Votar em uma opção
        [HttpPost]
        public async Task<IActionResult> Selected(List<ProgrammingLanguage> languages)
        {
            foreach(var language in languages)
            {
                if (language.Checkbox)
                {
                    ProgrammingLanguage obj = await _service.FindById(language.Id);
                    obj.Vote++;
                    await _service.UpdateAsync(obj);
                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
