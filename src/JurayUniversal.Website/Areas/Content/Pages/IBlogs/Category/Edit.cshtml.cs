﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using JurayUniversal.Domain.Models;

namespace JurayUniversal.Website.Areas.Content.Pages.IBlogs.Category
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Editor")]

    public class EditModel : PageModel
    {
        private readonly JurayUniversal.Persistence.EF.SQL.DashboardDbContext _context;

        public EditModel(JurayUniversal.Persistence.EF.SQL.DashboardDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BlogCategory BlogCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BlogCategory = await _context.BlogCategories.FirstOrDefaultAsync(m => m.Id == id);

            if (BlogCategory == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            

            _context.Attach(BlogCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync(); TempData["success"] = "Successful";
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlogCategoryExists(BlogCategory.Id))
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

        private bool BlogCategoryExists(long id)
        {
            return _context.BlogCategories.Any(e => e.Id == id);
        }
    }
}
