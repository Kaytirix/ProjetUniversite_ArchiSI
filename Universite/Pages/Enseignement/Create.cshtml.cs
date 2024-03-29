﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Universite.Data;
using Universite.Model;

namespace Universite.Pages.Enseignement
{
    public class CreateModel : PageModel
    {
        private readonly Universite.Data.ApplicationDbContext _context;

        public Enseignant Enseignant { get; set; }

        public CreateModel(Universite.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Enseignant = await _context.Enseignants
                .Include(e => e.LesEnseigner)
                .ThenInclude(u => u.LUE)
                .FirstOrDefaultAsync(m => m.ID == (int)id);
            ViewData["LUEID"] = new SelectList(_context.UE, "ID", "Intitule");

            return Page();
        }


        [BindProperty]
        public Enseigner Enseigner { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Enseigner.Add(Enseigner);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Enseignement/Index", new { id = Enseigner.LEnseignantID });
        }
    }
}
