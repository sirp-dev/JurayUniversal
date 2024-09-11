﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JurayUniversal.Domain.Models;
using JurayUniversal.Persistence.EF.SQL;

namespace JurayUniversal.Website.Areas.Management.Pages.DeviceSetup
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin")]

    public class EditModel : PageModel
    {
        private readonly JurayUniversal.Persistence.EF.SQL.DashboardDbContext _context;

        public EditModel(JurayUniversal.Persistence.EF.SQL.DashboardDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EnableDevice EnableDevice { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EnableDevice = await _context.EnableDevices.FirstOrDefaultAsync(m => m.Id == id);

            if (EnableDevice == null)
            {
                return NotFound();
            }
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

            _context.Attach(EnableDevice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnableDeviceExists(EnableDevice.Id))
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

        private bool EnableDeviceExists(long id)
        {
            return _context.EnableDevices.Any(e => e.Id == id);
        }
    }
}
