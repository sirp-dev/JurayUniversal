﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JurayUniversal.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JurayUniversal.Website.Areas.ThemePage.Pages.ITemplate
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin")]

    public class DetailsModel : PageModel
    {
        private readonly JurayUniversal.Persistence.EF.SQL.DashboardDbContext _context;

        public DetailsModel(JurayUniversal.Persistence.EF.SQL.DashboardDbContext context)
        {
            _context = context;
        }

        public TemplateType TemplateType { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TemplateType = await _context.TemplateTypes.FirstOrDefaultAsync(m => m.Id == id);

            if (TemplateType == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
