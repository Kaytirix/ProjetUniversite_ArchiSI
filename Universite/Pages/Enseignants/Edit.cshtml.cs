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

namespace Universite.Pages.Enseignants
{
    public class EditModel : PageModel
    {
        private readonly Universite.Data.ApplicationDbContext _context;

        public EditModel(Universite.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Enseignant Enseignant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enseignant =  await _context.Enseignants.FirstOrDefaultAsync(m => m.ID == id);
            if (enseignant == null)
            {
                return NotFound();
            }
            Enseignant = enseignant;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Enseignant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnseignantExists(Enseignant.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EnseignantExists(int id)
        {
            return _context.Enseignants.Any(e => e.ID == id);
        }
    }
}
