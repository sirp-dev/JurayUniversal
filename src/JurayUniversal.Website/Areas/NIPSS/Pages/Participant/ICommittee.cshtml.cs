using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JurayUniversal.Website.Areas.NIPSS.Pages.Participant
{
    [Microsoft.AspNetCore.Authorization.Authorize]

    public class ICommitteeModel : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("/Dashboard/ComingSoon", new { area = "NIPSS" });
        }
    }
}
