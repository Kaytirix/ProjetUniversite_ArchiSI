using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Universite.Data;
using Universite.Model;

namespace Universite.Pages.Enseignants
{
    public class CreateModel : PageModel
    {
        private readonly Universite.Data.ApplicationDbContext _context;

        public CreateModel(Universite.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Enseignant Enseignant { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Enseignants.Add(Enseignant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
