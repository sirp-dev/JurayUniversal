﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using JurayUniversal.Domain.Models;
using JurayUniversal.Domain.Models.NIPSS;

namespace JurayUniversal.Website.Areas.NIPSSADMIN.Pages.EVP
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Admin")]

    public class DetailsModel : PageModel
    {
        private readonly JurayUniversal.Persistence.EF.SQL.DashboardDbContext _context;

        public DetailsModel(JurayUniversal.Persistence.EF.SQL.DashboardDbContext context)
        {
            _context = context;
        }

        public EvaluationQuestion EvaluationQuestion { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EvaluationQuestion = await _context.EvaluationQuestions
              
                .FirstOrDefaultAsync(m => m.Id == id);

            if (EvaluationQuestion == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
