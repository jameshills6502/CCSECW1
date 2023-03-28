using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Models
{
    public class UserModel
    {
        [Required][EmailAddress]public string Email { get; set;}
        [Required][MinLength(6, ErrorMessage= "Password must be 6 characters long")]public string Password { get; set;}
    }
}