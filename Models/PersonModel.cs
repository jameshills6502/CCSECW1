using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace BlazorServer.Models
{
    public class PersonModel
    {
        public int User_ID { get; set; }
        public string User_Email { get; set; }
    }

    public class AccountModel
    {
        public int ID { get; set; }
        [Required][EmailAddress] public string Email { get; set; }
        [Required][MinLength(6, ErrorMessage = "Password must be 6 characters long")] public string Password { get; set; }
        [Required][Compare("Password")] public string PasswordConfirmation { get; set; }

    }
    public class CarModel
    {
        public int Car_ID { get; set; }
        public string Car_Make { get; set; }
        public string Car_Series { get; set; }

        public string Car_Image { get; set; } = "https://via.placeholder.com/300x300";
        public string Car_Type { get; set; }
        public float Car_Cost { get; set; }

        public CategoryAttribute Category { get; set; }
        public int CategoryId { get; set; }
    }

    public class FinanceModel
    {
        public int Request_ID { get; set; }
        public string Approval_Status { get; set; }
        public float Amount_To_Finance { get; set; }
        public int Admin_ID { get; set; }

        public int Car_ID { get; set; }
        public int User_ID { get; set; }
    }
}