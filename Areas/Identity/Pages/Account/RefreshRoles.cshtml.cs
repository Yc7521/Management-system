using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using 管理系统.Models;

namespace 管理系统.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RefreshRolesModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public string ReturnUrl { get; set; }

        public RefreshRolesModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            // 创建用户组
            foreach (var role in Role.Roles)
            {
                if (!await _roleManager.RoleExistsAsync(role))
                    await _roleManager.CreateAsync(new(role));
            }
            return LocalRedirect(returnUrl);
        }
    }
}