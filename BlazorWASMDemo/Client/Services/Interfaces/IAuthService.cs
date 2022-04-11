using BlazorWASMDemo.Shared;

namespace BlazorWASMDemo.Client.Services.Interfaces
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(UserRegister request);
        Task<ServiceResponse<string>> Login(UserLogin request);
    }
}
