using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Universite.Data;
using Universite.Model;

namespace Universite.Pages.Etudiants
{
    public class DetailsModel : PageModel
    {
        private readonly Universite.Data.ApplicationDbContext _context;

        public DetailsModel(Universite.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Etudiant Etudiant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var etudiant = await _context.Etudiant.FirstOrDefaultAsync(m => m.ID == id);
            if (etudiant == null)
            {
                return NotFound();
            }
            else
            {
                Etudiant = etudiant;
            }
            return Page();
        }
    }
}
