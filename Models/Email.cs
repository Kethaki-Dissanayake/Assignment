using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Email
    {
        [Key]
        public int EmailID { get; set; }
        [Display(Name = "Email")]
        public string? EmailAddress { get; set; }

        //Relationships

        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
    }
}
