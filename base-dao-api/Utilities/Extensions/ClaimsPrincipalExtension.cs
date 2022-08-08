using System.Security.Claims;
using base_dao_api.Utilities.Constants;

namespace base_dao_api.Utilities.Extensions
{
    public static class ClaimsPrincipalExtension
    {
        public static string GetUserName(this ClaimsPrincipal claimsPrincipal)
        {
            string res = "SYSTEM";

            if (claimsPrincipal != null)
            {
                // CHECK IF NAME EXISTS
                res = claimsPrincipal.FindFirstValue(ClaimTypes.Name) == null ? "SYSTEM" : claimsPrincipal.FindFirstValue(ClaimTypes.Name);

                if (res == "SYSTEM")
                {
                    // DEFAULT TO NAME IDENTIFIER
                    res = claimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier) == null ? "SYSTEM" : claimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier);
                }
                
            }

            return res;
        }

        public static string GetUserRole(this ClaimsPrincipal claimsPrincipal)
        {
            string res = RoleCodes.Normal;

            if (claimsPrincipal != null)
            {
                // CHECK IF ROLE EXISTS
                res = claimsPrincipal.FindFirstValue(ClaimTypes.Role) == null ? RoleCodes.Normal : claimsPrincipal.FindFirstValue(ClaimTypes.Role);
            }

            return res;
        }

        public static string GetUserWallet(this ClaimsPrincipal claimsPrincipal)
        {
            string res = String.Empty;

            if (claimsPrincipal != null)
            {
                // CHECK IF ROLE EXISTS
                res = claimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier) == null ? String.Empty : claimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier);
            }

            return res;
        }
    }
}
