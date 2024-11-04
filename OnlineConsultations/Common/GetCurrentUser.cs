using System.Security.Claims;

namespace OnlineConsultations.Common
{
    public static class GetCurrentUser
    {
       
        public static string GetCurrentUserId(this ClaimsPrincipal claimsPrincipalUser)
        {
            return claimsPrincipalUser.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        
        public static string GetCurrentUserName(this ClaimsPrincipal claimsPrincipalUser)
        {
            return claimsPrincipalUser.FindFirstValue(ClaimTypes.Name);
        }
    }
}
