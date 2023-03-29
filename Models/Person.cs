using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="*Profile Picture is required")]
        public string? ProfilePicture { get; set; }
        [Display(Name ="First Name")]
        [Required(ErrorMessage = "*First Name is required")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "*Last Name is required")]
        public string? LastName { get; set; }
        [Display(Name = "SSN")]
        public int? SSN { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime? DOB { get; set; }

        //Relationships

        public List<Email> Email { get; set; }
        public List<Address> Address { get; set; }
        public List<Phone> Phone { get; set; }


    }
}
