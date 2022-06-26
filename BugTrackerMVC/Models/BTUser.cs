using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace BugTrackerMVC.Models
{
    public class BTUser : IdentityUser 
    {
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; } //= String.Empty;

        [Required]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; } //= String.Empty;

        [NotMapped]
        [Display(Name = "Full Name")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        [NotMapped]
        [DataType(DataType.Date)]
        public IFormFile? AvatarFormFile { get; set; }

        [Display(Name = "Avatar")]
        public string? AvatarFileName { get; set; } //= String.Empty;

        public byte[]? AvatarFileData { get; set; } //= { 0 };

        [Display(Name = "File Extension")]
        public string? AvatarContentType { get; set; } //= String.Empty;

        public int? CompanyId { get; set; }

        // Navigation properties
        public virtual Company? Company { get; set; }

        public virtual ICollection<Project>? Projects { get; set; }

    }
}
