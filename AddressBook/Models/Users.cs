using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace AddressBook.Models
{
    public class Users
    {
        public int ID { get; set; }

        [StringLength(15, MinimumLength = 3)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [StringLength(20, MinimumLength = 3)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        
        [Required]
        [StringLength(30)]
        public string Address { get; set; } = string.Empty;

        
        
        [Range(8, 999999999, ErrorMessage ="Only in 9 number format!")]
        public int Telephone { get; set; }
    }
}
