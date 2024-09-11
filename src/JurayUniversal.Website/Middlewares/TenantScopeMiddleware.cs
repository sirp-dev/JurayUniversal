﻿using System.Net;
using System.Reflection.Metadata;
using JurayUniversal.Application.Dtos;
using JurayUniversal.Application.Repository.DomainServices;
using JurayUniversal.Infrastructure.TenantSupport;

namespace JurayUniversal.Website.Middlewares;
//https://github.com/Oriflame/JurayUniversal#multiple-databases---complete-data-isolation
public class TenantScopeMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IDomainRepository _domainRepository;

    public TenantScopeMiddleware(RequestDelegate next, IDomainRepository domainRepository)
    {
        _next = next;
        _domainRepository = domainRepository;
    }

    public async Task Invoke(HttpContext httpContext, ITenantProvider tenantProvider)
    {

        // Got htis code from  http://blog.gaxion.com/2017/05/how-to-implement-multi-tenancy-with.html
        var GetAddress = httpContext.Request.Headers["Host"];

        var tenant = GetAddress[0];
        tenant = tenant.Replace("www.", "");
        tenant = tenant.Replace("https://", "");
        //, , , 
        //List<DomainListDto> domains = await _domainRepository.GetAllDomains();

        if (IPAddress.TryParse(tenant, out IPAddress ipAddress))
        {
            // It's an IP address, handle it accordingly
            using var scope = tenantProvider.BeginScope(tenant);
            await _next(httpContext);
            return;
        }
        else
        {


            if (tenant.ToString().ToLower() == "localhost:7543")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;

            }
            else if (tenant.ToString().ToLower() == "localhost:8083")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;

            }
            else if (tenant.ToString().ToLower() == "paramallam.com.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;

            }
            else if (tenant.ToString().ToLower() == "pslcnipss.com")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;

            }
            else if (tenant.ToString().ToLower() == "ikeconsults.com")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;

            }
            else if (tenant.ToString().ToLower() == "res.com.ng")//;Initial Catalog=;User Id=
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "demo.juray.ng")//;Initial Catalog=;User Id=
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "divinethreshersschools.com.ng")//;Initial Catalog=;User Id=
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "juray.ng")//;Initial Catalog=;User Id=
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "demo.juray.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "chukwuebukahospital.com.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "cambeduconsult.com.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "hrssu.com")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "mi4ture.com")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "exwhyzee.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "ekefinn.com")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "poly.juray.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "health.juray.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "koboview.com")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "fan.juray.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "cic.juray.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "default.juray.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "14.1.22.213")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "health.gov.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "nipssportal.com.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "nipsskuru.gov.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            } 
            else if (tenant.ToString().ToLower() == "sine-theta.com")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "flab.juray.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "hladi.africa")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "nipsstest.juray.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "booksub.juray.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "motimo.juray.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "mbp.juray.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }
            else if (tenant.ToString().ToLower() == "littlesmile.com.ng")
            {
                using var scope = tenantProvider.BeginScope(tenant);
                await _next(httpContext);

                return;
            }

            else
            {
                //var matchedDomain = domains.FirstOrDefault(d => d.Domain.Equals(tenant, StringComparison.OrdinalIgnoreCase));

                //if (matchedDomain != null)
                //{
                //    tenant = matchedDomain.BaseDomain;
                //    using var scope = tenantProvider.BeginScope(tenant);
                //    await _next(httpContext);

                //    return;
                //}
                return;
            }
        }

        await _next(httpContext);
    }
}

/// <summary>
/// Extension method used to add the middleware to the HTTP request pipeline.
/// </summary>
public static class TenantScopeMiddlewareExtensions
{
    public static IApplicationBuilder UseTenantScopeMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<TenantScopeMiddleware>();
    }
}
