﻿using Amazon.S3;
using JurayUniversal.Persistence.EF.SQL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JurayUniversal.Pages.Shared.ViewComponents
{
    public class CompanyNameViewComponent : ViewComponent
    {
        private readonly DashboardDbContext _context;
         
        public CompanyNameViewComponent(
            DashboardDbContext context)
        {
            _context = context;
        }

        public string UserInfo { get; set; }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var xsetting = await _context.SuperSettings.FirstOrDefaultAsync();
            TempData["companyname"] = xsetting.CompanyName;
            TempData["CompanyWebsiteLink"] = xsetting.CompanyWebsiteLink;
            return View();
        }
    }
}
