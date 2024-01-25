using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Universite.Data;
using Universite.Model;

namespace Universite.Pages.Enseignants
{
    public class DetailsModel : PageModel
    {
        private readonly Universite.Data.ApplicationDbContext _context;

        public DetailsModel(Universite.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Enseignant Enseignant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var enseignant = await _context.Enseignants.FirstOrDefaultAsync(m => m.ID == id);

            // Requête avec inclusion des relations
            var enseignant = await _context.Enseignants
                .Include(i => i.LesEnseigner)
                    .ThenInclude(i => i.LUE)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (enseignant == null)
            {
                return NotFound();
            }
            else
            {
                Enseignant = enseignant;
            }
            return Page();
        }
    }
}
