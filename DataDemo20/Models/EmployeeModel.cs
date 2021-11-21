using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataDemo20.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID")]
        [Range(100, 999, ErrorMessage = "You need to enter a valid EmployeeId")]
        public int EmployeeId { get; set; }


        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "You need to give us your first name.")]
        public string FirstName { get; set; }


        [Display(Name = "LastName")]
        [Required(ErrorMessage = "You need to give us your last name.")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "The Email and Confirm Email must match")]
        public string EmailAddress { get; set; }


        [Display(Name = "ConfirmEmail")]
        [Compare("ConfirmEmail", ErrorMessage = "The Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please inser your password.")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "You need to provide a long enough password.")]
        public string Password { get; set; }

        [Display(Name = "Password")]
        [Compare("Password", ErrorMessage = " The Password and Confirm Password do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        
        [Display(Name = "SIN")]
        [Required(ErrorMessage = "Please provide Valid SIN.")]
        [StringLength(9, MinimumLength = 8, ErrorMessage = "You must provide a valid SIN.")]

        public string SIN { get; set; }

       

       







    }
}