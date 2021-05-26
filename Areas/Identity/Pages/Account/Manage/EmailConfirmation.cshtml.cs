using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace 管理系统.Areas.Identity.Pages.Account.Manage
{
    [AllowAnonymous]
    public class EmailConfirmationModel : PageModel
    {
        public EmailConfirmationModel() { }

        public string Email { get; set; }

        public bool Error { get; set; }
        public List<string> Msg { get; set; }

        public string EmailConfirmationUrl { get; set; }

        public IActionResult OnGet(string userId, string code)
        {
            Msg = new List<string>();
            if (userId == null)
            {
                Error = true;
                Msg.Add("未知的用户");
            }

            if (code == null)
            {
                Error = true;
                Msg.Add("未知的token");
            }
            if (!Error)
                EmailConfirmationUrl = Url.Page(
                    "/Account/ConfirmEmail",
                    pageHandler: null,
                    values: new { area = "Identity", userId = userId, code = code },
                    protocol: Request.Scheme);

            return Page();
        }
    }
}
