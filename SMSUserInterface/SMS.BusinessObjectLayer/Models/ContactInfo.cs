
using System.ComponentModel.DataAnnotations;
namespace SMS.BusinessObjectLayer.Models
{
    public class ContactInfo
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Subject { get; set; }

        [Required]
        public string? Message { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
