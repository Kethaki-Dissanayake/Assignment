using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string? HouseNo { get; set; }
        public string? Street { get; set;}
        public string? City { get; set; }
        public string? District { get; set; }
        public int? ZipCode { get; set; }

        //Relationships
        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
    }
}
