using System;
using System.Collections.Generic;
using System.Linq;
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
}