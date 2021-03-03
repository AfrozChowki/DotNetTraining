using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AspNetCoreGitHubAuth.Utility;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreGitHubAuth.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                string token = string.Empty;
                string accessToken = string.Empty;

                if (TempData.ContainsKey("token"))
                    token = TempData["token"] as string;

                if (TempData.ContainsKey("accessToken"))
                    accessToken = TempData["accessToken"] as string;

                TempData.Keep();

                string userName = TokenManager.ValidateToken(token, accessToken);
                string actualUserName = User.FindFirst(c => c.Type == ClaimTypes.Name)?.Value;

                if (!string.IsNullOrEmpty(userName) && userName.Equals(actualUserName))
                {
                    Message = "Welcome you are authenticated";
                }
                else
                {
                    Message = "Sorry, you don't have access to this page.";
                }
            }
            else
            {
                Message = "Sorry, you don't have access to this page.";
            }
        }
    }
}
