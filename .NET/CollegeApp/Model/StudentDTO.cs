using CollegeApp.Model.Validators;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class StudentDTO
    {

        [ValidateNever]
        public int studentID { get; set; }

        [Required(ErrorMessage ="Please Enter the name")]
        [StringLength(100)]
        public string name { get; set; }

        [Range(15, 30)]
        public int age { get; set; }

        [EmailAddress(ErrorMessage ="Please write correct Email Address.")]
        [SpaceCheck]
        public string email { get; set; }
    }
}
