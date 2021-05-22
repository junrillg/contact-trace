using System.ComponentModel.DataAnnotations;

namespace ContactTrace.Client.Data.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "First Name is too long")]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(15, ErrorMessage = "First Name is too long")]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        public string Address { get; set; }
    }
}