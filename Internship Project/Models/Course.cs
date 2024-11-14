using System.ComponentModel.DataAnnotations;

namespace Internship_Project.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { set; get; }

    }
}
