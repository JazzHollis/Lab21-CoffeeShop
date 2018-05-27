using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab21_CoffeShop.Models
{
    public class UserInfo
    {

        [Required]
        public string Firstname { set; get; }

        [Required]
        public string Lastname { set; get; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Enter a valid email")]
        public string Email { set; get; }

        [Required]
        public string Phone { set; get; }

        [Required]
        public string Password { set; get; }


        public UserInfo()
        {

        }

        public UserInfo(string firstname, string lastname, string email, string phone, string password)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Phone = phone;
            Password = password;
        }

    }
}