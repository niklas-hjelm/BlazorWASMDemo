using BlazorWASMDemo.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorWASMDemo.Client.Pages
{
    partial class RegisterUser : ComponentBase
    {
        [Inject]
        private IAuthService AuthService { get; set; }

        UserRegister _user = new UserRegister();

        string _message = string.Empty;
        string _messageCssClass = string.Empty;
        
        async Task HandleSubmit()
        {
            var result = await AuthService.Register(_user);
            _message = result.Message;

            _messageCssClass = result.Success ? "text-success" : "text-danger";
        }
    }
}
