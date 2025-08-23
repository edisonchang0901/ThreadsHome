using MediatR;

namespace ThreadsHome.API.Controllers.Base
{
    public abstract class AuthenticationControllerBase(ISender sender,
                                                       IHttpContextAccessor httpContextAccessor) : ThreadsHomeControllerBase(sender)
    {
       public string GetUserMid()
        {
            // 從 HttpContext 中取得使用者 ID
            //string userId = httpContextAccessor.HttpContext?.User?.FindFirst("Mid")?.Value;
            string userId = "testMid";
            if (string.IsNullOrEmpty(userId))
            {
                throw new UnauthorizedAccessException("User is not authenticated.");
            }
            return userId;
        }
    }
}
