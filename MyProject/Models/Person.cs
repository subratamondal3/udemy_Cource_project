using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} can't be empty or null")]
        [Display(Name = "Person Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} must " +
            "be between {2} and {1} characters")]
        public string? Name { get; set; }
        [Range(18, 60, ErrorMessage = "{0} must be between {1} and {2}")]
        public int Age { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }
        [Phone(ErrorMessage = "Invalid phone number")]
        public string? Phone { get; set; }
        [Url(ErrorMessage = "Invalid URL")]
        [ValidateNever]
        public string? Website { get; set; }
        public string? Password { get; set; }
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match")]
        public string? ConfirmPassword { get; set; }


        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }
}
