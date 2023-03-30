using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required][EmailAddress]public string Email { get; set;}
        [Required][MinLength(6, ErrorMessage= "Password must be 6 characters long")]public string Password { get; set;}
    }
}