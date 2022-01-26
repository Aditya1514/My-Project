using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication13.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="UserName can't be blank")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password can't be blank")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Password should be neccesary")]
        [Compare("Password",ErrorMessage ="Password should be same")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Email Can't be blank")]
        [EmailAddress(ErrorMessage ="Invalid email")]
        public string Email { get; set; }
        public string Mobile { get; set; }
       
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}