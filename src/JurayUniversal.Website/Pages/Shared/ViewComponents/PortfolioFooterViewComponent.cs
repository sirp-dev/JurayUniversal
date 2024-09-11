﻿using Amazon.S3;
using JurayUniversal.Application.Dtos;
using JurayUniversal.Application.Repository.Services;
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
    public class PortfolioFooterViewComponent : ViewComponent
    {
        private readonly DashboardDbContext _context;
         private readonly ISettingsService _setting;
        public PortfolioFooterViewComponent(
            DashboardDbContext context, ISettingsService setting)
        {
            _context = context;
            _setting = setting;
        }

        public PortfolioNameAndImageDto UserInfo { get; set; }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var httpContext = HttpContext;
            UserInfo = await _setting.GetPortfolioNameAndPassport(httpContext);
            var mainsetting = await _context.SuperSettings.FirstOrDefaultAsync();
            ViewBag.companyname = mainsetting.CompanyName;
            ViewBag.domain = mainsetting.CompanyWebsiteLink;
            return View(UserInfo);
        }
    }
}
