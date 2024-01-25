using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Universite.Data;
using Universite.Model;

namespace Universite.Pages.Formations
{
    public class DetailsModel : PageModel
    {
        private readonly Universite.Data.ApplicationDbContext _context;

        public DetailsModel(Universite.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Formation Formation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formation = await _context.Formation
                .Include(f => f.EtudiantsInscrits)
                .Include(Ue => Ue.UeAttache)
                .FirstOrDefaultAsync(m => m.ID == id);
            
            if (formation == null)
            {
                return NotFound();
            }
            else
            {
                Formation = formation;
            }
            return Page();
        }
    }
}
