using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model.Validators
{
    public class DataCheckAttribute : ValidationAttribute
    {

    }

    public class SpaceCheckAttribute: ValidationAttribute { 
        protected override ValidationResult? IsValid(object value, ValidationContext context)
        {
            var input = value as string;
            if (string.IsNullOrWhiteSpace(input))
            {
                return new ValidationResult("Please Enter a valid Value.");
            }
            if(input.Contains(" "))
            {
                return new ValidationResult("Spaces are Not Allowed.");
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    return new ValidationResult("Capital letters are not allowed.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
