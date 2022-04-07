using System.ComponentModel.DataAnnotations;

namespace BlazorWASMDemo.Shared
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;
        [Compare("Password")]
        public string PasswordConfirm { get; set; } = string.Empty;
    }
}
