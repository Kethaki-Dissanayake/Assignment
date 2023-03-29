using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }
        [Display(Name = "Mobile")]
        public string? Mobile { get; set; }
        public string? FixedLine { get; set; }

        //Relationships
        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public Person? Person { get; set; }
    }
}
