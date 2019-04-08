using Microsoft.AspNetCore.Mvc;
using Survey.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Models.ViewComponents
{
    public class ProgrammingLanguageViewComponent : ViewComponent
    {
        private readonly LanguageService _service;

        public ProgrammingLanguageViewComponent(LanguageService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _service.FindAllAsync());
        }
    }
}
