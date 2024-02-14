

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Universite.Model;

namespace Universite.Pages.Notes
{
    public class EditModel : PageModel
    {
        private readonly Universite.Data.ApplicationDbContext _context;

        public EditModel(Universite.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public UE UE { get; set; }

        public IActionResult OnGet()
        {
            ViewData["ListeUE"] = new SelectList(_context.UE, "ID", "Intitule");

            return Page();
        }

    }
}
