using System;
using System.Collections.Generic;
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
        public int User_ID { get; set; }
        public string User_Email { get; set; }
        public string User_Password { get; set; }

    }
    public class CarModel
    {
        public int Car_ID { get; set; }
        public Blob Car_Image { get; set; }
        public string Car_Make { get; set; }
        public string Car_Series { get; set; }

        public string Car_Type { get; set; }

        public float Car_Cost { get; set; }
    }

    public class FinanceModel
    {
        public int Request_ID { get; set; }
        public string Approval_Status { get; set; }
        public float Amount_To_Finance { get; set; }
        public int Admin_Accounts_Admin_ID { get; set; }

        public int Car_Car_ID { get; set; }
        public int User_Accounts_User_ID { get; set; }
    }
}