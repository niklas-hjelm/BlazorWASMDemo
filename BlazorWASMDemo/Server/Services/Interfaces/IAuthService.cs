namespace BlazorWASMDemo.Server.Services.Interfaces
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> RegisterUser(User user, string password);
        Task<bool> UserExists(string email);
    }
}
