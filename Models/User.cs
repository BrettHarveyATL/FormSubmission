using System.ComponentModel.DataAnnotations;
using System;

namespace FormSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage="First Name is required!")]
        [MinLength(4)]
        public string FirstName {get; set;}
        [Required(ErrorMessage="Last Name is required!")]
        [MinLength(4)]
        public string LastName {get; set;}
        [Required(ErrorMessage="Age is required!")]
        [Range (1, Int32.MaxValue, ErrorMessage="Needs to be a positive number!")]
        public int Age {get; set;}
        [Required(ErrorMessage="Email is required!")]
        [EmailAddress(ErrorMessage="Needs to be a valid email!")]
        public string Email {get; set;}
        [Required(ErrorMessage="Password is required!")]
        [DataType(DataType.Password)]
        public string Password {get; set;}

    }
}