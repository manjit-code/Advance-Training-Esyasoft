using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_CollegeApp.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserName { get; set; } = null!;

        [Required]
        [MaxLength(255)]
        public string Password { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string Role { get; set; } = null!;
    }

}

