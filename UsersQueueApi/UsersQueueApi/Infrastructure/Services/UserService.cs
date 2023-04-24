using Microsoft.AspNetCore.Http;
using UsersQueueApi.Application.Common.Interfaces.Services;

namespace UsersQueueApi.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        
        public string GetUser()
        {
            string userName = _httpContextAccessor.HttpContext?.Request?.Headers["UserName"];
            return string.IsNullOrEmpty(userName) ? "S/D" : userName;
        }
        public string GetIp()
        {
            string userName = _httpContextAccessor.HttpContext?.Connection.RemoteIpAddress.ToString();
            return string.IsNullOrEmpty(userName) ? "S/D" : userName;
        }
    }
}
